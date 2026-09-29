export const notificationsEntities = [
  {
    "key": "notifications",
    "label": "Notification",
    "endpoint": "/api/Notifications",
    "module": "Notifications",
    "isGlobal": false,
    "fields": [
      {
        "name": "userId",
        "label": "User Id",
        "type": "number",
        "required": true
      },
      {
        "name": "title",
        "label": "Title",
        "type": "text",
        "required": true
      },
      {
        "name": "message",
        "label": "Message",
        "type": "text",
        "required": true
      },
      {
        "name": "type",
        "label": "Type",
        "type": "text",
        "required": true
      },
      {
        "name": "linkUrl",
        "label": "Link Url",
        "type": "text",
        "required": true
      },
      {
        "name": "isRead",
        "label": "Is Read",
        "type": "checkbox",
        "required": true
      }
    ]
  },
  {
    "key": "emailQueueItems",
    "label": "Email Queue Item",
    "endpoint": "/api/EmailQueueItems",
    "module": "Notifications",
    "isGlobal": true,
    "fields": [
      {
        "name": "toAddress",
        "label": "To Address",
        "type": "text",
        "required": true
      },
      {
        "name": "subject",
        "label": "Subject",
        "type": "text",
        "required": true
      },
      {
        "name": "body",
        "label": "Body",
        "type": "text",
        "required": true
      },
      {
        "name": "status",
        "label": "Status",
        "type": "text",
        "required": true
      },
      {
        "name": "retryCount",
        "label": "Retry Count",
        "type": "number",
        "required": true
      },
      {
        "name": "lastError",
        "label": "Last Error",
        "type": "text",
        "required": true
      },
      {
        "name": "sentAt",
        "label": "Sent At",
        "type": "date",
        "required": false
      }
    ]
  },
  {
    "key": "smsQueueItems",
    "label": "Sms Queue Item",
    "endpoint": "/api/SmsQueueItems",
    "module": "Notifications",
    "isGlobal": true,
    "fields": [
      {
        "name": "toPhoneNumber",
        "label": "To Phone Number",
        "type": "text",
        "required": true
      },
      {
        "name": "message",
        "label": "Message",
        "type": "text",
        "required": true
      },
      {
        "name": "status",
        "label": "Status",
        "type": "text",
        "required": true
      },
      {
        "name": "retryCount",
        "label": "Retry Count",
        "type": "number",
        "required": true
      },
      {
        "name": "lastError",
        "label": "Last Error",
        "type": "text",
        "required": true
      },
      {
        "name": "sentAt",
        "label": "Sent At",
        "type": "date",
        "required": false
      }
    ]
  }
];
