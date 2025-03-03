using System.ComponentModel.DataAnnotations;

namespace ReyRemerasApi.Models
{
    public class Fabric
    {
        
        public int Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
