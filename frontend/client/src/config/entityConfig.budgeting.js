export const budgetingEntities = [
  {
    "key": "budgetVersions",
    "label": "Budget Version",
    "endpoint": "/api/BudgetVersions",
    "module": "Budgeting",
    "isGlobal": false,
    "fields": [
      {
        "name": "fiscalYearId",
        "label": "Fiscal Year Id",
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
        "name": "status",
        "label": "Status",
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
        "name": "approvedAt",
        "label": "Approved At",
        "type": "date",
        "required": false
      }
    ]
  },
  {
    "key": "budgetLines",
    "label": "Budget Line",
    "endpoint": "/api/BudgetLines",
    "module": "Budgeting",
    "isGlobal": false,
    "fields": [
      {
        "name": "budgetVersionId",
        "label": "Budget Version Id",
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
        "name": "accountingPeriodId",
        "label": "Accounting Period Id",
        "type": "number",
        "required": true
      },
      {
        "name": "budgetedAmount",
        "label": "Budgeted Amount",
        "type": "number",
        "required": true
      }
    ]
  }
];
