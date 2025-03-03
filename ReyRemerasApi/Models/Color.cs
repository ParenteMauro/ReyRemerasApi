using System.ComponentModel.DataAnnotations;

namespace ReyRemerasApi.Models
{
    public class Color
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string Name { get; set; }
    }
}
