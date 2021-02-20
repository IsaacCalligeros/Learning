using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReactHomePage.Entities.Dtos.Equities
{
    public class Company
    {
        public string Ticker { get; set; }
        public string CompanyName { get; set; }
        public DateTime? ListingDate { get; set; }
        public string Industry { get; set; }
    }
}
