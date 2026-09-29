export const taxEntities = [
  {
    "key": "taxJurisdictions",
    "label": "Tax Jurisdiction",
    "endpoint": "/api/TaxJurisdictions",
    "module": "Tax",
    "isGlobal": true,
    "fields": [
      {
        "name": "countryCode",
        "label": "Country Code",
        "type": "text",
        "required": true
      },
      {
        "name": "region",
        "label": "Region",
        "type": "text",
        "required": true
      },
      {
        "name": "name",
        "label": "Name",
        "type": "text",
        "required": true
      }
    ]
  },
  {
    "key": "taxTypes",
    "label": "Tax Type",
    "endpoint": "/api/TaxTypes",
    "module": "Tax",
    "isGlobal": true,
    "fields": [
      {
        "name": "name",
        "label": "Name",
        "type": "text",
        "required": true
      },
      {
        "name": "description",
        "label": "Description",
        "type": "text",
        "required": true
      }
    ]
  },
  {
    "key": "taxCodes",
    "label": "Tax Code",
    "endpoint": "/api/TaxCodes",
    "module": "Tax",
    "isGlobal": false,
    "fields": [
      {
        "name": "taxTypeId",
        "label": "Tax Type Id",
        "type": "number",
        "required": true
      },
      {
        "name": "jurisdictionId",
        "label": "Jurisdiction Id",
        "type": "number",
        "required": true
      },
      {
        "name": "code",
        "label": "Code",
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
        "name": "rate",
        "label": "Rate",
        "type": "number",
        "required": true
      },
      {
        "name": "effectiveFrom",
        "label": "Effective From",
        "type": "date",
        "required": false
      },
      {
        "name": "effectiveTo",
        "label": "Effective To",
        "type": "date",
        "required": false
      },
      {
        "name": "isCompound",
        "label": "Is Compound",
        "type": "checkbox",
        "required": true
      },
      {
        "name": "isRecoverable",
        "label": "Is Recoverable",
        "type": "checkbox",
        "required": true
      },
      {
        "name": "payableAccountId",
        "label": "Payable Account Id",
        "type": "number",
        "required": false
      },
      {
        "name": "receivableAccountId",
        "label": "Receivable Account Id",
        "type": "number",
        "required": false
      }
    ]
  },
  {
    "key": "taxTransactions",
    "label": "Tax Transaction",
    "endpoint": "/api/TaxTransactions",
    "module": "Tax",
    "isGlobal": false,
    "fields": [
      {
        "name": "sourceDocumentType",
        "label": "Source Document Type",
        "type": "text",
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
        "name": "taxableAmount",
        "label": "Taxable Amount",
        "type": "number",
        "required": true
      },
      {
        "name": "taxAmount",
        "label": "Tax Amount",
        "type": "number",
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
