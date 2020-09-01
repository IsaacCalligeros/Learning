using System;
using System.Collections.Generic;
using System.Text;

namespace ReactHomePage.Models
{
    public class BaseContainer
    {
        public int UserId { get; set; }
        public Guid ControlId { get; set; }
        public int H { get; set; }
        public int W { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
    }
}
