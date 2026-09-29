using Microsoft.EntityFrameworkCore;

namespace InternationalAccountingSystem.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<InternationalAccountingSystem.API.Entities.Core.Company> Companies => Set<InternationalAccountingSystem.API.Entities.Core.Company>();
        public DbSet<InternationalAccountingSystem.API.Entities.Core.Branch> Branches => Set<InternationalAccountingSystem.API.Entities.Core.Branch>();
        public DbSet<InternationalAccountingSystem.API.Entities.Core.Country> Countries => Set<InternationalAccountingSystem.API.Entities.Core.Country>();
        public DbSet<InternationalAccountingSystem.API.Entities.Core.Currency> Currencies => Set<InternationalAccountingSystem.API.Entities.Core.Currency>();
        public DbSet<InternationalAccountingSystem.API.Entities.Core.ExchangeRate> ExchangeRates => Set<InternationalAccountingSystem.API.Entities.Core.ExchangeRate>();
        public DbSet<InternationalAccountingSystem.API.Entities.Core.FiscalYear> FiscalYears => Set<InternationalAccountingSystem.API.Entities.Core.FiscalYear>();
        public DbSet<InternationalAccountingSystem.API.Entities.Core.AccountingPeriod> AccountingPeriods => Set<InternationalAccountingSystem.API.Entities.Core.AccountingPeriod>();
        public DbSet<InternationalAccountingSystem.API.Entities.Core.NumberSequence> NumberSequences => Set<InternationalAccountingSystem.API.Entities.Core.NumberSequence>();
        public DbSet<InternationalAccountingSystem.API.Entities.Core.Attachment> Attachments => Set<InternationalAccountingSystem.API.Entities.Core.Attachment>();
        public DbSet<InternationalAccountingSystem.API.Entities.Core.SystemSetting> SystemSettings => Set<InternationalAccountingSystem.API.Entities.Core.SystemSetting>();
        public DbSet<InternationalAccountingSystem.API.Entities.Security.User> Users => Set<InternationalAccountingSystem.API.Entities.Security.User>();
        public DbSet<InternationalAccountingSystem.API.Entities.Security.Role> Roles => Set<InternationalAccountingSystem.API.Entities.Security.Role>();
        public DbSet<InternationalAccountingSystem.API.Entities.Security.Permission> Permissions => Set<InternationalAccountingSystem.API.Entities.Security.Permission>();
        public DbSet<InternationalAccountingSystem.API.Entities.Security.RolePermission> RolePermissions => Set<InternationalAccountingSystem.API.Entities.Security.RolePermission>();
        public DbSet<InternationalAccountingSystem.API.Entities.Security.UserRole> UserRoles => Set<InternationalAccountingSystem.API.Entities.Security.UserRole>();
        public DbSet<InternationalAccountingSystem.API.Entities.Security.UserCompanyAccess> UserCompanyAccesses => Set<InternationalAccountingSystem.API.Entities.Security.UserCompanyAccess>();
        public DbSet<InternationalAccountingSystem.API.Entities.Security.RefreshToken> RefreshTokens => Set<InternationalAccountingSystem.API.Entities.Security.RefreshToken>();
        public DbSet<InternationalAccountingSystem.API.Entities.Security.LoginHistory> LoginHistories => Set<InternationalAccountingSystem.API.Entities.Security.LoginHistory>();
        public DbSet<InternationalAccountingSystem.API.Entities.Security.AuditLog> AuditLogs => Set<InternationalAccountingSystem.API.Entities.Security.AuditLog>();
        public DbSet<InternationalAccountingSystem.API.Entities.Security.ApprovalWorkflow> ApprovalWorkflows => Set<InternationalAccountingSystem.API.Entities.Security.ApprovalWorkflow>();
        public DbSet<InternationalAccountingSystem.API.Entities.Security.ApprovalStep> ApprovalSteps => Set<InternationalAccountingSystem.API.Entities.Security.ApprovalStep>();
        public DbSet<InternationalAccountingSystem.API.Entities.Security.ApprovalRequest> ApprovalRequests => Set<InternationalAccountingSystem.API.Entities.Security.ApprovalRequest>();
        public DbSet<InternationalAccountingSystem.API.Entities.Security.ApprovalAction> ApprovalActions => Set<InternationalAccountingSystem.API.Entities.Security.ApprovalAction>();
        public DbSet<InternationalAccountingSystem.API.Entities.Accounting.AccountType> AccountTypes => Set<InternationalAccountingSystem.API.Entities.Accounting.AccountType>();
        public DbSet<InternationalAccountingSystem.API.Entities.Accounting.AccountGroup> AccountGroups => Set<InternationalAccountingSystem.API.Entities.Accounting.AccountGroup>();
        public DbSet<InternationalAccountingSystem.API.Entities.Accounting.ChartOfAccount> ChartOfAccounts => Set<InternationalAccountingSystem.API.Entities.Accounting.ChartOfAccount>();
        public DbSet<InternationalAccountingSystem.API.Entities.Accounting.JournalEntry> JournalEntries => Set<InternationalAccountingSystem.API.Entities.Accounting.JournalEntry>();
        public DbSet<InternationalAccountingSystem.API.Entities.Accounting.JournalEntryLine> JournalEntryLines => Set<InternationalAccountingSystem.API.Entities.Accounting.JournalEntryLine>();
        public DbSet<InternationalAccountingSystem.API.Entities.Accounting.RecurringJournalTemplate> RecurringJournalTemplates => Set<InternationalAccountingSystem.API.Entities.Accounting.RecurringJournalTemplate>();
        public DbSet<InternationalAccountingSystem.API.Entities.Dimensions.Department> Departments => Set<InternationalAccountingSystem.API.Entities.Dimensions.Department>();
        public DbSet<InternationalAccountingSystem.API.Entities.Dimensions.CostCenter> CostCenters => Set<InternationalAccountingSystem.API.Entities.Dimensions.CostCenter>();
        public DbSet<InternationalAccountingSystem.API.Entities.Dimensions.Project> Projects => Set<InternationalAccountingSystem.API.Entities.Dimensions.Project>();
        public DbSet<InternationalAccountingSystem.API.Entities.Tax.TaxJurisdiction> TaxJurisdictions => Set<InternationalAccountingSystem.API.Entities.Tax.TaxJurisdiction>();
        public DbSet<InternationalAccountingSystem.API.Entities.Tax.TaxType> TaxTypes => Set<InternationalAccountingSystem.API.Entities.Tax.TaxType>();
        public DbSet<InternationalAccountingSystem.API.Entities.Tax.TaxCode> TaxCodes => Set<InternationalAccountingSystem.API.Entities.Tax.TaxCode>();
        public DbSet<InternationalAccountingSystem.API.Entities.Tax.TaxTransaction> TaxTransactions => Set<InternationalAccountingSystem.API.Entities.Tax.TaxTransaction>();
        public DbSet<InternationalAccountingSystem.API.Entities.Payables.Vendor> Vendors => Set<InternationalAccountingSystem.API.Entities.Payables.Vendor>();
        public DbSet<InternationalAccountingSystem.API.Entities.Payables.VendorContact> VendorContacts => Set<InternationalAccountingSystem.API.Entities.Payables.VendorContact>();
        public DbSet<InternationalAccountingSystem.API.Entities.Payables.VendorBankAccount> VendorBankAccounts => Set<InternationalAccountingSystem.API.Entities.Payables.VendorBankAccount>();
        public DbSet<InternationalAccountingSystem.API.Entities.Payables.PurchaseOrder> PurchaseOrders => Set<InternationalAccountingSystem.API.Entities.Payables.PurchaseOrder>();
        public DbSet<InternationalAccountingSystem.API.Entities.Payables.PurchaseOrderLine> PurchaseOrderLines => Set<InternationalAccountingSystem.API.Entities.Payables.PurchaseOrderLine>();
        public DbSet<InternationalAccountingSystem.API.Entities.Payables.PurchaseInvoice> PurchaseInvoices => Set<InternationalAccountingSystem.API.Entities.Payables.PurchaseInvoice>();
        public DbSet<InternationalAccountingSystem.API.Entities.Payables.PurchaseInvoiceLine> PurchaseInvoiceLines => Set<InternationalAccountingSystem.API.Entities.Payables.PurchaseInvoiceLine>();
        public DbSet<InternationalAccountingSystem.API.Entities.Payables.VendorPayment> VendorPayments => Set<InternationalAccountingSystem.API.Entities.Payables.VendorPayment>();
        public DbSet<InternationalAccountingSystem.API.Entities.Payables.VendorPaymentAllocation> VendorPaymentAllocations => Set<InternationalAccountingSystem.API.Entities.Payables.VendorPaymentAllocation>();
        public DbSet<InternationalAccountingSystem.API.Entities.Payables.VendorCreditNote> VendorCreditNotes => Set<InternationalAccountingSystem.API.Entities.Payables.VendorCreditNote>();
        public DbSet<InternationalAccountingSystem.API.Entities.Payables.WithholdingTaxEntry> WithholdingTaxEntries => Set<InternationalAccountingSystem.API.Entities.Payables.WithholdingTaxEntry>();
        public DbSet<InternationalAccountingSystem.API.Entities.Receivables.Customer> Customers => Set<InternationalAccountingSystem.API.Entities.Receivables.Customer>();
        public DbSet<InternationalAccountingSystem.API.Entities.Receivables.CustomerContact> CustomerContacts => Set<InternationalAccountingSystem.API.Entities.Receivables.CustomerContact>();
        public DbSet<InternationalAccountingSystem.API.Entities.Receivables.CustomerBankAccount> CustomerBankAccounts => Set<InternationalAccountingSystem.API.Entities.Receivables.CustomerBankAccount>();
        public DbSet<InternationalAccountingSystem.API.Entities.Receivables.SalesOrder> SalesOrders => Set<InternationalAccountingSystem.API.Entities.Receivables.SalesOrder>();
        public DbSet<InternationalAccountingSystem.API.Entities.Receivables.SalesOrderLine> SalesOrderLines => Set<InternationalAccountingSystem.API.Entities.Receivables.SalesOrderLine>();
        public DbSet<InternationalAccountingSystem.API.Entities.Receivables.SalesInvoice> SalesInvoices => Set<InternationalAccountingSystem.API.Entities.Receivables.SalesInvoice>();
        public DbSet<InternationalAccountingSystem.API.Entities.Receivables.SalesInvoiceLine> SalesInvoiceLines => Set<InternationalAccountingSystem.API.Entities.Receivables.SalesInvoiceLine>();
        public DbSet<InternationalAccountingSystem.API.Entities.Receivables.CustomerReceipt> CustomerReceipts => Set<InternationalAccountingSystem.API.Entities.Receivables.CustomerReceipt>();
        public DbSet<InternationalAccountingSystem.API.Entities.Receivables.CustomerReceiptAllocation> CustomerReceiptAllocations => Set<InternationalAccountingSystem.API.Entities.Receivables.CustomerReceiptAllocation>();
        public DbSet<InternationalAccountingSystem.API.Entities.Receivables.CustomerCreditNote> CustomerCreditNotes => Set<InternationalAccountingSystem.API.Entities.Receivables.CustomerCreditNote>();
        public DbSet<InternationalAccountingSystem.API.Entities.Receivables.BadDebtWriteOff> BadDebtWriteOffs => Set<InternationalAccountingSystem.API.Entities.Receivables.BadDebtWriteOff>();
        public DbSet<InternationalAccountingSystem.API.Entities.Banking.BankAccount> BankAccounts => Set<InternationalAccountingSystem.API.Entities.Banking.BankAccount>();
        public DbSet<InternationalAccountingSystem.API.Entities.Banking.BankTransaction> BankTransactions => Set<InternationalAccountingSystem.API.Entities.Banking.BankTransaction>();
        public DbSet<InternationalAccountingSystem.API.Entities.Banking.BankStatementImport> BankStatementImports => Set<InternationalAccountingSystem.API.Entities.Banking.BankStatementImport>();
        public DbSet<InternationalAccountingSystem.API.Entities.Banking.BankReconciliation> BankReconciliations => Set<InternationalAccountingSystem.API.Entities.Banking.BankReconciliation>();
        public DbSet<InternationalAccountingSystem.API.Entities.Banking.ChequeRegisterEntry> ChequeRegisterEntries => Set<InternationalAccountingSystem.API.Entities.Banking.ChequeRegisterEntry>();
        public DbSet<InternationalAccountingSystem.API.Entities.Banking.PettyCashAccount> PettyCashAccounts => Set<InternationalAccountingSystem.API.Entities.Banking.PettyCashAccount>();
        public DbSet<InternationalAccountingSystem.API.Entities.Banking.PettyCashTransaction> PettyCashTransactions => Set<InternationalAccountingSystem.API.Entities.Banking.PettyCashTransaction>();
        public DbSet<InternationalAccountingSystem.API.Entities.FixedAssets.AssetCategory> AssetCategories => Set<InternationalAccountingSystem.API.Entities.FixedAssets.AssetCategory>();
        public DbSet<InternationalAccountingSystem.API.Entities.FixedAssets.FixedAsset> FixedAssets => Set<InternationalAccountingSystem.API.Entities.FixedAssets.FixedAsset>();
        public DbSet<InternationalAccountingSystem.API.Entities.FixedAssets.DepreciationSchedule> DepreciationSchedules => Set<InternationalAccountingSystem.API.Entities.FixedAssets.DepreciationSchedule>();
        public DbSet<InternationalAccountingSystem.API.Entities.FixedAssets.AssetDisposal> AssetDisposals => Set<InternationalAccountingSystem.API.Entities.FixedAssets.AssetDisposal>();
        public DbSet<InternationalAccountingSystem.API.Entities.FixedAssets.AssetTransfer> AssetTransfers => Set<InternationalAccountingSystem.API.Entities.FixedAssets.AssetTransfer>();
        public DbSet<InternationalAccountingSystem.API.Entities.FixedAssets.AssetMaintenanceLog> AssetMaintenanceLogs => Set<InternationalAccountingSystem.API.Entities.FixedAssets.AssetMaintenanceLog>();
        public DbSet<InternationalAccountingSystem.API.Entities.Budgeting.BudgetVersion> BudgetVersions => Set<InternationalAccountingSystem.API.Entities.Budgeting.BudgetVersion>();
        public DbSet<InternationalAccountingSystem.API.Entities.Budgeting.BudgetLine> BudgetLines => Set<InternationalAccountingSystem.API.Entities.Budgeting.BudgetLine>();
        public DbSet<InternationalAccountingSystem.API.Entities.Inventory.ItemCategory> ItemCategories => Set<InternationalAccountingSystem.API.Entities.Inventory.ItemCategory>();
        public DbSet<InternationalAccountingSystem.API.Entities.Inventory.Item> Items => Set<InternationalAccountingSystem.API.Entities.Inventory.Item>();
        public DbSet<InternationalAccountingSystem.API.Entities.Inventory.Warehouse> Warehouses => Set<InternationalAccountingSystem.API.Entities.Inventory.Warehouse>();
        public DbSet<InternationalAccountingSystem.API.Entities.Inventory.StockLevel> StockLevels => Set<InternationalAccountingSystem.API.Entities.Inventory.StockLevel>();
        public DbSet<InternationalAccountingSystem.API.Entities.Inventory.StockTransaction> StockTransactions => Set<InternationalAccountingSystem.API.Entities.Inventory.StockTransaction>();
        public DbSet<InternationalAccountingSystem.API.Entities.Inventory.StockValuationLayer> StockValuationLayers => Set<InternationalAccountingSystem.API.Entities.Inventory.StockValuationLayer>();
        public DbSet<InternationalAccountingSystem.API.Entities.Payroll.Employee> Employees => Set<InternationalAccountingSystem.API.Entities.Payroll.Employee>();
        public DbSet<InternationalAccountingSystem.API.Entities.Payroll.SalaryComponent> SalaryComponents => Set<InternationalAccountingSystem.API.Entities.Payroll.SalaryComponent>();
        public DbSet<InternationalAccountingSystem.API.Entities.Payroll.EmployeeSalaryStructure> EmployeeSalaryStructures => Set<InternationalAccountingSystem.API.Entities.Payroll.EmployeeSalaryStructure>();
        public DbSet<InternationalAccountingSystem.API.Entities.Payroll.PayrollRun> PayrollRuns => Set<InternationalAccountingSystem.API.Entities.Payroll.PayrollRun>();
        public DbSet<InternationalAccountingSystem.API.Entities.Payroll.PayrollTransaction> PayrollTransactions => Set<InternationalAccountingSystem.API.Entities.Payroll.PayrollTransaction>();
        public DbSet<InternationalAccountingSystem.API.Entities.Payroll.EmployeeLoan> EmployeeLoans => Set<InternationalAccountingSystem.API.Entities.Payroll.EmployeeLoan>();
        public DbSet<InternationalAccountingSystem.API.Entities.Reporting.FinancialStatementTemplate> FinancialStatementTemplates => Set<InternationalAccountingSystem.API.Entities.Reporting.FinancialStatementTemplate>();
        public DbSet<InternationalAccountingSystem.API.Entities.Reporting.FinancialStatementLine> FinancialStatementLines => Set<InternationalAccountingSystem.API.Entities.Reporting.FinancialStatementLine>();
        public DbSet<InternationalAccountingSystem.API.Entities.Reporting.FinancialStatementLineAccount> FinancialStatementLineAccounts => Set<InternationalAccountingSystem.API.Entities.Reporting.FinancialStatementLineAccount>();
        public DbSet<InternationalAccountingSystem.API.Entities.Reporting.ConsolidationMapping> ConsolidationMappings => Set<InternationalAccountingSystem.API.Entities.Reporting.ConsolidationMapping>();
        public DbSet<InternationalAccountingSystem.API.Entities.Notifications.Notification> Notifications => Set<InternationalAccountingSystem.API.Entities.Notifications.Notification>();
        public DbSet<InternationalAccountingSystem.API.Entities.Notifications.EmailQueueItem> EmailQueueItems => Set<InternationalAccountingSystem.API.Entities.Notifications.EmailQueueItem>();
        public DbSet<InternationalAccountingSystem.API.Entities.Notifications.SmsQueueItem> SmsQueueItems => Set<InternationalAccountingSystem.API.Entities.Notifications.SmsQueueItem>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Store every decimal column as decimal(18,4) unless overridden per-entity below.
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                foreach (var property in entityType.GetProperties())
                {
                    if (property.ClrType == typeof(decimal) || property.ClrType == typeof(decimal?))
                    {
                        property.SetColumnType("decimal(18,4)");
                    }
                }
            }

            // TODO: add HasIndex()/IsUnique(), HasOne()/WithMany() relationships,
            // and any global query filter for multi-tenancy (CompanyId) here as you build each module.
        }
    }
}
