using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Azure2soln.Models
{
    public class ToDo
    {
        public int ID { get; set; }
        public string? Description { get; set; }

        [Display(Name = "Created Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}",
        ApplyFormatInEditMode = true)]
        public DateTime CreatedDate { get; set; }

    }
}
