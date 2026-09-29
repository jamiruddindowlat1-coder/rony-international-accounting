using System;

namespace InternationalAccountingSystem.API.Dtos.Core
{
    public class CurrencyDto
    {
        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public byte DecimalPlaces { get; set; }
    }
}
