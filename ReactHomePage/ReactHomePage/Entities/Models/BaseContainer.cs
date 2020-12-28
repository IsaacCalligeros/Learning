using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Text;
using static ReactHomePage.Enumerations.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReactHomePage.Models
{
    public class BaseContainer
    {
        [Key]
        public int ContainerId { get; set; }
        public int UserId { get; set; }

        public Layout Layout { get; set; }

        public ComponentType ComponentType { get; set; }
    }

    public class Layout
    {
        public int ContainerId { get; set; }

        [Key]
        [JsonProperty("i")]
        public string I { get; set; }
        [JsonProperty("h")]
        public int H { get; set; }
        [JsonProperty("w")]
        public int W { get; set; }
        [JsonProperty("x")]
        public int X { get; set; }
        [JsonProperty("y")]
        public int Y { get; set; }
    }
}
