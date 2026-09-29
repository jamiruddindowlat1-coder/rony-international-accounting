export const fixedAssetsEntities = [
  {
    "key": "assetCategories",
    "label": "Asset Category",
    "endpoint": "/api/AssetCategories",
    "module": "FixedAssets",
    "isGlobal": false,
    "fields": [
      {
        "name": "name",
        "label": "Name",
        "type": "text",
        "required": true
      },
      {
        "name": "defaultUsefulLifeMonths",
        "label": "Default Useful Life Months",
        "type": "number",
        "required": true
      },
      {
        "name": "defaultDepreciationMethod",
        "label": "Default Depreciation Method",
        "type": "text",
        "required": true
      },
      {
        "name": "assetAccountId",
        "label": "Asset Account Id",
        "type": "number",
        "required": true
      },
      {
        "name": "depreciationExpenseAccountId",
        "label": "Depreciation Expense Account Id",
        "type": "number",
        "required": true
      },
      {
        "name": "accumulatedDepreciationAccountId",
        "label": "Accumulated Depreciation Account Id",
        "type": "number",
        "required": true
      }
    ]
  },
  {
    "key": "fixedAssets",
    "label": "Fixed Asset",
    "endpoint": "/api/FixedAssets",
    "module": "FixedAssets",
    "isGlobal": false,
    "fields": [
      {
        "name": "assetCode",
        "label": "Asset Code",
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
        "name": "categoryId",
        "label": "Category Id",
        "type": "number",
        "required": true
      },
      {
        "name": "purchaseDate",
        "label": "Purchase Date",
        "type": "date",
        "required": true
      },
      {
        "name": "purchaseCost",
        "label": "Purchase Cost",
        "type": "number",
        "required": true
      },
      {
        "name": "salvageValue",
        "label": "Salvage Value",
        "type": "number",
        "required": true
      },
      {
        "name": "usefulLifeMonths",
        "label": "Useful Life Months",
        "type": "number",
        "required": true
      },
      {
        "name": "depreciationMethod",
        "label": "Depreciation Method",
        "type": "text",
        "required": true
      },
      {
        "name": "location",
        "label": "Location",
        "type": "text",
        "required": true
      },
      {
        "name": "custodianEmployeeId",
        "label": "Custodian Employee Id",
        "type": "number",
        "required": false
      },
      {
        "name": "status",
        "label": "Status",
        "type": "text",
        "required": true
      },
      {
        "name": "accumulatedDepreciation",
        "label": "Accumulated Depreciation",
        "type": "number",
        "required": true
      },
      {
        "name": "netBookValue",
        "label": "Net Book Value",
        "type": "number",
        "required": true
      }
    ]
  },
  {
    "key": "depreciationSchedules",
    "label": "Depreciation Schedule",
    "endpoint": "/api/DepreciationSchedules",
    "module": "FixedAssets",
    "isGlobal": false,
    "fields": [
      {
        "name": "assetId",
        "label": "Asset Id",
        "type": "number",
        "required": true
      },
      {
        "name": "periodDate",
        "label": "Period Date",
        "type": "date",
        "required": true
      },
      {
        "name": "depreciationAmount",
        "label": "Depreciation Amount",
        "type": "number",
        "required": true
      },
      {
        "name": "accumulatedDepreciation",
        "label": "Accumulated Depreciation",
        "type": "number",
        "required": true
      },
      {
        "name": "netBookValue",
        "label": "Net Book Value",
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
        "name": "isPosted",
        "label": "Is Posted",
        "type": "checkbox",
        "required": true
      }
    ]
  },
  {
    "key": "assetDisposals",
    "label": "Asset Disposal",
    "endpoint": "/api/AssetDisposals",
    "module": "FixedAssets",
    "isGlobal": false,
    "fields": [
      {
        "name": "assetId",
        "label": "Asset Id",
        "type": "number",
        "required": true
      },
      {
        "name": "disposalDate",
        "label": "Disposal Date",
        "type": "date",
        "required": true
      },
      {
        "name": "disposalProceeds",
        "label": "Disposal Proceeds",
        "type": "number",
        "required": true
      },
      {
        "name": "netBookValueAtDisposal",
        "label": "Net Book Value At Disposal",
        "type": "number",
        "required": true
      },
      {
        "name": "gainLossAmount",
        "label": "Gain Loss Amount",
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
  },
  {
    "key": "assetTransfers",
    "label": "Asset Transfer",
    "endpoint": "/api/AssetTransfers",
    "module": "FixedAssets",
    "isGlobal": false,
    "fields": [
      {
        "name": "assetId",
        "label": "Asset Id",
        "type": "number",
        "required": true
      },
      {
        "name": "fromLocation",
        "label": "From Location",
        "type": "text",
        "required": true
      },
      {
        "name": "toLocation",
        "label": "To Location",
        "type": "text",
        "required": true
      },
      {
        "name": "transferDate",
        "label": "Transfer Date",
        "type": "date",
        "required": true
      },
      {
        "name": "approvedBy",
        "label": "Approved By",
        "type": "number",
        "required": false
      }
    ]
  },
  {
    "key": "assetMaintenanceLogs",
    "label": "Asset Maintenance Log",
    "endpoint": "/api/AssetMaintenanceLogs",
    "module": "FixedAssets",
    "isGlobal": false,
    "fields": [
      {
        "name": "assetId",
        "label": "Asset Id",
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
        "name": "cost",
        "label": "Cost",
        "type": "number",
        "required": true
      },
      {
        "name": "vendorId",
        "label": "Vendor Id",
        "type": "number",
        "required": false
      }
    ]
  }
];
