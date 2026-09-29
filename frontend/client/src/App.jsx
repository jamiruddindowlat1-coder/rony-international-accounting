import React from 'react'
import AppRoutes from './routes/AppRoutes.jsx'
import { TenantProvider } from './context/TenantContext.jsx'
import { AuthProvider } from './auth/AuthContext.jsx'

export default function App() {
  return (
    <AuthProvider>
      <TenantProvider>
        <AppRoutes />
      </TenantProvider>
    </AuthProvider>
  )
}
