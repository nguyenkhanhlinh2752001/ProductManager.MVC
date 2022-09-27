using System.ComponentModel.DataAnnotations;

namespace ProductManager.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(256)]
        public string Name { get; set; }
        public List<Product> Products { get; set; }

    }
}