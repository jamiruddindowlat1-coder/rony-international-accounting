import React, { useState } from 'react'
import { useAuth } from '../auth/AuthContext.jsx'
import { useNavigate } from 'react-router-dom'

export default function LoginPage() {
  const [email, setEmail] = useState('')
  const [password, setPassword] = useState('')
  const [error, setError] = useState('')
  const { login } = useAuth()
  const navigate = useNavigate()

  const handleLogin = async (e) => {
    e.preventDefault()
    if (!email || !password) {
      setError('Please enter both email and password.')
      return
    }
    try {
      await login(email, password)
      navigate('/app')
    } catch (err) {
      setError('Login failed. Please check your email and password.')
    }
  }

  return (
    <div className="login-page">
      <div className="login-box">
        <div className="login-logo-wrapper">
          <img src="/assets/logo.png" alt="RONY Logo" className="login-logo" />
          <div className="login-subtitle">Accounting & Financial Management System</div>
        </div>
        <h2>Welcome Back</h2>
        <p style={{ textAlign: 'center', marginBottom: '24px', color: 'var(--text-muted)', fontSize: '13px' }}>
          Sign in to your account to continue
        </p>
        {error && <div className="login-error">{error}</div>}
        <form onSubmit={handleLogin}>
          <div className="form-field">
            <label>Email</label>
            <input
              type="email"
              placeholder="Enter your email"
              value={email}
              onChange={e => setEmail(e.target.value)}
            />
          </div>
          <div className="form-field">
            <label>Password</label>
            <input
              type="password"
              placeholder="Enter your password"
              value={password}
              onChange={e => setPassword(e.target.value)}
            />
          </div>
          <button type="submit" className="btn btn-primary" style={{ marginTop: '16px' }}>
            Sign In
          </button>
        </form>
      </div>
    </div>
  )
}
