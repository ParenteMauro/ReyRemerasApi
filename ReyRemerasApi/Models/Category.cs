using System.ComponentModel.DataAnnotations;

namespace ReyRemerasApi.Models
{
    public class Category
    {
        public int Id { get; set; }
        [StringLength(15)]
        public string Name { get; set; }
    }
}
