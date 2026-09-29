using System;

namespace InternationalAccountingSystem.API.Dtos.Core
{
    public class SystemSettingDto
    {
        public long Id { get; set; }
        public long? CompanyId { get; set; }
        public string SettingKey { get; set; }
        public string SettingValue { get; set; }
    }
}
