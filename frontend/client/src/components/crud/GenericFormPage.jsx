import React, { useEffect, useState } from 'react'
import { useNavigate, useParams } from 'react-router-dom'
import { createCrudApi } from '../../api/genericApi'
import { entityRegistry } from '../../config/entityRegistry'

// ---------- Foreign-key mapping: which field points at which entity ----------
const FK_MAP = {
  branchId: { ref: 'branches', valueField: 'id' },
  countryCode: { ref: 'countries', valueField: 'code' },
  currencyCode: { ref: 'currencies', valueField: 'code' },
  baseCurrencyCode: { ref: 'currencies', valueField: 'code' },
  defaultCurrencyCode: { ref: 'currencies', valueField: 'code' },
  fromCurrencyCode: { ref: 'currencies', valueField: 'code' },
  toCurrencyCode: { ref: 'currencies', valueField: 'code' },
  fiscalYearId: { ref: 'fiscalYears', valueField: 'id' },
  accountingPeriodId: { ref: 'accountingPeriods', valueField: 'id' },
  accountId: { ref: 'chartOfAccounts', valueField: 'id' },
  parentAccountId: { ref: 'chartOfAccounts', valueField: 'id' },
  accountGroupId: { ref: 'accountGroups', valueField: 'id' },
  parentGroupId: { ref: 'accountGroups', valueField: 'id' },
  accountTypeId: { ref: 'accountTypes', valueField: 'id' },
  glAccountId: { ref: 'chartOfAccounts', valueField: 'id' },
  payableAccountId: { ref: 'chartOfAccounts', valueField: 'id' },
  receivableAccountId: { ref: 'chartOfAccounts', valueField: 'id' },
  assetAccountId: { ref: 'chartOfAccounts', valueField: 'id' },
  depreciationExpenseAccountId: { ref: 'chartOfAccounts', valueField: 'id' },
  accumulatedDepreciationAccountId: { ref: 'chartOfAccounts', valueField: 'id' },
  controlAccountId: { ref: 'chartOfAccounts', valueField: 'id' },
  defaultExpenseAccountId: { ref: 'chartOfAccounts', valueField: 'id' },
  salesAccountId: { ref: 'chartOfAccounts', valueField: 'id' },
  purchaseAccountId: { ref: 'chartOfAccounts', valueField: 'id' },
  inventoryAssetAccountId: { ref: 'chartOfAccounts', valueField: 'id' },
  eliminationAccountId: { ref: 'chartOfAccounts', valueField: 'id' },
  costCenterId: { ref: 'costCenters', valueField: 'id' },
  projectId: { ref: 'projects', valueField: 'id' },
  departmentId: { ref: 'departments', valueField: 'id' },
  parentDepartmentId: { ref: 'departments', valueField: 'id' },
  taxCodeId: { ref: 'taxCodes', valueField: 'id' },
  taxTypeId: { ref: 'taxTypes', valueField: 'id' },
  jurisdictionId: { ref: 'taxJurisdictions', valueField: 'id' },
  vendorId: { ref: 'vendors', valueField: 'id' },
  customerId: { ref: 'customers', valueField: 'id' },
  employeeId: { ref: 'employees', valueField: 'id' },
  componentId: { ref: 'salaryComponents', valueField: 'id' },
  payrollRunId: { ref: 'payrollRuns', valueField: 'id' },
  itemId: { ref: 'items', valueField: 'id' },
  warehouseId: { ref: 'warehouses', valueField: 'id' },
  bankAccountId: { ref: 'bankAccounts', valueField: 'id' },
  journalEntryId: { ref: 'journalEntries', valueField: 'id' },
  reversalOfEntryId: { ref: 'journalEntries', valueField: 'id' },
  purchaseOrderId: { ref: 'purchaseOrders', valueField: 'id' },
  salesOrderId: { ref: 'salesOrders', valueField: 'id' },
  userId: { ref: 'users', valueField: 'id' },
  postedBy: { ref: 'users', valueField: 'id' },
  uploadedBy: { ref: 'users', valueField: 'id' },
  approvedBy: { ref: 'users', valueField: 'id' },
  requestedBy: { ref: 'users', valueField: 'id' },
  actionBy: { ref: 'users', valueField: 'id' },
  custodianUserId: { ref: 'users', valueField: 'id' },
  reconciledBy: { ref: 'users', valueField: 'id' },
  custodianEmployeeId: { ref: 'employees', valueField: 'id' },
  roleId: { ref: 'roles', valueField: 'id' },
  approverRoleId: { ref: 'roles', valueField: 'id' },
  permissionId: { ref: 'permissions', valueField: 'id' },
  workflowId: { ref: 'approvalWorkflows', valueField: 'id' },
  paymentId: { ref: 'vendorPayments', valueField: 'id' },
  receiptId: { ref: 'customerReceipts', valueField: 'id' },
  assetId: { ref: 'fixedAssets', valueField: 'id' },
  linkedPaymentId: { ref: 'vendorPayments', valueField: 'id' },
  linkedReceiptId: { ref: 'customerReceipts', valueField: 'id' },
  pettyCashAccountId: { ref: 'pettyCashAccounts', valueField: 'id' },
  templateId: { ref: 'financialStatementTemplates', valueField: 'id' },
  statementLineId: { ref: 'financialStatementLines', valueField: 'id' },
  parentLineId: { ref: 'financialStatementLines', valueField: 'id' },
  subsidiaryCompanyId: { ref: 'companies', valueField: 'id' },
  parentCompanyId: { ref: 'companies', valueField: 'id' },
}

