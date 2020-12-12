using System.Collections.Generic;
using static ReactHomePage.Enumerations.Enums;

namespace ReactHomePage.Models
{
    public class Stock
    {
        public int Id { get; set; }
        public string Ticker { get; set; }
        public EquityType Type { get; set; }
    }
}