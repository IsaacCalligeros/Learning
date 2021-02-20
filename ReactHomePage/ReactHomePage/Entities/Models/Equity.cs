using System.Collections.Generic;
using static ReactHomePage.Enumerations.Enums;
using System.ComponentModel.DataAnnotations;
using ReactHomePage.Entities.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReactHomePage.Models
{
    public class Equity
    {
        [Key]
        public int Id { get; set; }
        public string Ticker { get; set; }
        public EquityType Type { get; set; }
        public float NumberHeld { get; set; }
        public float PurchasePrice { get; set; }

        public int PortfolioId { get; set; }

        [ForeignKey("PortfolioId")]
        protected Portfolio Portfolio { get; set; }
    }
}