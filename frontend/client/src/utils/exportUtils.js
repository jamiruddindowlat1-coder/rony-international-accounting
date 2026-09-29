import jsPDF from 'jspdf';
import 'jspdf-autotable';
import * as XLSX from 'xlsx';

/**
 * Common configuration for exports
 */
const getCompanyInfo = () => {
  // In a real app, this would come from a Context or API
  return {
    name: 'RONY International Accounting Software',
    branch: 'Dhaka Head Office',
    address: '123 Business Avenue, Dhaka, Bangladesh',
    contact: 'Phone: +880 1234 567890 | Email: info@rony.com',
  };
};

// Base64 or URL of the logo
const LOGO_URL = '/assets/logo.png';

/**
 * Helper to load an image from URL and convert to Base64 (needed for jsPDF)
 */
const getBase64ImageFromUrl = async (imageUrl) => {
  const res = await fetch(imageUrl);
  const blob = await res.blob();

  return new Promise((resolve, reject) => {
    const reader = new FileReader();
    reader.onloadend = () => resolve(reader.result);
    reader.onerror = reject;
    reader.readAsDataURL(blob);
  });
};

/**
 * Export data to PDF
 */
export const exportToPDF = async (title, columns, data) => {
  const doc = new jsPDF('p', 'pt', 'a4');
  const companyInfo = getCompanyInfo();
  
  try {
    const logoBase64 = await getBase64ImageFromUrl(LOGO_URL);
    // Add Logo (x, y, width, height)
    doc.addImage(logoBase64, 'PNG', 40, 30, 80, 80);
  } catch (e) {
    console.warn('Could not load logo for PDF', e);
  }

  // Add Company Header
  doc.setFontSize(18);
  doc.setTextColor(26, 106, 186); // Brand Blue
  doc.text(companyInfo.name, 130, 45);
  
  doc.setFontSize(10);
  doc.setTextColor(100, 100, 100);
  doc.text(companyInfo.branch, 130, 60);
  doc.text(companyInfo.address, 130, 75);
  doc.text(companyInfo.contact, 130, 90);

  // Line separator
  doc.setDrawColor(26, 106, 186);
  doc.setLineWidth(1.5);
  doc.line(40, 110, 555, 110);

  // Report Title
  doc.setFontSize(14);
  doc.setTextColor(0, 0, 0);
  doc.text(`Report: ${title}`, 40, 135);
  
  doc.setFontSize(9);
  doc.text(`Generated on: ${new Date().toLocaleString()}`, 40, 150);

  // Table
  const tableColumnNames = columns.map(c => c.label);
  const tableRows = data.map(row => 
    columns.map(col => {
      const val = row[col.name];
      if (typeof val === 'boolean') return val ? 'Yes' : 'No';
      if (val === null || val === undefined) return '-';
      return String(val);
    })
  );

  doc.autoTable({
    startY: 165,
    head: [tableColumnNames],
    body: tableRows,
    theme: 'grid',
    headStyles: {
      fillColor: [26, 106, 186],
      textColor: 255,
      fontSize: 10,
    },
    bodyStyles: {
      fontSize: 9,
    },
    alternateRowStyles: {
      fillColor: [245, 248, 250],
    },
    margin: { top: 165, left: 40, right: 40 },
    didDrawPage: function (data) {
      // Footer with page number
      let str = 'Page ' + doc.internal.getNumberOfPages();
      doc.setFontSize(8);
      doc.setTextColor(150);
      const pageSize = doc.internal.pageSize;
      const pageHeight = pageSize.height ? pageSize.height : pageSize.getHeight();
      doc.text(str, data.settings.margin.left, pageHeight - 20);
      doc.text('RONY International Accounting Software', pageSize.width - 200, pageHeight - 20);
    },
  });

  doc.save(`${title.replace(/\s+/g, '_')}_Report.pdf`);
};

/**
 * Export data to Excel
 */
export const exportToExcel = (title, columns, data) => {
  const companyInfo = getCompanyInfo();
  
  // Format data for Excel
  const formattedData = data.map(row => {
    const newRow = {};
    columns.forEach(col => {
      let val = row[col.name];
      if (typeof val === 'boolean') val = val ? 'Yes' : 'No';
      if (val === null || val === undefined) val = '-';
      newRow[col.label] = val;
    });
    return newRow;
  });

  // Create workbook and worksheet
  const wb = XLSX.utils.book_new();
  const ws = XLSX.utils.json_to_sheet([]);

  // Add Headers (Company Info + Report Title)
  XLSX.utils.sheet_add_aoa(ws, [
    [companyInfo.name],
    [companyInfo.branch],
    [companyInfo.address],
    [`Report: ${title}`],
    [`Generated on: ${new Date().toLocaleString()}`],
    [] // Empty row before data
  ], { origin: "A1" });

  // Add the actual data table
  XLSX.utils.sheet_add_json(ws, formattedData, { origin: "A7" });

  // Append worksheet to workbook
  XLSX.utils.book_append_sheet(wb, ws, 'Report');

  // Generate Excel file and trigger download
  XLSX.writeFile(wb, `${title.replace(/\s+/g, '_')}_Report.xlsx`);
};
