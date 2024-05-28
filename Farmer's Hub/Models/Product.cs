using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Farmer_s_Hub.Models
{
    public class Product
    {
        public enum Categories
        {
            Livestock,
            Crops,
            Diary,
            Fish,
            Miscellaneus
        }
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public Categories Category { get; set; }
        [Display(Name = "Production Date")]
        public DateTime ProductionDate { get; set; }
        [ForeignKey("User")]
        [Display(Name = "User ID")]
        public int UserId { get; set; }
    }
}
