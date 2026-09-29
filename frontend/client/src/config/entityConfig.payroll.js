export const payrollEntities = [
  {
    "key": "employees",
    "label": "Employee",
    "endpoint": "/api/Employees",
    "module": "Payroll",
    "isGlobal": false,
    "fields": [
      {
        "name": "employeeCode",
        "label": "Employee Code",
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
        "name": "departmentId",
        "label": "Department Id",
        "type": "number",
        "required": false
      },
      {
        "name": "joinDate",
        "label": "Join Date",
        "type": "date",
        "required": true
      },
      {
        "name": "bankAccountNumber",
        "label": "Bank Account Number",
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
        "name": "basicSalary",
        "label": "Basic Salary",
        "type": "number",
        "required": true
      },
      {
        "name": "payableAccountId",
        "label": "Payable Account Id",
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
    "key": "salaryComponents",
    "label": "Salary Component",
    "endpoint": "/api/SalaryComponents",
    "module": "Payroll",
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
        "name": "isTaxable",
        "label": "Is Taxable",
        "type": "checkbox",
        "required": true
      },
      {
        "name": "glAccountId",
        "label": "G L Account Id",
        "type": "number",
        "required": true
      }
    ]
  },
  {
    "key": "employeeSalaryStructures",
    "label": "Employee Salary Structure",
    "endpoint": "/api/EmployeeSalaryStructures",
    "module": "Payroll",
    "isGlobal": false,
    "fields": [
      {
        "name": "employeeId",
        "label": "Employee Id",
        "type": "number",
        "required": true
      },
      {
        "name": "componentId",
        "label": "Component Id",
        "type": "number",
        "required": true
      },
      {
        "name": "amount",
        "label": "Amount",
        "type": "number",
        "required": false
      },
      {
        "name": "percentage",
        "label": "Percentage",
        "type": "number",
        "required": false
      },
      {
        "name": "effectiveFrom",
        "label": "Effective From",
        "type": "date",
        "required": true
      }
    ]
  },
  {
    "key": "payrollRuns",
    "label": "Payroll Run",
    "endpoint": "/api/PayrollRuns",
    "module": "Payroll",
    "isGlobal": false,
    "fields": [
      {
        "name": "accountingPeriodId",
        "label": "Accounting Period Id",
        "type": "number",
        "required": true
      },
      {
        "name": "runDate",
        "label": "Run Date",
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
        "name": "journalEntryId",
        "label": "Journal Entry Id",
        "type": "number",
        "required": false
      }
    ]
  },
  {
    "key": "payrollTransactions",
    "label": "Payroll Transaction",
    "endpoint": "/api/PayrollTransactions",
    "module": "Payroll",
    "isGlobal": false,
    "fields": [
      {
        "name": "payrollRunId",
        "label": "Payroll Run Id",
        "type": "number",
        "required": true
      },
      {
        "name": "employeeId",
        "label": "Employee Id",
        "type": "number",
        "required": true
      },
      {
        "name": "componentId",
        "label": "Component Id",
        "type": "number",
        "required": true
      },
      {
        "name": "amount",
        "label": "Amount",
        "type": "number",
        "required": true
      }
    ]
  },
  {
    "key": "employeeLoans",
    "label": "Employee Loan",
    "endpoint": "/api/EmployeeLoans",
    "module": "Payroll",
    "isGlobal": false,
    "fields": [
      {
        "name": "employeeId",
        "label": "Employee Id",
        "type": "number",
        "required": true
      },
      {
        "name": "loanAmount",
        "label": "Loan Amount",
        "type": "number",
        "required": true
      },
      {
        "name": "installmentAmount",
        "label": "Installment Amount",
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
        "name": "outstandingBalance",
        "label": "Outstanding Balance",
        "type": "number",
        "required": true
      }
    ]
  }
];
