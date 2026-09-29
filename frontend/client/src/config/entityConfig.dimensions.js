export const dimensionsEntities = [
  {
    "key": "departments",
    "label": "Department",
    "endpoint": "/api/Departments",
    "module": "Dimensions",
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
        "name": "parentDepartmentId",
        "label": "Parent Department Id",
        "type": "number",
        "required": false
      }
    ]
  },
  {
    "key": "costCenters",
    "label": "Cost Center",
    "endpoint": "/api/CostCenters",
    "module": "Dimensions",
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
        "name": "departmentId",
        "label": "Department Id",
        "type": "number",
        "required": false
      }
    ]
  },
  {
    "key": "projects",
    "label": "Project",
    "endpoint": "/api/Projects",
    "module": "Dimensions",
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
        "name": "customerId",
        "label": "Customer Id",
        "type": "number",
        "required": false
      },
      {
        "name": "startDate",
        "label": "Start Date",
        "type": "date",
        "required": false
      },
      {
        "name": "endDate",
        "label": "End Date",
        "type": "date",
        "required": false
      },
      {
        "name": "budgetAmount",
        "label": "Budget Amount",
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
  }
];
