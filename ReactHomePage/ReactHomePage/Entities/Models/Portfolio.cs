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

        [ForeignKey("ApplicationUserId")]
        public int UserId { get; set; }

        public ICollection<Equity> Equities { get; set; }
    }
}