// Same field name, different meaning depending on which entity's form it is.
const FK_MAP_BY_ENTITY = {
  items: { categoryId: { ref: 'itemCategories', valueField: 'id' } },
  fixedAssets: { categoryId: { ref: 'assetCategories', valueField: 'id' } },
  purchaseInvoiceLines: { invoiceId: { ref: 'purchaseInvoices', valueField: 'id' } },
  vendorPaymentAllocations: { invoiceId: { ref: 'purchaseInvoices', valueField: 'id' } },
  salesInvoiceLines: { invoiceId: { ref: 'salesInvoices', valueField: 'id' } },
  customerReceiptAllocations: { invoiceId: { ref: 'salesInvoices', valueField: 'id' } },
  badDebtWriteOffs: { invoiceId: { ref: 'salesInvoices', valueField: 'id' } },
}

function resolveFkRef(entityKey, fieldName) {
  return (FK_MAP_BY_ENTITY[entityKey] && FK_MAP_BY_ENTITY[entityKey][fieldName]) || FK_MAP[fieldName] || null
}

// ---------- Realistic sample data (Bangladesh context) ----------
const SAMPLE_NAMES = ['Rahim Uddin', 'Karim Hossain', 'Fatema Begum', 'Nasrin Akter', 'Jamal Khan', 'Salma Islam']
const SAMPLE_COMPANY_NAMES = ['Rony International Trading', 'Ainan Auto Parts Ltd', 'Safiyan Enterprise', 'Delta Corporation', 'Meghna Textiles Ltd', 'Padma Distribution Co']
const SAMPLE_ADDRESSES = [
  'House 12, Road 5, Gulshan-1, Dhaka-1212',
  'Flat 4B, Agrabad Commercial Area, Chattogram',
  '221 Zindabazar, Sylhet',
  'Plot 45, Khulshi, Chattogram',
  'House 9, Dhanmondi Road 27, Dhaka'
]
const SAMPLE_CITIES = ['Dhaka', 'Chattogram', 'Sylhet', 'Khulna', 'Rajshahi', 'Barishal']
const SAMPLE_BANKS = ['Islami Bank Bangladesh', 'Dutch-Bangla Bank', 'BRAC Bank', 'City Bank', 'Sonali Bank', 'Eastern Bank']
const SAMPLE_STATUSES = ['Active', 'Pending', 'Draft', 'Approved']
const SAMPLE_REASONS = ['Damaged goods', 'Price adjustment', 'Return by customer', 'Billing correction']
const SAMPLE_DESCRIPTIONS = ['Office supplies purchase', 'Monthly service charge', 'Raw material procurement', 'Consulting fee']

