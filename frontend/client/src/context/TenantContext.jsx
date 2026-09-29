import React, { createContext, useContext, useState, useEffect } from 'react';

const TenantContext = createContext();

export function TenantProvider({ children }) {
  const [tenant, setTenant] = useState(() => {
    const saved = localStorage.getItem('tenant_context');
    if (saved) {
      try {
        return JSON.parse(saved);
      } catch (e) {
        console.error('Failed to parse tenant context', e);
      }
    }
    // Default fallback
    return { companyId: '1', branchId: '1' };
  });

  useEffect(() => {
    localStorage.setItem('tenant_context', JSON.stringify(tenant));
  }, [tenant]);

  return (
    <TenantContext.Provider value={{ tenant, setTenant }}>
      {children}
    </TenantContext.Provider>
  );
}

export function useTenant() {
  return useContext(TenantContext);
}
