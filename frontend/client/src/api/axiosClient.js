import axios from 'axios'

const axiosClient = axios.create({
  baseURL: import.meta.env.VITE_API_BASE_URL || 'https://localhost:7100',
})

axiosClient.interceptors.request.use((config) => {
  const token = localStorage.getItem('accessToken')
  if (token) {
    config.headers.Authorization = `Bearer ${token}`
  }
  
  // Inject Tenant Context Headers
  const savedContext = localStorage.getItem('tenant_context')
  if (savedContext) {
    try {
      const tenant = JSON.parse(savedContext)
      if (tenant.companyId) config.headers['X-Company-Id'] = tenant.companyId
      if (tenant.branchId) config.headers['X-Branch-Id'] = tenant.branchId
    } catch (e) {
      console.error('Failed to parse tenant context for interceptor', e)
    }
  }
  
  return config
})

// TODO: add a response interceptor here that, on a 401, calls
// POST /api/auth/refresh with the stored refresh token and retries
// the original request once - once you have built the (hand-written,
// not generated) AuthController described in README.md.

export default axiosClient

