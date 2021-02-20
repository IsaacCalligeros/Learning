using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReactHomePage.Entities.Models
{
    public class Layout
    {
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
