using System;
using System.Collections.Generic;
using System.Text;
using static ReactHomePage.Enumerations.Enums;

namespace ReactHomePage.Models
{
    public class News : BaseContainer
    {
        public int Id { get; set; }
        public NewsSources NewsSource { get; set; }
    }
}
