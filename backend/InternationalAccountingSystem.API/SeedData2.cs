using System;
using System.Linq;
using InternationalAccountingSystem.API.Data;
using InternationalAccountingSystem.API.Entities.Inventory;
using InternationalAccountingSystem.API.Entities.Receivables;
using InternationalAccountingSystem.API.Entities.Payables;

namespace InternationalAccountingSystem.API
{
    public static class SeedData2
    {
        public static void Run(ApplicationDbContext db)
        {
            const long branchId = 1;
            const long customerId = 1;
            const long vendorId = 1;
            const long salesRevenueAccountId = 7;
            const long purchaseExpenseAccountId = 6;
            const long inventoryAccountId = 10;

            var categories = new[] { "Raw Materials", "Finished Goods", "Services" };
            foreach (var name in categories)
            {
                if (!db.ItemCategories.Any(c => c.Name == name))
                    db.ItemCategories.Add(new ItemCategory { Name = name });
            }
            db.SaveChanges();

            long CategoryId(string name) => db.ItemCategories.First(c => c.Name == name).Id;

            var items = new (string Code, string Name, string Type, string Uom, string CategoryName, decimal StandardCost)[]
            {
                ("ITEM-001", "Steel Rod 10mm",       "Goods",   "Kg",  "Raw Materials",  85.00m),
                ("ITEM-002", "Cement Bag 50kg",      "Goods",   "Bag", "Raw Materials",  520.00m),
                ("ITEM-003", "Finished Auto Part A", "Goods",   "Pcs", "Finished Goods", 1200.00m),
                ("ITEM-004", "Consulting Service",   "Service", "Hour","Services",       0m),
            };

            foreach (var (code, name, type, uom, categoryName, cost) in items)
            {
                if (!db.Items.Any(i => i.ItemCode == code))
                {
                    db.Items.Add(new Item
                    {
                        ItemCode = code,
                        Name = name,
                        ItemType = type,
                        UnitOfMeasure = uom,
                        CategoryId = CategoryId(categoryName),
                        SalesAccountId = salesRevenueAccountId,
                        PurchaseAccountId = purchaseExpenseAccountId,
                        InventoryAssetAccountId = type == "Goods" ? inventoryAccountId : (long?)null,
                        CostingMethod = "FIFO",
                        StandardCost = cost,
                        IsActive = true
                    });
                }
            }
            db.SaveChanges();

            if (!db.SalesInvoices.Any(s => s.InvoiceNumber == "INV-2026-0001" && !s.IsDeleted))
            {
                db.SalesInvoices.Add(new SalesInvoice
                {
                    BranchId = branchId, CustomerId = customerId, SalesOrderId = null,
                    InvoiceNumber = "INV-2026-0001",
                    InvoiceDate = new DateTime(2026, 1, 15),
                    DueDate = new DateTime(2026, 2, 14),
                    CurrencyCode = "BDT", ExchangeRateToBase = 1m,
                    SubTotal = 10000m, TaxTotal = 0m, TotalAmount = 10000m,
                    Status = "Draft", JournalEntryId = null
                });
                db.SaveChanges();
            }

            if (!db.PurchaseInvoices.Any(p => p.InvoiceNumber == "PINV-2026-0001"))
            {
                db.PurchaseInvoices.Add(new PurchaseInvoice
                {
                    BranchId = branchId, VendorId = vendorId, PurchaseOrderId = null,
                    InvoiceNumber = "PINV-2026-0001",
                    VendorInvoiceReference = "VREF-0001",
                    InvoiceDate = new DateTime(2026, 1, 16),
                    DueDate = new DateTime(2026, 2, 15),
                    CurrencyCode = "BDT", ExchangeRateToBase = 1m,
                    SubTotal = 5000m, TaxTotal = 0m, TotalAmount = 5000m,
                    Status = "Draft", JournalEntryId = null
                });
                db.SaveChanges();
            }
        }
    }
}
