using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DevSparsh.Areas.Admin.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Product Name")]
        [MaxLength(30)]
        public string Name { get; set; }

        [Required]
        [DisplayName("Product Description")]
        public string Description { get; set; }

        [Required]
        [DisplayName("Product Category")]
        [MaxLength(30)]
        public string Category { get; set; }

        [Required]
        [DisplayName("Product Price")]
        public int Price { get; set; }


        [DisplayName("Product Image")]
        public string? ImageUrl { get; set; }
    }
}
