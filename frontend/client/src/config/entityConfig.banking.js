export const bankingEntities = [
  {
    "key": "bankAccounts",
    "label": "Bank Account",
    "endpoint": "/api/BankAccounts",
    "module": "Banking",
    "isGlobal": false,
    "fields": [
      {
        "name": "accountName",
        "label": "Account Name",
        "type": "text",
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
      },
      {
        "name": "glAccountId",
        "label": "G L Account Id",
        "type": "number",
        "required": true
      },
      {
        "name": "openingBalance",
        "label": "Opening Balance",
        "type": "number",
        "required": true
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
    "key": "bankTransactions",
    "label": "Bank Transaction",
    "endpoint": "/api/BankTransactions",
    "module": "Banking",
    "isGlobal": false,
    "fields": [
      {
        "name": "bankAccountId",
        "label": "Bank Account Id",
        "type": "number",
        "required": true
      },
      {
        "name": "transactionDate",
        "label": "Transaction Date",
        "type": "date",
        "required": true
      },
      {
        "name": "valueDate",
        "label": "Value Date",
        "type": "date",
        "required": false
      },
      {
        "name": "description",
        "label": "Description",
        "type": "text",
        "required": true
      },
      {
        "name": "referenceNumber",
        "label": "Reference Number",
        "type": "text",
        "required": true
      },
      {
        "name": "debitAmount",
        "label": "Debit Amount",
        "type": "number",
        "required": true
      },
      {
        "name": "creditAmount",
        "label": "Credit Amount",
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
        "name": "reconciliationStatus",
        "label": "Reconciliation Status",
        "type": "text",
        "required": true
      },
      {
        "name": "reconciledOnStatementId",
        "label": "Reconciled On Statement Id",
        "type": "number",
        "required": false
      }
    ]
  },
  {
    "key": "bankStatementImports",
    "label": "Bank Statement Import",
    "endpoint": "/api/BankStatementImports",
    "module": "Banking",
    "isGlobal": false,
    "fields": [
      {
        "name": "bankAccountId",
        "label": "Bank Account Id",
        "type": "number",
        "required": true
      },
      {
        "name": "importDate",
        "label": "Import Date",
        "type": "date",
        "required": true
      },
      {
        "name": "fileName",
        "label": "File Name",
        "type": "text",
        "required": true
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
    "key": "bankReconciliations",
    "label": "Bank Reconciliation",
    "endpoint": "/api/BankReconciliations",
    "module": "Banking",
    "isGlobal": false,
    "fields": [
      {
        "name": "bankAccountId",
        "label": "Bank Account Id",
        "type": "number",
        "required": true
      },
      {
        "name": "reconciliationDate",
        "label": "Reconciliation Date",
        "type": "date",
        "required": true
      },
      {
        "name": "statementBalance",
        "label": "Statement Balance",
        "type": "number",
        "required": true
      },
      {
        "name": "bookBalance",
        "label": "Book Balance",
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
        "name": "reconciledBy",
        "label": "Reconciled By",
        "type": "number",
        "required": false
      }
    ]
  },
  {
    "key": "chequeRegisterEntries",
    "label": "Cheque Register Entry",
    "endpoint": "/api/ChequeRegisterEntries",
    "module": "Banking",
    "isGlobal": false,
    "fields": [
      {
        "name": "bankAccountId",
        "label": "Bank Account Id",
        "type": "number",
        "required": true
      },
      {
        "name": "chequeNumber",
        "label": "Cheque Number",
        "type": "text",
        "required": true
      },
      {
        "name": "chequeDate",
        "label": "Cheque Date",
        "type": "date",
        "required": true
      },
      {
        "name": "direction",
        "label": "Direction",
        "type": "text",
        "required": true
      },
      {
        "name": "partyType",
        "label": "Party Type",
        "type": "text",
        "required": true
      },
      {
        "name": "partyId",
        "label": "Party Id",
        "type": "number",
        "required": false
      },
      {
        "name": "amount",
        "label": "Amount",
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
        "name": "linkedPaymentId",
        "label": "Linked Payment Id",
        "type": "number",
        "required": false
      },
      {
        "name": "linkedReceiptId",
        "label": "Linked Receipt Id",
        "type": "number",
        "required": false
      }
    ]
  },
  {
    "key": "pettyCashAccounts",
    "label": "Petty Cash Account",
    "endpoint": "/api/PettyCashAccounts",
    "module": "Banking",
    "isGlobal": false,
    "fields": [
      {
        "name": "name",
        "label": "Name",
        "type": "text",
        "required": true
      },
      {
        "name": "custodianUserId",
        "label": "Custodian User Id",
        "type": "number",
        "required": true
      },
      {
        "name": "glAccountId",
        "label": "G L Account Id",
        "type": "number",
        "required": true
      },
      {
        "name": "imprestLimit",
        "label": "Imprest Limit",
        "type": "number",
        "required": true
      }
    ]
  },
  {
    "key": "pettyCashTransactions",
    "label": "Petty Cash Transaction",
    "endpoint": "/api/PettyCashTransactions",
    "module": "Banking",
    "isGlobal": false,
    "fields": [
      {
        "name": "pettyCashAccountId",
        "label": "Petty Cash Account Id",
        "type": "number",
        "required": true
      },
      {
        "name": "date",
        "label": "Date",
        "type": "date",
        "required": true
      },
      {
        "name": "description",
        "label": "Description",
        "type": "text",
        "required": true
      },
      {
        "name": "amount",
        "label": "Amount",
        "type": "number",
        "required": true
      },
      {
        "name": "type",
        "label": "Type",
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
  }
];
