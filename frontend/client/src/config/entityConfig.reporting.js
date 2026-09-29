export const reportingEntities = [
  {
    "key": "financialStatementTemplates",
    "label": "Financial Statement Template",
    "endpoint": "/api/FinancialStatementTemplates",
    "module": "Reporting",
    "isGlobal": false,
    "fields": [
      {
        "name": "name",
        "label": "Name",
        "type": "text",
        "required": true
      },
      {
        "name": "type",
        "label": "Type",
        "type": "text",
        "required": true
      },
      {
        "name": "isDefault",
        "label": "Is Default",
        "type": "checkbox",
        "required": true
      }
    ]
  },
  {
    "key": "financialStatementLines",
    "label": "Financial Statement Line",
    "endpoint": "/api/FinancialStatementLines",
    "module": "Reporting",
    "isGlobal": false,
    "fields": [
      {
        "name": "templateId",
        "label": "Template Id",
        "type": "number",
        "required": true
      },
      {
        "name": "parentLineId",
        "label": "Parent Line Id",
        "type": "number",
        "required": false
      },
      {
        "name": "lineLabel",
        "label": "Line Label",
        "type": "text",
        "required": true
      },
      {
        "name": "lineOrder",
        "label": "Line Order",
        "type": "number",
        "required": true
      },
      {
        "name": "lineType",
        "label": "Line Type",
        "type": "text",
        "required": true
      },
      {
        "name": "formula",
        "label": "Formula",
        "type": "text",
        "required": true
      }
    ]
  },
  {
    "key": "financialStatementLineAccounts",
    "label": "Financial Statement Line Account",
    "endpoint": "/api/FinancialStatementLineAccounts",
    "module": "Reporting",
    "isGlobal": false,
    "fields": [
      {
        "name": "statementLineId",
        "label": "Statement Line Id",
        "type": "number",
        "required": true
      },
      {
        "name": "accountId",
        "label": "Account Id",
        "type": "number",
        "required": false
      },
      {
        "name": "accountGroupId",
        "label": "Account Group Id",
        "type": "number",
        "required": false
      },
      {
        "name": "signMultiplier",
        "label": "Sign Multiplier",
        "type": "number",
        "required": true
      }
    ]
  },
  {
    "key": "consolidationMappings",
    "label": "Consolidation Mapping",
    "endpoint": "/api/ConsolidationMappings",
    "module": "Reporting",
    "isGlobal": false,
    "fields": [
      {
        "name": "subsidiaryCompanyId",
        "label": "Subsidiary Company Id",
        "type": "number",
        "required": true
      },
      {
        "name": "parentCompanyId",
        "label": "Parent Company Id",
        "type": "number",
        "required": true
      },
      {
        "name": "ownershipPercentage",
        "label": "Ownership Percentage",
        "type": "number",
        "required": true
      },
      {
        "name": "eliminationAccountId",
        "label": "Elimination Account Id",
        "type": "number",
        "required": false
      }
    ]
  }
];
