
using System.ComponentModel.DataAnnotations.Schema;


namespace DomainModel.Entities
{
    [Table("Products")]
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public string Category { get; set; }

    }
}
