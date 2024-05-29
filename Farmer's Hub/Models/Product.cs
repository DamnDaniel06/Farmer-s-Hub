using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Farmer_s_Hub.Data.Enum;

namespace Farmer_s_Hub.Models
{
    public class Product
    {
        

        [Key]
        public int ID { get; set; }
        
        public string Name { get; set; }

        public ProductCategory Category { get; set; }

        [Display(Name = "Production Date")]
        public DateTime ProductionDate { get; set; }

        [ForeignKey("User")]
        [Display(Name = "User ID")]
        public int UserId { get; set; }
    }
}
