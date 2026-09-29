export const payablesEntities = [
  {
    "key": "vendors",
    "label": "Vendor",
    "endpoint": "/api/Vendors",
    "module": "Payables",
    "isGlobal": false,
    "fields": [
      {
        "name": "vendorCode",
        "label": "Vendor Code",
        "type": "text",
        "required": true
      },
      {
        "name": "name",
        "label": "Name",
        "type": "text",
        "required": true
      },
      {
        "name": "legalName",
        "label": "Legal Name",
        "type": "text",
        "required": true
      },
      {
        "name": "taxIdentificationNumber",
        "label": "Tax Identification Number",
        "type": "text",
        "required": true
      },
      {
        "name": "countryCode",
        "label": "Country Code",
        "type": "text",
        "required": true
      },
      {
        "name": "defaultCurrencyCode",
        "label": "Default Currency Code",
        "type": "text",
        "required": true
      },
      {
        "name": "paymentTermsDays",
        "label": "Payment Terms Days",
        "type": "number",
        "required": true
      },
      {
        "name": "controlAccountId",
        "label": "Control Account Id",
        "type": "number",
        "required": true
      },
      {
        "name": "defaultExpenseAccountId",
        "label": "Default Expense Account Id",
        "type": "number",
        "required": false
      },
      {
        "name": "creditLimit",
        "label": "Credit Limit",
        "type": "number",
        "required": false
      },
      {
        "name": "isActive",
        "label": "Is Active",
        "type": "checkbox",
        "required": true
      }
    ]
  },
  {
    "key": "vendorContacts",
    "label": "Vendor Contact",
    "endpoint": "/api/VendorContacts",
    "module": "Payables",
    "isGlobal": false,
    "fields": [
      {
        "name": "vendorId",
        "label": "Vendor Id",
        "type": "number",
        "required": true
      },
      {
        "name": "name",
        "label": "Name",
        "type": "text",
        "required": true
      },
      {
        "name": "designation",
        "label": "Designation",
        "type": "text",
        "required": true
      },
      {
        "name": "email",
        "label": "Email",
        "type": "text",
        "required": true
      },
      {
        "name": "phone",
        "label": "Phone",
        "type": "text",
        "required": true
      },
      {
        "name": "isPrimary",
        "label": "Is Primary",
        "type": "checkbox",
        "required": true
      }
    ]
  },
  {
    "key": "vendorBankAccounts",
    "label": "Vendor Bank Account",
    "endpoint": "/api/VendorBankAccounts",
    "module": "Payables",
    "isGlobal": false,
    "fields": [
      {
        "name": "vendorId",
        "label": "Vendor Id",
        "type": "number",
        "required": true
      },
      {
        "name": "bankName",
        "label": "Bank Name",
        "type": "text",
        "required": true
      },
      {
        "name": "accountNumber",
        "label": "Account Number",
        "type": "text",
        "required": true
      },
      {
        "name": "iban",
        "label": "I B A N",
        "type": "text",
        "required": true
      },
      {
        "name": "swiftCode",
        "label": "Swift Code",
        "type": "text",
        "required": true
      },
      {
        "name": "currencyCode",
        "label": "Currency Code",
        "type": "text",
        "required": true
      }
    ]
  },
  {
    "key": "purchaseOrders",
    "label": "Purchase Order",
    "endpoint": "/api/PurchaseOrders",
    "module": "Payables",
    "isGlobal": false,
    "fields": [
      {
        "name": "vendorId",
        "label": "Vendor Id",
        "type": "number",
        "required": true
      },
      {
        "name": "poNumber",
        "label": "P O Number",
        "type": "text",
        "required": true
      },
      {
        "name": "orderDate",
        "label": "Order Date",
        "type": "date",
        "required": true
      },
      {
        "name": "expectedDate",
        "label": "Expected Date",
        "type": "date",
        "required": false
      },
      {
        "name": "status",
        "label": "Status",
        "type": "text",
        "required": true
      },
      {
        "name": "currencyCode",
        "label": "Currency Code",
        "type": "text",
        "required": true
      },
      {
        "name": "exchangeRateToBase",
        "label": "Exchange Rate To Base",
        "type": "number",
        "required": true
      }
    ]
  },
  {
    "key": "purchaseOrderLines",
    "label": "Purchase Order Line",
    "endpoint": "/api/PurchaseOrderLines",
    "module": "Payables",
    "isGlobal": false,
    "fields": [
      {
        "name": "purchaseOrderId",
        "label": "Purchase Order Id",
        "type": "number",
        "required": true
      },
      {
        "name": "itemId",
        "label": "Item Id",
        "type": "number",
        "required": false
      },
      {
        "name": "description",
        "label": "Description",
        "type": "text",
        "required": true
      },
      {
        "name": "quantity",
        "label": "Quantity",
        "type": "number",
        "required": true
      },
      {
        "name": "unitPrice",
        "label": "Unit Price",
        "type": "number",
        "required": true
      },
      {
        "name": "taxCodeId",
        "label": "Tax Code Id",
        "type": "number",
        "required": false
      },
      {
        "name": "accountId",
        "label": "Account Id",
        "type": "number",
        "required": false
      }
    ]
  },
  {
    "key": "purchaseInvoices",
    "label": "Purchase Invoice",
    "endpoint": "/api/PurchaseInvoices",
    "module": "Payables",
    "isGlobal": false,
    "fields": [
      {
        "name": "branchId",
        "label": "Branch Id",
        "type": "number",
        "required": true
      },
      {
        "name": "vendorId",
        "label": "Vendor Id",
        "type": "number",
        "required": true
      },
      {
        "name": "purchaseOrderId",
        "label": "Purchase Order Id",
        "type": "number",
        "required": false
      },
      {
        "name": "invoiceNumber",
        "label": "Invoice Number",
        "type": "text",
        "required": true
      },
      {
        "name": "vendorInvoiceReference",
        "label": "Vendor Invoice Reference",
        "type": "text",
        "required": true
      },
      {
        "name": "invoiceDate",
        "label": "Invoice Date",
        "type": "date",
        "required": true
      },
      {
        "name": "dueDate",
        "label": "Due Date",
        "type": "date",
        "required": true
      },
      {
        "name": "currencyCode",
        "label": "Currency Code",
        "type": "text",
        "required": true
      },
      {
        "name": "exchangeRateToBase",
        "label": "Exchange Rate To Base",
        "type": "number",
        "required": true
      },
      {
        "name": "subTotal",
        "label": "Sub Total",
        "type": "number",
        "required": true
      },
      {
        "name": "taxTotal",
        "label": "Tax Total",
        "type": "number",
        "required": true
      },
      {
        "name": "totalAmount",
        "label": "Total Amount",
        "type": "number",
        "required": true
      },
      {
        "name": "status",
        "label": "Status",
        "type": "text",
        "required": true
      },
      {
        "name": "journalEntryId",
        "label": "Journal Entry Id",
        "type": "number",
        "required": false
      }
    ]
  },
  {
    "key": "purchaseInvoiceLines",
    "label": "Purchase Invoice Line",
    "endpoint": "/api/PurchaseInvoiceLines",
    "module": "Payables",
    "isGlobal": false,
    "fields": [
      {
        "name": "invoiceId",
        "label": "Invoice Id",
        "type": "number",
        "required": true
      },
      {
        "name": "itemId",
        "label": "Item Id",
        "type": "number",
        "required": false
      },
      {
        "name": "description",
        "label": "Description",
        "type": "text",
        "required": true
      },
      {
        "name": "quantity",
        "label": "Quantity",
        "type": "number",
        "required": true
      },
      {
        "name": "unitPrice",
        "label": "Unit Price",
        "type": "number",
        "required": true
      },
      {
        "name": "taxCodeId",
        "label": "Tax Code Id",
        "type": "number",
        "required": false
      },
      {
        "name": "accountId",
        "label": "Account Id",
        "type": "number",
        "required": true
      },
      {
        "name": "costCenterId",
        "label": "Cost Center Id",
        "type": "number",
        "required": false
      },
      {
        "name": "projectId",
        "label": "Project Id",
        "type": "number",
        "required": false
      },
      {
        "name": "lineTotal",
        "label": "Line Total",
        "type": "number",
        "required": true
      }
    ]
  },
  {
    "key": "vendorPayments",
    "label": "Vendor Payment",
    "endpoint": "/api/VendorPayments",
    "module": "Payables",
    "isGlobal": false,
    "fields": [
      {
        "name": "vendorId",
        "label": "Vendor Id",
        "type": "number",
        "required": true
      },
      {
        "name": "paymentNumber",
        "label": "Payment Number",
        "type": "text",
        "required": true
      },
      {
        "name": "paymentDate",
        "label": "Payment Date",
        "type": "date",
        "required": true
      },
      {
        "name": "paymentMethod",
        "label": "Payment Method",
        "type": "text",
        "required": true
      },
      {
        "name": "bankAccountId",
        "label": "Bank Account Id",
        "type": "number",
        "required": true
      },
      {
        "name": "currencyCode",
        "label": "Currency Code",
        "type": "text",
        "required": true
      },
      {
        "name": "exchangeRateToBase",
        "label": "Exchange Rate To Base",
        "type": "number",
        "required": true
      },
      {
        "name": "amount",
        "label": "Amount",
        "type": "number",
        "required": true
      },
      {
        "name": "journalEntryId",
        "label": "Journal Entry Id",
        "type": "number",
        "required": false
      },
      {
        "name": "status",
        "label": "Status",
        "type": "text",
        "required": true
      }
    ]
  },
  {
    "key": "vendorPaymentAllocations",
    "label": "Vendor Payment Allocation",
    "endpoint": "/api/VendorPaymentAllocations",
    "module": "Payables",
    "isGlobal": false,
    "fields": [
      {
        "name": "paymentId",
        "label": "Payment Id",
        "type": "number",
        "required": true
      },
      {
        "name": "invoiceId",
        "label": "Invoice Id",
        "type": "number",
        "required": true
      },
      {
        "name": "allocatedAmount",
        "label": "Allocated Amount",
        "type": "number",
        "required": true
      }
    ]
  },
  {
    "key": "vendorCreditNotes",
    "label": "Vendor Credit Note",
    "endpoint": "/api/VendorCreditNotes",
    "module": "Payables",
    "isGlobal": false,
    "fields": [
      {
        "name": "vendorId",
        "label": "Vendor Id",
        "type": "number",
        "required": true
      },
      {
        "name": "creditNoteNumber",
        "label": "Credit Note Number",
        "type": "text",
        "required": true
      },
      {
        "name": "date",
        "label": "Date",
        "type": "date",
        "required": true
      },
      {
        "name": "amount",
        "label": "Amount",
        "type": "number",
        "required": true
      },
      {
        "name": "reason",
        "label": "Reason",
        "type": "text",
        "required": true
      },
      {
        "name": "journalEntryId",
        "label": "Journal Entry Id",
        "type": "number",
        "required": false
      }
    ]
  },
  {
    "key": "withholdingTaxEntries",
    "label": "Withholding Tax Entry",
    "endpoint": "/api/WithholdingTaxEntries",
    "module": "Payables",
    "isGlobal": false,
    "fields": [
      {
        "name": "vendorId",
        "label": "Vendor Id",
        "type": "number",
        "required": true
      },
      {
        "name": "sourceDocumentId",
        "label": "Source Document Id",
        "type": "number",
        "required": true
      },
      {
        "name": "taxCodeId",
        "label": "Tax Code Id",
        "type": "number",
        "required": true
      },
      {
        "name": "amount",
        "label": "Amount",
        "type": "number",
        "required": true
      },
      {
        "name": "certificateNumber",
        "label": "Certificate Number",
        "type": "text",
        "required": true
      }
    ]
  }
];
