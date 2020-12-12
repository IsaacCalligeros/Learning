using System;
using System.Collections.Generic;
using System.Text;

namespace ReactHomePage.Models
{
    public interface Auditables
    {
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
    }
}
