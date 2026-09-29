import React, { useState } from 'react'
import { NavLink, useLocation } from 'react-router-dom'
import { entityRegistryByModule } from '../../config/entityRegistry'
import { useTenant } from '../../context/TenantContext.jsx'

export default function Sidebar() {
  const [collapsedModules, setCollapsedModules] = useState({})
  const location = useLocation()
  const { tenant, setTenant } = useTenant()

  const toggleModule = (moduleName) => {
    setCollapsedModules((prev) => ({
      ...prev,
      [moduleName]: !prev[moduleName],
    }))
  }

  return (
    <div className="sidebar">
      <div className="sidebar-header">
        <img src="/assets/logo.png" alt="RONY Logo" className="sidebar-logo" />
        <div className="sidebar-brand">
          <span className="sidebar-brand-name">RONY</span>
          <span className="sidebar-brand-sub">International</span>
        </div>
      </div>
      
      <div className="sidebar-context">
        <label>Company / Share ID</label>
        <select 
          value={tenant.companyId}
          onChange={(e) => setTenant({ ...tenant, companyId: e.target.value })}
        >
          <option value="1">Main Company</option>
          <option value="2">Subsidiary</option>
        </select>
        <label>Branch</label>
        <select
          value={tenant.branchId}
          onChange={(e) => setTenant({ ...tenant, branchId: e.target.value })}
        >
          <option value="1">Dhaka Head Office</option>
          <option value="2">Chittagong Branch</option>
        </select>
      </div>

      <div className="sidebar-nav">
        {Object.entries(entityRegistryByModule).map(([moduleName, items]) => {
          const isCollapsed = collapsedModules[moduleName];
          return (
            <div key={moduleName} className="sidebar-module">
              <div 
                className="sidebar-module-header"
                onClick={() => toggleModule(moduleName)}
              >
                <span className="module-icon">❖</span>
                <span>{moduleName}</span>
                <span className={`chevron ${!isCollapsed ? 'open' : ''}`}>▶</span>
              </div>
              <div className={`sidebar-module-items ${isCollapsed ? 'collapsed' : ''}`}>
                {items.map((item) => (
                  <NavLink key={item.key} to={`/app/${item.key}`} className={({isActive}) => isActive ? "active" : ""}>
                    {item.label}
                  </NavLink>
                ))}
              </div>
            </div>
          );
        })}
      </div>
    </div>
  )
}
