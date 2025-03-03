using System.ComponentModel.DataAnnotations;

namespace ReyRemerasApi.Models
{
    public class Size
    {
        public int Id { get; set; }

        
        public int Id_PriceSizeCategory { get; set; }
        public virtual PriceSizeCategory PriceSizeCategory { get; set; }

        [StringLength(4)]
        public string Name { get; set; }
    }
}
