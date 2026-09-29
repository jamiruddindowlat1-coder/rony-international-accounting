import React from 'react'
import { Navigate, Outlet } from 'react-router-dom'
import { useAuth } from './AuthContext.jsx'

export default function ProtectedRoute() {
  const { user } = useAuth()
  const hasToken = !!localStorage.getItem('accessToken')
  if (!user && !hasToken) {
    return <Navigate to="/login" replace />
  }
  return <Outlet />
}
