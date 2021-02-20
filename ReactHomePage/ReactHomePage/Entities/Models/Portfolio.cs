using ReactHomePage.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ReactHomePage.Entities.Models
{
    public class Portfolio
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        
        //protected hides from nswag i.e. wanting to keep it server side only
        protected ApplicationUser User { get; set; }

        public virtual ICollection<Equity> Equities { get; set; }
    }
}
