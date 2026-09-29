export const coreEntities = [
  {
    "key": "companies",
    "label": "Company",
    "endpoint": "/api/Companies",
    "module": "Core",
    "isGlobal": true,
    "fields": [
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
        "name": "registrationNumber",
        "label": "Registration Number",
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
        "name": "baseCurrencyCode",
        "label": "Base Currency Code",
        "type": "text",
        "required": true
      },
      {
        "name": "fiscalYearStartMonth",
        "label": "Fiscal Year Start Month",
        "type": "number",
        "required": true
      },
      {
        "name": "address",
        "label": "Address",
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
        "name": "email",
        "label": "Email",
        "type": "text",
        "required": true
      },
      {
        "name": "logoPath",
        "label": "Logo Path",
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
  },
  {
    "key": "branches",
    "label": "Branch",
    "endpoint": "/api/Branches",
    "module": "Core",
    "isGlobal": false,
    "fields": [
      {
        "name": "name",
        "label": "Name",
        "type": "text",
        "required": true
      },
      {
        "name": "code",
        "label": "Code",
        "type": "text",
        "required": true
      },
      {
        "name": "address",
        "label": "Address",
        "type": "text",
        "required": true
      },
      {
        "name": "isHeadOffice",
        "label": "Is Head Office",
        "type": "checkbox",
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
    "key": "countries",
    "label": "Country",
    "endpoint": "/api/Countries",
    "module": "Core",
    "isGlobal": true,
    "fields": [
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
      }
    ]
  },
  {
    "key": "currencies",
    "label": "Currency",
    "endpoint": "/api/Currencies",
    "module": "Core",
    "isGlobal": true,
    "fields": [
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
        "name": "symbol",
        "label": "Symbol",
        "type": "text",
        "required": true
      },
      {
        "name": "decimalPlaces",
        "label": "Decimal Places",
        "type": "number",
        "required": true
      }
    ]
  },
  {
    "key": "exchangeRates",
    "label": "Exchange Rate",
    "endpoint": "/api/ExchangeRates",
    "module": "Core",
    "isGlobal": false,
    "fields": [
      {
        "name": "fromCurrencyCode",
        "label": "From Currency Code",
        "type": "text",
        "required": true
      },
      {
        "name": "toCurrencyCode",
        "label": "To Currency Code",
        "type": "text",
        "required": true
      },
      {
        "name": "rateDate",
        "label": "Rate Date",
        "type": "date",
        "required": true
      },
      {
        "name": "rate",
        "label": "Rate",
        "type": "number",
        "required": true
      },
      {
        "name": "rateType",
        "label": "Rate Type",
        "type": "text",
        "required": true
      },
      {
        "name": "source",
        "label": "Source",
        "type": "text",
        "required": true
      }
    ]
  },
  {
    "key": "fiscalYears",
    "label": "Fiscal Year",
    "endpoint": "/api/FiscalYears",
    "module": "Core",
    "isGlobal": false,
    "fields": [
      {
        "name": "name",
        "label": "Name",
        "type": "text",
        "required": true
      },
      {
        "name": "startDate",
        "label": "Start Date",
        "type": "date",
        "required": true
      },
      {
        "name": "endDate",
        "label": "End Date",
        "type": "date",
        "required": true
      },
      {
        "name": "isClosed",
        "label": "Is Closed",
        "type": "checkbox",
        "required": true
      },
      {
        "name": "closedAt",
        "label": "Closed At",
        "type": "date",
        "required": false
      }
    ]
  },
  {
    "key": "accountingPeriods",
    "label": "Accounting Period",
    "endpoint": "/api/AccountingPeriods",
    "module": "Core",
    "isGlobal": false,
    "fields": [
      {
        "name": "fiscalYearId",
        "label": "Fiscal Year Id",
        "type": "number",
        "required": true
      },
      {
        "name": "periodNumber",
        "label": "Period Number",
        "type": "number",
        "required": true
      },
      {
        "name": "startDate",
        "label": "Start Date",
        "type": "date",
        "required": true
      },
      {
        "name": "endDate",
        "label": "End Date",
        "type": "date",
        "required": true
      },
      {
        "name": "isClosed",
        "label": "Is Closed",
        "type": "checkbox",
        "required": true
      },
      {
        "name": "closedAt",
        "label": "Closed At",
        "type": "date",
        "required": false
      }
    ]
  },
  {
    "key": "numberSequences",
    "label": "Number Sequence",
    "endpoint": "/api/NumberSequences",
    "module": "Core",
    "isGlobal": false,
    "fields": [
      {
        "name": "branchId",
        "label": "Branch Id",
        "type": "number",
        "required": false
      },
      {
        "name": "documentType",
        "label": "Document Type",
        "type": "text",
        "required": true
      },
      {
        "name": "prefix",
        "label": "Prefix",
        "type": "text",
        "required": true
      },
      {
        "name": "nextNumber",
        "label": "Next Number",
        "type": "number",
        "required": true
      },
      {
        "name": "paddingLength",
        "label": "Padding Length",
        "type": "number",
        "required": true
      },
      {
        "name": "resetFrequency",
        "label": "Reset Frequency",
        "type": "text",
        "required": true
      },
      {
        "name": "lastResetDate",
        "label": "Last Reset Date",
        "type": "date",
        "required": false
      }
    ]
  },
  {
    "key": "attachments",
    "label": "Attachment",
    "endpoint": "/api/Attachments",
    "module": "Core",
    "isGlobal": false,
    "fields": [
      {
        "name": "entityType",
        "label": "Entity Type",
        "type": "text",
        "required": true
      },
      {
        "name": "entityId",
        "label": "Entity Id",
        "type": "number",
        "required": true
      },
      {
        "name": "fileName",
        "label": "File Name",
        "type": "text",
        "required": true
      },
      {
        "name": "filePath",
        "label": "File Path",
        "type": "text",
        "required": true
      },
      {
        "name": "fileSizeBytes",
        "label": "File Size Bytes",
        "type": "number",
        "required": true
      },
      {
        "name": "contentType",
        "label": "Content Type",
        "type": "text",
        "required": true
      },
      {
        "name": "uploadedBy",
        "label": "Uploaded By",
        "type": "number",
        "required": false
      },
      {
        "name": "uploadedAt",
        "label": "Uploaded At",
        "type": "date",
        "required": true
      }
    ]
  },
  {
    "key": "systemSettings",
    "label": "System Setting",
    "endpoint": "/api/SystemSettings",
    "module": "Core",
    "isGlobal": false,
    "fields": [
      {
        "name": "settingKey",
        "label": "Setting Key",
        "type": "text",
        "required": true
      },
      {
        "name": "settingValue",
        "label": "Setting Value",
        "type": "text",
        "required": true
      }
    ]
  }
];
