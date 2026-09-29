export const securityEntities = [
  {
    "key": "users",
    "label": "User",
    "endpoint": "/api/Users",
    "module": "Security",
    "isGlobal": true,
    "fields": [
      { "name": "username", "label": "Username", "type": "text", "required": true },
      { "name": "email", "label": "Email", "type": "text", "required": true },
      { "name": "passwordHash", "label": "Password Hash", "type": "text", "required": true },
      { "name": "passwordSalt", "label": "Password Salt", "type": "text", "required": true },
      { "name": "isEmailVerified", "label": "Is Email Verified", "type": "checkbox", "required": true },
      { "name": "phoneNumber", "label": "Phone Number", "type": "text", "required": true },
      { "name": "isTwoFactorEnabled", "label": "Is Two Factor Enabled", "type": "checkbox", "required": true },
      { "name": "twoFactorSecretEncrypted", "label": "Two Factor Secret Encrypted", "type": "text", "required": true },
      { "name": "isActive", "label": "Is Active", "type": "checkbox", "required": true },
      { "name": "isLocked", "label": "Is Locked", "type": "checkbox", "required": true },
      { "name": "failedLoginAttempts", "label": "Failed Login Attempts", "type": "number", "required": true },
      { "name": "lastLoginAt", "label": "Last Login At", "type": "date", "required": false },
      { "name": "lastPasswordChangeAt", "label": "Last Password Change At", "type": "date", "required": false },
      { "name": "mustChangePassword", "label": "Must Change Password", "type": "checkbox", "required": true }
    ]
  },
  {
    "key": "roles",
    "label": "Role",
    "endpoint": "/api/Roles",
    "module": "Security",
    "isGlobal": false,
    "fields": [
      { "name": "name", "label": "Name", "type": "text", "required": true },
      { "name": "description", "label": "Description", "type": "text", "required": true },
      { "name": "isSystemRole", "label": "Is System Role", "type": "checkbox", "required": true }
    ]
  },
  {
    "key": "permissions",
    "label": "Permission",
    "endpoint": "/api/Permissions",
    "module": "Security",
    "isGlobal": true,
    "fields": [
      { "name": "moduleName", "label": "Module Name", "type": "text", "required": true },
      { "name": "action", "label": "Action", "type": "text", "required": true },
      { "name": "code", "label": "Code", "type": "text", "required": true }
    ]
  },
  {
    "key": "rolePermissions",
    "label": "Role Permission",
    "endpoint": "/api/RolePermissions",
    "module": "Security",
    "isGlobal": true,
    "fields": [
      { "name": "roleId", "label": "Role Id", "type": "number", "required": true },
      { "name": "permissionId", "label": "Permission Id", "type": "number", "required": true }
    ]
  },
  {
    "key": "userRoles",
    "label": "User Role",
    "endpoint": "/api/UserRoles",
    "module": "Security",
    "isGlobal": true,
    "fields": [
      { "name": "userId", "label": "User Id", "type": "number", "required": true },
      { "name": "roleId", "label": "Role Id", "type": "number", "required": true }
    ]
  },
  {
    "key": "userCompanyAccesses",
    "label": "User Company Access",
    "endpoint": "/api/UserCompanyAccesses",
    "module": "Security",
    "isGlobal": false,
    "fields": [
      { "name": "userId", "label": "User Id", "type": "number", "required": true },
      { "name": "branchId", "label": "Branch Id", "type": "number", "required": false },
      { "name": "isDefault", "label": "Is Default", "type": "checkbox", "required": true }
    ]
  },
  {
    "key": "refreshTokens",
    "label": "Refresh Token",
    "endpoint": "/api/RefreshTokens",
    "module": "Security",
    "isGlobal": true,
    "fields": [
      { "name": "userId", "label": "User Id", "type": "number", "required": true },
      { "name": "tokenHash", "label": "Token Hash", "type": "text", "required": true },
      { "name": "expiresAt", "label": "Expires At", "type": "date", "required": true },
      { "name": "createdByIp", "label": "Created By Ip", "type": "text", "required": true },
      { "name": "revokedAt", "label": "Revoked At", "type": "date", "required": false },
      { "name": "replacedByTokenHash", "label": "Replaced By Token Hash", "type": "text", "required": true }
    ]
  },
  {
    "key": "loginHistories",
    "label": "Login History",
    "endpoint": "/api/LoginHistories",
    "module": "Security",
    "isGlobal": true,
    "fields": [
      { "name": "userId", "label": "User Id", "type": "number", "required": false },
      { "name": "attemptedUsername", "label": "Attempted Username", "type": "text", "required": true },
      { "name": "loginAt", "label": "Login At", "type": "date", "required": true },
      { "name": "ipAddress", "label": "Ip Address", "type": "text", "required": true },
      { "name": "userAgent", "label": "User Agent", "type": "text", "required": true },
      { "name": "success", "label": "Success", "type": "checkbox", "required": true },
      { "name": "failureReason", "label": "Failure Reason", "type": "text", "required": true }
    ]
  },
  {
    "key": "auditLogs",
    "label": "Audit Log",
    "endpoint": "/api/AuditLogs",
    "module": "Security",
    "isGlobal": false,
    "fields": [
      { "name": "userId", "label": "User Id", "type": "number", "required": false },
      { "name": "entityName", "label": "Entity Name", "type": "text", "required": true },
      { "name": "entityId", "label": "Entity Id", "type": "number", "required": true },
      { "name": "action", "label": "Action", "type": "text", "required": true },
      { "name": "oldValuesJson", "label": "Old Values Json", "type": "text", "required": true },
      { "name": "newValuesJson", "label": "New Values Json", "type": "text", "required": true },
      { "name": "timestamp", "label": "Timestamp", "type": "date", "required": true },
      { "name": "ipAddress", "label": "Ip Address", "type": "text", "required": true }
    ]
  },
  {
    "key": "approvalWorkflows",
    "label": "Approval Workflow",
    "endpoint": "/api/ApprovalWorkflows",
    "module": "Security",
    "isGlobal": false,
    "fields": [
      { "name": "entityType", "label": "Entity Type", "type": "text", "required": true },
      { "name": "minAmount", "label": "Min Amount", "type": "number", "required": false },
      { "name": "maxAmount", "label": "Max Amount", "type": "number", "required": false }
    ]
  },
  {
    "key": "approvalSteps",
    "label": "Approval Step",
    "endpoint": "/api/ApprovalSteps",
    "module": "Security",
    "isGlobal": false,
    "fields": [
      { "name": "workflowId", "label": "Workflow Id", "type": "number", "required": true },
      { "name": "stepOrder", "label": "Step Order", "type": "number", "required": true },
      { "name": "approverRoleId", "label": "Approver Role Id", "type": "number", "required": false },
      { "name": "isMandatory", "label": "Is Mandatory", "type": "checkbox", "required": true }
    ]
  },
  {
    "key": "approvalRequests",
    "label": "Approval Request",
    "endpoint": "/api/ApprovalRequests",
    "module": "Security",
    "isGlobal": false,
    "fields": [
      { "name": "entityType", "label": "Entity Type", "type": "text", "required": true },
      { "name": "entityId", "label": "Entity Id", "type": "number", "required": true },
      { "name": "workflowId", "label": "Workflow Id", "type": "number", "required": true },
      { "name": "currentStepOrder", "label": "Current Step Order", "type": "number", "required": true },
      { "name": "status", "label": "Status", "type": "text", "required": true },
      { "name": "requestedBy", "label": "Requested By", "type": "number", "required": true },
      { "name": "requestedAt", "label": "Requested At", "type": "date", "required": true }
    ]
  },
  {
    "key": "approvalActions",
    "label": "Approval Action",
    "endpoint": "/api/ApprovalActions",
    "module": "Security",
    "isGlobal": false,
    "fields": [
      { "name": "approvalRequestId", "label": "Approval Request Id", "type": "number", "required": true },
      { "name": "stepOrder", "label": "Step Order", "type": "number", "required": true },
      { "name": "actionBy", "label": "Action By", "type": "number", "required": true },
      { "name": "action", "label": "Action", "type": "text", "required": true },
      { "name": "comments", "label": "Comments", "type": "text", "required": true },
      { "name": "actionAt", "label": "Action At", "type": "date", "required": true }
    ]
  }
];
