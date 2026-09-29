using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using InternationalAccountingSystem.API.Data;
using InternationalAccountingSystem.API.Entities.Accounting;

namespace InternationalAccountingSystem.API
{
    public static class SeedData
    {
        public static void Run(ApplicationDbContext db)
        {
            var accountTypes = new (string Name, string NormalBalance)[]
            {
                ("Asset",     "Debit"),
                ("Liability", "Credit"),
                ("Equity",    "Credit"),
                ("Revenue",   "Credit"),
                ("Expense",   "Debit"),
            };

            foreach (var (name, normalBalance) in accountTypes)
            {
                if (!db.AccountTypes.Any(t => t.Name == name))
                {
                    db.AccountTypes.Add(new AccountType
                    {
                        Name = name,
                        NormalBalance = normalBalance
                    });
                }
            }
            db.SaveChanges();

            long TypeId(string name) => db.AccountTypes.First(t => t.Name == name).Id;

            var assetTypeId = TypeId("Asset");
            var liabilityTypeId = TypeId("Liability");
            var equityTypeId = TypeId("Equity");
            var revenueTypeId = TypeId("Revenue");
            var expenseTypeId = TypeId("Expense");

            var accountGroups = new (string Name, long TypeId, int DisplayOrder)[]
            {
                ("Fixed Assets",         assetTypeId,     1),
                ("Current Assets",       assetTypeId,     2),
                ("Current Liabilities",  liabilityTypeId, 1),
                ("Long-Term Liabilities",liabilityTypeId, 2),
                ("Owner's Equity",       equityTypeId,    1),
                ("Sales Revenue",        revenueTypeId,   1),
                ("Operating Expenses",   expenseTypeId,   1),
                ("Cost of Goods Sold",   expenseTypeId,   2),
            };

            foreach (var (name, typeId, order) in accountGroups)
            {
                if (!db.AccountGroups.Any(g => g.Name == name))
                {
                    db.AccountGroups.Add(new AccountGroup
                    {
                        Name = name,
                        AccountTypeId = typeId,
                        DisplayOrder = order
                    });
                }
            }
            db.SaveChanges();

            long GroupId(string name) => db.AccountGroups.First(g => g.Name == name).Id;

            var coa = new (string Code, string Name, string GroupName, long TypeId, bool IsControl, string ControlFor, bool AllowManual)[]
            {
                ("1000", "Cash in Hand",            "Current Assets", assetTypeId, false, "None", true),
                ("1100", "Bank Account - Primary",  "Current Assets", assetTypeId, false, "None", true),
                ("1200", "Accounts Receivable",     "Current Assets", assetTypeId, true,  "Customer", false),
                ("1300", "Inventory",                "Current Assets", assetTypeId, false, "None", true),
                ("1400", "Prepaid Expenses",         "Current Assets", assetTypeId, false, "None", true),
                ("1500", "Fixed Assets",             "Fixed Assets",   assetTypeId, false, "None", true),
                ("1590", "Accumulated Depreciation", "Fixed Assets",   assetTypeId, false, "None", true),
                ("1600", "Advance Tax / Tax Receivable", "Current Assets", assetTypeId, false, "None", true),
                ("2000", "Bank Loan Payable",        "Long-Term Liabilities", liabilityTypeId, false, "None", true),
                ("2100", "Salary Payable",           "Current Liabilities", liabilityTypeId, false, "None", true),
                ("2200", "Accounts Payable",         "Current Liabilities", liabilityTypeId, true, "Vendor", false),
                ("2300", "Tax Payable / VAT Payable","Current Liabilities", liabilityTypeId, false, "None", true),
                ("2400", "Accrued Expenses",         "Current Liabilities", liabilityTypeId, false, "None", true),
                ("3000", "Owner's Capital",          "Owner's Equity", equityTypeId, false, "None", true),
                ("3100", "Retained Earnings",        "Owner's Equity", equityTypeId, false, "None", true),
                ("3200", "Owner's Drawings",         "Owner's Equity", equityTypeId, false, "None", true),
                ("4000", "Sales Revenue",            "Sales Revenue", revenueTypeId, false, "None", true),
                ("4100", "Service Revenue",          "Sales Revenue", revenueTypeId, false, "None", true),
                ("4900", "Other Income",             "Sales Revenue", revenueTypeId, false, "None", true),
                ("5000", "Cost of Goods Sold",       "Cost of Goods Sold", expenseTypeId, false, "None", true),
                ("5100", "Purchase Expense",         "Operating Expenses", expenseTypeId, false, "None", true),
                ("5200", "Salary Expense",           "Operating Expenses", expenseTypeId, false, "None", true),
                ("5300", "Rent Expense",             "Operating Expenses", expenseTypeId, false, "None", true),
                ("5400", "Utilities Expense",        "Operating Expenses", expenseTypeId, false, "None", true),
                ("5500", "Depreciation Expense",     "Operating Expenses", expenseTypeId, false, "None", true),
                ("5600", "Office Supplies Expense",  "Operating Expenses", expenseTypeId, false, "None", true),
                ("5700", "Bank Charges",             "Operating Expenses", expenseTypeId, false, "None", true),
            };

            foreach (var (code, name, groupName, typeId, isControl, controlFor, allowManual) in coa)
            {
                if (!db.ChartOfAccounts.Any(a => a.AccountCode == code))
                {
                    db.ChartOfAccounts.Add(new ChartOfAccount
                    {
                        AccountCode = code,
                        AccountName = name,
                        ParentAccountId = null,
                        AccountGroupId = GroupId(groupName),
                        AccountTypeId = typeId,
                        CurrencyCode = "BDT",
                        IsControlAccount = isControl,
                        ControlAccountFor = controlFor,
                        AllowManualEntry = allowManual,
                        OpeningBalance = 0m,
                        OpeningBalanceDate = null,
                        IsActive = true
                    });
                }
            }
            db.SaveChanges();
        // User seed
        if (!db.Users.Any(u => u.Email == "admin@example.com"))
        {
            db.Users.Add(new InternationalAccountingSystem.API.Entities.Security.User
            {
                Username = "admin",
                Email = "admin@example.com",
                PasswordHash = "$2a$11$LhQKokESLzBZRqMxup7hveB77YPAhiMzv43D8T6p/08ITRYxfdrG6",
                IsActive = true,
                IsLocked = false,
                IsEmailVerified = true,
                FailedLoginAttempts = 0,
                MustChangePassword = false
            });
            db.SaveChanges();
        }
        else
        {
            var user = db.Users.First(u => u.Email == "admin@example.com");
            user.PasswordHash = "$2a$11$LhQKokESLzBZRqMxup7hveB77YPAhiMzv43D8T6p/08ITRYxfdrG6";
            user.FailedLoginAttempts = 0;
            user.IsActive = true;
            user.IsLocked = false;
            db.SaveChanges();
        }
    }
}}
