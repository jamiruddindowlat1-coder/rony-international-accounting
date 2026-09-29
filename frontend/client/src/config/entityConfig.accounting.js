export const accountingEntities = [
  {
    "key": "accountTypes",
    "label": "Account Type",
    "endpoint": "/api/AccountTypes",
    "module": "Accounting",
    "isGlobal": true,
    "fields": [
      {
        "name": "name",
        "label": "Name",
        "type": "text",
        "required": true
      },
      {
        "name": "normalBalance",
        "label": "Normal Balance",
        "type": "text",
        "required": true
      }
    ]
  },
  {
    "key": "accountGroups",
    "label": "Account Group",
    "endpoint": "/api/AccountGroups",
    "module": "Accounting",
    "isGlobal": false,
    "fields": [
      {
        "name": "parentGroupId",
        "label": "Parent Group Id",
        "type": "number",
        "required": false
      },
      {
        "name": "name",
        "label": "Name",
        "type": "text",
        "required": true
      },
      {
        "name": "accountTypeId",
        "label": "Account Type Id",
        "type": "number",
        "required": true
      },
      {
        "name": "displayOrder",
        "label": "Display Order",
        "type": "number",
        "required": true
      }
    ]
  },
  {
    "key": "chartOfAccounts",
    "label": "Chart Of Account",
    "endpoint": "/api/ChartOfAccounts",
    "module": "Accounting",
    "isGlobal": false,
    "fields": [
      {
        "name": "accountCode",
        "label": "Account Code",
        "type": "text",
        "required": true
      },
      {
        "name": "accountName",
        "label": "Account Name",
        "type": "text",
        "required": true
      },
      {
        "name": "parentAccountId",
        "label": "Parent Account Id",
        "type": "number",
        "required": false
      },
      {
        "name": "accountGroupId",
        "label": "Account Group Id",
        "type": "number",
        "required": true
      },
      {
        "name": "accountTypeId",
        "label": "Account Type Id",
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
        "name": "isControlAccount",
        "label": "Is Control Account",
        "type": "checkbox",
        "required": true
      },
      {
        "name": "controlAccountFor",
        "label": "Control Account For",
        "type": "text",
        "required": true
      },
      {
        "name": "allowManualEntry",
        "label": "Allow Manual Entry",
        "type": "checkbox",
        "required": true
      },
      {
        "name": "openingBalance",
        "label": "Opening Balance",
        "type": "number",
        "required": false
      },
      {
        "name": "openingBalanceDate",
        "label": "Opening Balance Date",
        "type": "date",
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
    "key": "journalEntries",
    "label": "Journal Entry",
    "endpoint": "/api/JournalEntries",
    "module": "Accounting",
    "isGlobal": false,
    "fields": [
      {
        "name": "branchId",
        "label": "Branch Id",
        "type": "number",
        "required": true
      },
      {
        "name": "accountingPeriodId",
        "label": "Accounting Period Id",
        "type": "number",
        "required": true
      },
      {
        "name": "voucherNumber",
        "label": "Voucher Number",
        "type": "text",
        "required": true
      },
      {
        "name": "voucherDate",
        "label": "Voucher Date",
        "type": "date",
        "required": true
      },
      {
        "name": "voucherType",
        "label": "Voucher Type",
        "type": "select",
        "required": true,
        "options": [
          { "value": "Journal", "label": "Journal" },
          { "value": "Payment", "label": "Payment" },
          { "value": "Receipt", "label": "Receipt" },
          { "value": "Purchase", "label": "Purchase" },
          { "value": "Sales", "label": "Sales" },
          { "value": "Contra", "label": "Contra" },
          { "value": "Adjustment", "label": "Adjustment" }
        ]
      },
      {
        "name": "sourceModule",
        "label": "Source Module",
        "type": "text",
        "required": true
      },
      {
        "name": "sourceDocumentId",
        "label": "Source Document Id",
        "type": "number",
        "required": false
      },
      {
        "name": "reference",
        "label": "Reference",
        "type": "text",
        "required": true
      },
      {
        "name": "narration",
        "label": "Narration",
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
      },
      {
        "name": "status",
        "label": "Status",
        "type": "text",
        "required": true
      },
      {
        "name": "postedAt",
        "label": "Posted At",
        "type": "date",
        "required": false
      },
      {
        "name": "postedBy",
        "label": "Posted By",
        "type": "number",
        "required": false
      },
      {
        "name": "reversalOfEntryId",
        "label": "Reversal Of Entry Id",
        "type": "number",
        "required": false
      }
    ]
  },
  {
    "key": "journalEntryLines",
    "label": "Journal Entry Line",
    "endpoint": "/api/JournalEntryLines",
    "module": "Accounting",
    "isGlobal": false,
    "fields": [
      {
        "name": "journalEntryId",
        "label": "Journal Entry Id",
        "type": "number",
        "required": true
      },
      {
        "name": "lineNumber",
        "label": "Line Number",
        "type": "number",
        "required": true
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
        "name": "departmentId",
        "label": "Department Id",
        "type": "number",
        "required": false
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
        "name": "baseCurrencyDebit",
        "label": "Base Currency Debit",
        "type": "number",
        "required": true
      },
      {
        "name": "baseCurrencyCredit",
        "label": "Base Currency Credit",
        "type": "number",
        "required": true
      },
      {
        "name": "description",
        "label": "Description",
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
        "name": "taxCodeId",
        "label": "Tax Code Id",
        "type": "number",
        "required": false
      },
      {
        "name": "reconciliationStatus",
        "label": "Reconciliation Status",
        "type": "text",
        "required": true
      }
    ]
  },
  {
    "key": "recurringJournalTemplates",
    "label": "Recurring Journal Template",
    "endpoint": "/api/RecurringJournalTemplates",
    "module": "Accounting",
    "isGlobal": false,
    "fields": [
      {
        "name": "name",
        "label": "Name",
        "type": "text",
        "required": true
      },
      {
        "name": "frequency",
        "label": "Frequency",
        "type": "text",
        "required": true
      },
      {
        "name": "nextRunDate",
        "label": "Next Run Date",
        "type": "date",
        "required": true
      },
      {
        "name": "templateLinesJson",
        "label": "Template Lines Json",
        "type": "text",
        "required": true
      },
      {
        "name": "isActive",
        "label": "Is Active",
        "type": "checkbox",
        "required": true
      }
    ]
  }
];