function pick(arr) {
  return arr[Math.floor(Math.random() * arr.length)]
}

function randomDigits(n) {
  let s = ''
  for (let i = 0; i < n; i++) s += Math.floor(Math.random() * 10)
  return s
}

function generateSampleValue(field) {
  const n = field.name.toLowerCase()

  switch (field.type) {
    case 'checkbox':
      return true
    case 'select':
      if (Array.isArray(field.options) && field.options.length > 0) {
        return pick(field.options.map((o) => o.value))
      }
      return ''
    case 'number':
      if (/amount|price|cost|balance|salary|limit|value|total/.test(n)) {
        return Math.floor(Math.random() * 90000) + 1000
      }
      if (/percentage|rate/.test(n)) {
        return Math.floor(Math.random() * 30) + 1
      }
      return Math.floor(Math.random() * 20) + 1
    case 'date':
      return new Date().toISOString().slice(0, 10)
    case 'datetime-local':
      return new Date().toISOString().slice(0, 16)
    case 'email':
      return `contact${randomDigits(3)}@example.com`
    case 'tel':
      return `01${randomDigits(9)}`
    default:
      if (/legalname|companyname/.test(n)) return pick(SAMPLE_COMPANY_NAMES)
      if (n === 'name' || /vendorname|customername|contactname/.test(n)) {
        return field.label && /contact|employee|user|custodian/i.test(field.label)
          ? pick(SAMPLE_NAMES)
          : pick(SAMPLE_COMPANY_NAMES)
      }
      if (/email/.test(n)) return `contact${randomDigits(3)}@example.com`
      if (/phone|mobile/.test(n)) return `01${randomDigits(9)}`
      if (/address/.test(n)) return pick(SAMPLE_ADDRESSES)
      if (/city|region/.test(n)) return pick(SAMPLE_CITIES)
      if (/bankname/.test(n)) return pick(SAMPLE_BANKS)
      if (/accountnumber/.test(n)) return randomDigits(12)
      if (/iban/.test(n)) return `BD${randomDigits(20)}`
      if (/swift/.test(n)) return `DBBLBDDH${randomDigits(3)}`
      if (/code$/.test(n) && /country/.test(n)) return 'BD'
      if (/code$/.test(n) && /currency/.test(n)) return 'BDT'
      if (/code$/.test(n)) return `CD${randomDigits(4)}`
      if (/reference|voucher|invoicenumber|receiptnumber|paymentnumber|certificatenumber|ponumber|sonumber|creditnotenumber/.test(n)) {
        return `REF-${randomDigits(6)}`
      }
      if (/status$/.test(n)) return pick(SAMPLE_STATUSES)
      if (/reason/.test(n)) return pick(SAMPLE_REASONS)
      if (/description|narration/.test(n)) return pick(SAMPLE_DESCRIPTIONS)
      if (/designation/.test(n)) return 'Manager'
      if (/logopath|filepath|filename/.test(n)) return 'sample-file.png'
      return `Sample ${field.label}`
  }
}

