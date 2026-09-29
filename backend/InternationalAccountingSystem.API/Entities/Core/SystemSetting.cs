using System;
using InternationalAccountingSystem.API.Common;

namespace InternationalAccountingSystem.API.Entities.Core
{
    public class SystemSetting : BaseEntity
    {
        public string SettingKey { get; set; }
        public string SettingValue { get; set; }
    }
}
