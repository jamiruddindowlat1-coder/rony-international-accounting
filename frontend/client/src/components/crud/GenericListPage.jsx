import React, { useEffect, useState, useMemo } from 'react'
import { useNavigate, useParams, Link } from 'react-router-dom'
import { createCrudApi } from '../../api/genericApi'
import { entityRegistry } from '../../config/entityRegistry'
import DataTable from '../common/DataTable.jsx'
import { exportToPDF, exportToExcel } from '../../utils/exportUtils'

export default function GenericListPage() {
  const { entityKey } = useParams()
  const navigate = useNavigate()
  const config = entityRegistry[entityKey]
  const [rows, setRows] = useState([])
  const [loading, setLoading] = useState(true)
  const [error, setError] = useState(null)
  const [searchTerm, setSearchTerm] = useState('')

  useEffect(() => {
    if (!config) return
    const api = createCrudApi(config.endpoint)
    setLoading(true)
    api
      .getAll()
      .then((data) => setRows(data || []))
      .catch((err) => setError(err.message))
      .finally(() => setLoading(false))
  }, [entityKey])

  const filteredRows = useMemo(() => {
    if (!searchTerm) return rows
    return rows.filter(row => 
      Object.values(row).some(val => 
        String(val).toLowerCase().includes(searchTerm.toLowerCase())
      )
    )
  }, [rows, searchTerm])

  if (!config) return <p>Unknown entity: {entityKey}</p>

  const api = createCrudApi(config.endpoint)

  function handleDelete(id) {
    if (!window.confirm('Delete this record?')) return
    api.remove(id).then(() => setRows((prev) => prev.filter((r) => r.id !== id)))
  }
  
  const columns = config.fields.slice(0, 6).map((f) => ({ name: f.name, label: f.label }))

  const handleExportPDF = () => {
    exportToPDF(config.label, columns, filteredRows)
  }
  
  const handleExportExcel = () => {
    exportToExcel(config.label, columns, filteredRows)
  }
  
  const handlePrint = () => {
    window.print()
  }

  return (
    <div>
      {/* Hidden print header */}
      <div className="print-header">
        <img src="/assets/logo.png" alt="RONY Logo" />
        <div className="print-header-info">
          <h1>RONY International Accounting Software</h1>
          <p>Report: {config.label} List</p>
          <p>Generated on: {new Date().toLocaleString()}</p>
        </div>
      </div>

      <div className="page-header">
        <h1>{config.label}</h1>
        <div className="page-header-actions">
          <button className="btn btn-secondary" onClick={handlePrint} data-tooltip="Print Record">🖨️ Print</button>
          <button className="btn btn-secondary" onClick={handleExportPDF} data-tooltip="Export PDF">📄 PDF</button>
          <button className="btn btn-secondary" onClick={handleExportExcel} data-tooltip="Export Excel">📊 Excel</button>
          <Link className="btn btn-primary" to={`/app/${entityKey}/new`}>+ Add {config.label}</Link>
        </div>
      </div>

      <div className="table-toolbar" style={{ backgroundColor: 'var(--bg-card)', borderRadius: 'var(--radius-lg) var(--radius-lg) 0 0', borderBottom: 'none' }}>
        <div className="table-search">
          <span className="table-search-icon">🔍</span>
          <input 
            type="text" 
            placeholder="Search records..." 
            value={searchTerm}
            onChange={e => setSearchTerm(e.target.value)}
          />
        </div>
      </div>

      {loading && (
        <div className="loading-spinner">
          <div className="spinner"></div>
          <span>Loading data...</span>
        </div>
      )}
      
      {error && (
        <div style={{ padding: '20px', background: 'rgba(239, 68, 68, 0.1)', color: '#ef4444', borderRadius: 'var(--radius-md)', marginBottom: '20px' }}>
          <strong>Error:</strong> {error}
        </div>
      )}
      
      {!loading && !error && (
        <DataTable
          columns={columns}
          rows={filteredRows}
          onEdit={(id) => navigate(`/app/${entityKey}/${id}/edit`)}
          onDelete={handleDelete}
        />
      )}
    </div>
  )
}
