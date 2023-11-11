using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoFreedom.Models
{
    public class Store
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public string Email { get; set; }
        [Required] 
        public string Phone { get; set; }
        [Required]
        public string ImageUrl { get; set; }


        
    }
}
