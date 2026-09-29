import { coreEntities } from './entityConfig.core'
import { securityEntities } from './entityConfig.security'
import { accountingEntities } from './entityConfig.accounting'
import { dimensionsEntities } from './entityConfig.dimensions'
import { taxEntities } from './entityConfig.tax'
import { payablesEntities } from './entityConfig.payables'
import { receivablesEntities } from './entityConfig.receivables'
import { bankingEntities } from './entityConfig.banking'
import { fixedAssetsEntities } from './entityConfig.fixedAssets'
import { budgetingEntities } from './entityConfig.budgeting'
import { inventoryEntities } from './entityConfig.inventory'
import { payrollEntities } from './entityConfig.payroll'
import { reportingEntities } from './entityConfig.reporting'
import { notificationsEntities } from './entityConfig.notifications'

const allEntities = [
  ...coreEntities,
  ...securityEntities,
  ...accountingEntities,
  ...dimensionsEntities,
  ...taxEntities,
  ...payablesEntities,
  ...receivablesEntities,
  ...bankingEntities,
  ...fixedAssetsEntities,
  ...budgetingEntities,
  ...inventoryEntities,
  ...payrollEntities,
  ...reportingEntities,
  ...notificationsEntities,
]

// Lookup by key, e.g. entityRegistry['companies']
export const entityRegistry = Object.fromEntries(allEntities.map((e) => [e.key, e]))

// Grouped by module, for the sidebar navigation
export const entityRegistryByModule = allEntities.reduce((acc, e) => {
  acc[e.module] = acc[e.module] || []
  acc[e.module].push(e)
  return acc
}, {})
