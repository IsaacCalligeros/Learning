using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static ReactHomePage.Enumerations.Enums;

namespace ReactHomePage.Entities.Models
{
    public class BaseContainer
    {
        [Key]
        public int ContainerId { get; set; }
        public int UserId { get; set; }

        [ForeignKey("Layout")]
        public string LayoutId { get; set; }
        public Layout Layout { get; set; }

        public ComponentType ComponentType { get; set; }
    }

}
