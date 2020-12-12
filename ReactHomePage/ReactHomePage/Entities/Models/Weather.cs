using System;
using System.Collections.Generic;
using System.Text;

namespace ReactHomePage.Models
{
    public class Weather
    {
        public int Id { get; set; }
        public string CityName { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
    }
}
