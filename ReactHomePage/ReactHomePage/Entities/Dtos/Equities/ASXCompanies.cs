using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReactHomePage.Entities.Dtos.Equities
{
    public class ASXCompanies
    {
        public string Ticker { get; set; }
        public string Company { get; set; }
        public DateTime? ListingDate { get; set; }
        public string Industry { get; set; }
    }
}
