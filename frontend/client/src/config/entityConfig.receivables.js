export const receivablesEntities = [
  {
    "key": "customers",
    "label": "Customer",
    "endpoint": "/api/Customers",
    "module": "Receivables",
    "isGlobal": false,
    "fields": [
      {
        "name": "customerCode",
        "label": "Customer Code",
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
    "key": "customerContacts",
    "label": "Customer Contact",
    "endpoint": "/api/CustomerContacts",
    "module": "Receivables",
    "isGlobal": false,
    "fields": [
      {
        "name": "customerId",
        "label": "Customer Id",
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
    "key": "customerBankAccounts",
    "label": "Customer Bank Account",
    "endpoint": "/api/CustomerBankAccounts",
    "module": "Receivables",
    "isGlobal": false,
    "fields": [
      {
        "name": "customerId",
        "label": "Customer Id",
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
      }
    ]
  },
  {
    "key": "salesOrders",
    "label": "Sales Order",
    "endpoint": "/api/SalesOrders",
    "module": "Receivables",
    "isGlobal": false,
    "fields": [
      {
        "name": "customerId",
        "label": "Customer Id",
        "type": "number",
        "required": true
      },
      {
        "name": "soNumber",
        "label": "SO Number",
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
    "key": "salesOrderLines",
    "label": "Sales Order Line",
    "endpoint": "/api/SalesOrderLines",
    "module": "Receivables",
    "isGlobal": false,
    "fields": [
      {
        "name": "salesOrderId",
        "label": "Sales Order Id",
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
      }
    ]
  },
  {
    "key": "salesInvoices",
    "label": "Sales Invoice",
    "endpoint": "/api/SalesInvoices",
    "module": "Receivables",
    "isGlobal": false,
    "fields": [
      {
        "name": "branchId",
        "label": "Branch Id",
        "type": "number",
        "required": true
      },
      {
        "name": "customerId",
        "label": "Customer Id",
        "type": "number",
        "required": true
      },
      {
        "name": "salesOrderId",
        "label": "Sales Order Id",
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
    "key": "salesInvoiceLines",
    "label": "Sales Invoice Line",
    "endpoint": "/api/SalesInvoiceLines",
    "module": "Receivables",
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
    "key": "customerReceipts",
    "label": "Customer Receipt",
    "endpoint": "/api/CustomerReceipts",
    "module": "Receivables",
    "isGlobal": false,
    "fields": [
      {
        "name": "customerId",
        "label": "Customer Id",
        "type": "number",
        "required": true
      },
      {
        "name": "receiptNumber",
        "label": "Receipt Number",
        "type": "text",
        "required": true
      },
      {
        "name": "receiptDate",
        "label": "Receipt Date",
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
    "key": "customerReceiptAllocations",
    "label": "Customer Receipt Allocation",
    "endpoint": "/api/CustomerReceiptAllocations",
    "module": "Receivables",
    "isGlobal": false,
    "fields": [
      {
        "name": "receiptId",
        "label": "Receipt Id",
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
    "key": "customerCreditNotes",
    "label": "Customer Credit Note",
    "endpoint": "/api/CustomerCreditNotes",
    "module": "Receivables",
    "isGlobal": false,
    "fields": [
      {
        "name": "customerId",
        "label": "Customer Id",
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
    "key": "badDebtWriteOffs",
    "label": "Bad Debt Write Off",
    "endpoint": "/api/BadDebtWriteOffs",
    "module": "Receivables",
    "isGlobal": false,
    "fields": [
      {
        "name": "customerId",
        "label": "Customer Id",
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
        "name": "approvedBy",
        "label": "Approved By",
        "type": "number",
        "required": false
      },
      {
        "name": "journalEntryId",
        "label": "Journal Entry Id",
        "type": "number",
        "required": false
      }
    ]
  }
];
