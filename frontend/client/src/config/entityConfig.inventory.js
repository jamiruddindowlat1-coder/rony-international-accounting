export const inventoryEntities = [
  {
    "key": "itemCategories",
    "label": "Item Category",
    "endpoint": "/api/ItemCategories",
    "module": "Inventory",
    "isGlobal": false,
    "fields": [
      {
        "name": "name",
        "label": "Name",
        "type": "text",
        "required": true
      }
    ]
  },
  {
    "key": "items",
    "label": "Item",
    "endpoint": "/api/Items",
    "module": "Inventory",
    "isGlobal": false,
    "fields": [
      {
        "name": "itemCode",
        "label": "Item Code",
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
        "name": "itemType",
        "label": "Item Type",
        "type": "text",
        "required": true
      },
      {
        "name": "unitOfMeasure",
        "label": "Unit Of Measure",
        "type": "text",
        "required": true
      },
      {
        "name": "categoryId",
        "label": "Category Id",
        "type": "number",
        "required": false
      },
      {
        "name": "salesAccountId",
        "label": "Sales Account Id",
        "type": "number",
        "required": false
      },
      {
        "name": "purchaseAccountId",
        "label": "Purchase Account Id",
        "type": "number",
        "required": false
      },
      {
        "name": "inventoryAssetAccountId",
        "label": "Inventory Asset Account Id",
        "type": "number",
        "required": false
      },
      {
        "name": "costingMethod",
        "label": "Costing Method",
        "type": "text",
        "required": true
      },
      {
        "name": "standardCost",
        "label": "Standard Cost",
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
    "key": "warehouses",
    "label": "Warehouse",
    "endpoint": "/api/Warehouses",
    "module": "Inventory",
    "isGlobal": false,
    "fields": [
      {
        "name": "branchId",
        "label": "Branch Id",
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
        "name": "code",
        "label": "Code",
        "type": "text",
        "required": true
      }
    ]
  },
  {
    "key": "stockLevels",
    "label": "Stock Level",
    "endpoint": "/api/StockLevels",
    "module": "Inventory",
    "isGlobal": false,
    "fields": [
      {
        "name": "itemId",
        "label": "Item Id",
        "type": "number",
        "required": true
      },
      {
        "name": "warehouseId",
        "label": "Warehouse Id",
        "type": "number",
        "required": true
      },
      {
        "name": "quantityOnHand",
        "label": "Quantity On Hand",
        "type": "number",
        "required": true
      },
      {
        "name": "averageCost",
        "label": "Average Cost",
        "type": "number",
        "required": true
      }
    ]
  },
  {
    "key": "stockTransactions",
    "label": "Stock Transaction",
    "endpoint": "/api/StockTransactions",
    "module": "Inventory",
    "isGlobal": false,
    "fields": [
      {
        "name": "itemId",
        "label": "Item Id",
        "type": "number",
        "required": true
      },
      {
        "name": "warehouseId",
        "label": "Warehouse Id",
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
        "name": "transactionType",
        "label": "Transaction Type",
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
        "name": "unitCost",
        "label": "Unit Cost",
        "type": "number",
        "required": true
      },
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
        "required": false
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
    "key": "stockValuationLayers",
    "label": "Stock Valuation Layer",
    "endpoint": "/api/StockValuationLayers",
    "module": "Inventory",
    "isGlobal": false,
    "fields": [
      {
        "name": "itemId",
        "label": "Item Id",
        "type": "number",
        "required": true
      },
      {
        "name": "warehouseId",
        "label": "Warehouse Id",
        "type": "number",
        "required": true
      },
      {
        "name": "receiptDate",
        "label": "Receipt Date",
        "type": "date",
        "required": true
      },
      {
        "name": "quantityRemaining",
        "label": "Quantity Remaining",
        "type": "number",
        "required": true
      },
      {
        "name": "unitCost",
        "label": "Unit Cost",
        "type": "number",
        "required": true
      }
    ]
  }
];
