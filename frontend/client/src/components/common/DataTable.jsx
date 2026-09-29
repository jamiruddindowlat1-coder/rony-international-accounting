import React from 'react'

// Generic read-only table: `columns` = [{name, label}], `rows` = array of objects.
export default function DataTable({ columns, rows, onEdit, onDelete }) {
  if (!rows || rows.length === 0) {
    return (
      <div className="table-empty">
        No records found.
      </div>
    )
  }

  return (
    <div className="table-container">
      <div style={{ overflowX: 'auto' }}>
        <table className="data-table">
          <thead>
            <tr>
              {columns.map((c) => (
                <th key={c.name}>{c.label}</th>
              ))}
              <th style={{ width: '120px', textAlign: 'right' }}>Actions</th>
            </tr>
          </thead>
          <tbody>
            {rows.map((row) => (
              <tr key={row.id}>
                {columns.map((c) => {
                  let value = row[c.name]
                  if (typeof value === 'boolean') {
                    value = value ? 'Yes' : 'No'
                  } else if (value === null || value === undefined) {
                    value = '-'
                  }
                  return <td key={c.name}>{String(value)}</td>
                })}
                <td style={{ textAlign: 'right' }}>
                  <div className="table-actions" style={{ justifyContent: 'flex-end' }}>
                    <button className="btn btn-sm btn-secondary" onClick={() => onEdit(row.id)}>Edit</button>
                    <button className="btn btn-sm btn-danger" onClick={() => onDelete(row.id)}>Delete</button>
                  </div>
                </td>
              </tr>
            ))}
          </tbody>
        </table>
      </div>
      <div className="table-pagination">
        <div>Showing {rows.length} records</div>
        <div className="table-pagination-controls">
          <button disabled>&lt;</button>
          <button className="active">1</button>
          <button disabled>&gt;</button>
        </div>
      </div>
    </div>
  )
}
