import React, { createContext, useContext, useState } from 'react'
import axiosClient from '../api/axiosClient'

const AuthContext = createContext(null)

export function AuthProvider({ children }) {
  const [user, setUser] = useState(() => {
    const raw = localStorage.getItem('authUser')
    return raw ? JSON.parse(raw) : null
  })

  async function login(email, password) {
    const res = await axiosClient.post('/api/Auth/login', { email, password })
    const data = res.data.data
    localStorage.setItem('accessToken', data.token)
    localStorage.setItem('authUser', JSON.stringify({
      id: data.userId,
      username: data.username,
      email: data.email,
      role: data.role
    }))
    setUser({ id: data.userId, username: data.username, email: data.email, role: data.role })
  }

  function logout() {
    localStorage.removeItem('accessToken')
    localStorage.removeItem('refreshToken')
    localStorage.removeItem('authUser')
    setUser(null)
  }

  return (
    <AuthContext.Provider value={{ user, login, logout }}>
      {children}
    </AuthContext.Provider>
  )
}

export function useAuth() {
  return useContext(AuthContext)
}
