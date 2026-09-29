import React from 'react'
import { Routes, Route, Navigate } from 'react-router-dom'
import ProtectedRoute from '../auth/ProtectedRoute.jsx'
import MainLayout from '../components/layout/MainLayout.jsx'
import LoginPage from '../pages/LoginPage.jsx'
import DashboardPage from '../pages/DashboardPage.jsx'
import GenericListPage from '../components/crud/GenericListPage.jsx'
import GenericFormPage from '../components/crud/GenericFormPage.jsx'

// Only 3 routes are needed to cover every one of the ~90 entities,
// because GenericListPage / GenericFormPage read the entity key from
// the URL and look up their behaviour in the config registry.
export default function AppRoutes() {
  return (
    <Routes>
      <Route path="/login" element={<LoginPage />} />
      <Route element={<ProtectedRoute />}>
        <Route path="/app" element={<MainLayout />}>
          <Route index element={<DashboardPage />} />
          <Route path=":entityKey" element={<GenericListPage />} />
          <Route path=":entityKey/new" element={<GenericFormPage />} />
          <Route path=":entityKey/:id/edit" element={<GenericFormPage />} />
        </Route>
      </Route>
      <Route path="*" element={<Navigate to="/app" replace />} />
    </Routes>
  )
}
