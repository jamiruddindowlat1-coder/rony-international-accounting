import React, { useEffect, useState } from 'react'
import { createCrudApi } from '../api/genericApi'
import { entityRegistry } from '../config/entityRegistry'

export default function DashboardPage() {
  const [stats, setStats] = useState({
    totalRevenue: 0,
    totalInvoices: 0,
    activeEmployees: 0,
    activeBranches: 0,
  })
  const [recentActivity, setRecentActivity] = useState([])
  const [loading, setLoading] = useState(true)

  useEffect(() => {
    async function loadDashboard() {
      setLoading(true)
      try {
        const [invoices, employees, branches, journalEntries] = await Promise.all([
          createCrudApi(entityRegistry.salesInvoices.endpoint).getAll().catch(() => []),
          createCrudApi(entityRegistry.employees.endpoint).getAll().catch(() => []),
          createCrudApi(entityRegistry.branches.endpoint).getAll().catch(() => []),
          createCrudApi(entityRegistry.journalEntries.endpoint).getAll().catch(() => []),
        ])

        const totalRevenue = (invoices || []).reduce(
          (sum, inv) => sum + (Number(inv.totalAmount) || 0),
          0
        )
        const activeEmployees = (employees || []).filter((e) => e.isActive).length
        const activeBranches = (branches || []).filter((b) => b.isActive).length

        const sortedEntries = [...(journalEntries || [])].sort((a, b) => {
          const da = new Date(a.voucherDate || 0).getTime()
          const db = new Date(b.voucherDate || 0).getTime()
          return db - da
        })

        setStats({
          totalRevenue,
          totalInvoices: (invoices || []).length,
          activeEmployees,
          activeBranches,
        })
        setRecentActivity(sortedEntries.slice(0, 5))
      } catch (err) {
        console.error('Failed to load dashboard data', err)
      } finally {
        setLoading(false)
      }
    }

    loadDashboard()
  }, [])

  function formatCurrency(n) {
    return `$${Number(n).toLocaleString(undefined, { maximumFractionDigits: 0 })}`
  }

  return (
    <div>
      <div className="dashboard-welcome">
        <div className="dashboard-welcome-text">
          <h1>Welcome to RONY International Accounting</h1>
          <p>Complete multi-branch accounting, payroll, inventory, and financial management system.</p>
        </div>
        <img src="/assets/logo.png" alt="RONY Logo" className="dashboard-welcome-logo" />
      </div>

      <div className="dashboard-grid">
        <div className="dashboard-stat-card">
          <div className="dashboard-stat-icon">$</div>
          <div className="dashboard-stat-value">{loading ? '...' : formatCurrency(stats.totalRevenue)}</div>
          <div className="dashboard-stat-label">Total Revenue</div>
        </div>
        <div className="dashboard-stat-card">
          <div className="dashboard-stat-icon">#</div>
          <div className="dashboard-stat-value">{loading ? '...' : stats.totalInvoices}</div>
          <div className="dashboard-stat-label">Total Invoices</div>
        </div>
        <div className="dashboard-stat-card">
          <div className="dashboard-stat-icon">*</div>
          <div className="dashboard-stat-value">{loading ? '...' : stats.activeEmployees}</div>
          <div className="dashboard-stat-label">Active Employees</div>
        </div>
        <div className="dashboard-stat-card">
          <div className="dashboard-stat-icon">+</div>
          <div className="dashboard-stat-value">{loading ? '...' : stats.activeBranches}</div>
          <div className="dashboard-stat-label">Active Branches</div>
        </div>
      </div>

      <div className="glass-card">
        <h2 style={{ marginBottom: '16px', fontSize: '18px' }}>Recent Activity</h2>
        {loading ? (
          <div className="table-empty">Loading...</div>
        ) : recentActivity.length === 0 ? (
          <div className="table-empty">No recent activity to display.</div>
        ) : (
          <table className="data-table">
            <thead>
              <tr>
                <th>Voucher Number</th>
                <th>Type</th>
                <th>Date</th>
                <th>Narration</th>
                <th>Status</th>
              </tr>
            </thead>
            <tbody>
              {recentActivity.map((entry) => (
                <tr key={entry.id}>
                  <td>{entry.voucherNumber}</td>
                  <td>{entry.voucherType}</td>
                  <td>{entry.voucherDate ? new Date(entry.voucherDate).toLocaleDateString() : '-'}</td>
                  <td>{entry.narration}</td>
                  <td>{entry.status}</td>
                </tr>
              ))}
            </tbody>
          </table>
        )}
      </div>
    </div>
  )
}
