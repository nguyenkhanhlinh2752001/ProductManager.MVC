using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductManager.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(256)]
        public string Name { get; set; }

        [MaxLength(256)]
        public int Slug { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        
        public int CategoryId { get; set; }
        
        public Category Category { get; set; }
    }
}