// ---------- Component ----------
export default function GenericFormPage() {
  const { entityKey, id } = useParams()
  const navigate = useNavigate()
  const config = entityRegistry[entityKey]
  const [values, setValues] = useState({})
  const [loading, setLoading] = useState(false)
  const [autoFilling, setAutoFilling] = useState(false)
  const isEdit = !!id

  useEffect(() => {
    if (!config) return
    if (isEdit) {
      setLoading(true)
      createCrudApi(config.endpoint).getById(id)
        .then(setValues)
        .finally(() => setLoading(false))
    } else {
      setValues({})
    }
  }, [entityKey, id])

  if (!config) return <p>Unknown entity: {entityKey}</p>

  function handleChange(field, raw) {
    let value = raw
    if (field.type === 'checkbox') value = raw
    if (field.type === 'number') value = raw === '' ? '' : Number(raw)
    setValues((prev) => ({ ...prev, [field.name]: value }))
  }

  async function handleAutoFill() {
    setAutoFilling(true)
    try {
      const listCache = {}
      const filled = {}

      for (const field of config.fields) {
        const fk = resolveFkRef(entityKey, field.name)

        if (fk && entityRegistry[fk.ref]) {
          try {
            if (!listCache[fk.ref]) {
              listCache[fk.ref] = await createCrudApi(entityRegistry[fk.ref].endpoint).getAll()
            }
            const list = listCache[fk.ref] || []
            if (list.length > 0) {
              const pickRecord = list[Math.floor(Math.random() * list.length)]
              filled[field.name] = pickRecord[fk.valueField]
              continue
            }
          } catch (err) {
            console.error(`Auto Fill: failed to load ${fk.ref} for ${field.name}`, err)
          }
        }

        filled[field.name] = generateSampleValue(field)
      }

      setValues((prev) => ({ ...prev, ...filled }))
    } finally {
      setAutoFilling(false)
    }
  }

  async function handleSubmit(e) {
    e.preventDefault()
    const api = createCrudApi(config.endpoint)
    setLoading(true)
    try {
      if (isEdit) {
        await api.update(id, values)
      } else {
        await api.create(values)
      }
      navigate(`/app/${entityKey}`)
    } catch (err) {
      console.error(err)
      alert("Failed to save record.")
      setLoading(false)
    }
  }

  return (
    <div>
      <div className="page-header">
        <h1>{isEdit ? `Edit ${config.label}` : `New ${config.label}`}</h1>
      </div>

      <div className="form-container">
        {loading && isEdit ? (
          <div className="loading-spinner">
            <div className="spinner"></div>
            <span>Loading record data...</span>
          </div>
        ) : (
          <form onSubmit={handleSubmit}>
            <div className="form-grid">
              {config.fields.map((field) => (
                <div className="form-field" key={field.name}>
                  <label>{field.label}{field.required ? ' *' : ''}</label>
                  {field.type === 'checkbox' ? (
                    <input
                      type="checkbox"
                      checked={!!values[field.name]}
                      onChange={(e) => handleChange(field, e.target.checked)}
                    />
                  ) : field.type === 'select' ? (
                    <select
                      required={field.required}
                      value={values[field.name] ?? ''}
                      onChange={(e) => handleChange(field, e.target.value)}
                    >
                      <option value="">-- Select {field.label} --</option>
                      {(field.options || []).map((opt) => (
                        <option key={opt.value} value={opt.value}>
                          {opt.label}
                        </option>
                      ))}
                    </select>
                  ) : (
                    <input
                      type={field.type}
                      required={field.required}
                      value={values[field.name] ?? ''}
                      onChange={(e) => handleChange(field, e.target.value)}
                      placeholder={`Enter ${field.label.toLowerCase()}...`}
                    />
                  )}
                </div>
              ))}
            </div>

            <div className="form-actions">
              <button className="btn btn-primary" type="submit" disabled={loading || autoFilling}>
                {loading ? 'Saving...' : 'Save Record'}
              </button>
              <button className="btn btn-secondary" type="button" onClick={handleAutoFill} disabled={loading || autoFilling}>
                {autoFilling ? 'Auto Filling...' : 'Auto Fill'}
              </button>
              <button className="btn btn-secondary" type="button" onClick={() => navigate(-1)} disabled={loading || autoFilling}>
                Cancel
              </button>
            </div>
          </form>
        )}
      </div>
    </div>
  )
}
