import React from 'react'
import { useLocation } from 'react-router-dom'
import { useAuth } from '../../auth/AuthContext.jsx'
import { entityRegistryByModule } from '../../config/entityRegistry'
import { useTenant } from '../../context/TenantContext.jsx'

export default function Navbar() {
  const { user, logout } = useAuth()
  const location = useLocation()
  const { tenant } = useTenant()
  
  // Find current page title
  let currentTitle = 'Dashboard'
  const pathParts = location.pathname.split('/')
  const currentKey = pathParts[pathParts.length - 1]
  
  Object.values(entityRegistryByModule).forEach(items => {
    const found = items.find(i => i.key === currentKey)
    if (found) currentTitle = found.label
  })

  return (
    <div className="navbar">
      <div className="navbar-left">
        <span className="navbar-page-title">{currentTitle}</span>
        <span className="navbar-breadcrumb">Application / {currentTitle}</span>
      </div>
      
      <div className="navbar-right">
        <div className="navbar-context-badge">
          <div className="dot"></div>
          <span>Context: Company {tenant.companyId} | Branch {tenant.branchId}</span>
        </div>
        
        <div className="navbar-user" onClick={logout} data-tooltip="Click to logout">
          <div className="navbar-avatar">
            {user?.username ? user.username.charAt(0).toUpperCase() : 'U'}
          </div>
          <div className="navbar-user-info">
            <span className="navbar-user-name">{user?.username || 'Admin'}</span>
            <span className="navbar-user-role">System Administrator</span>
          </div>
        </div>
      </div>
    </div>
  )
}
