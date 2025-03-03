using System.ComponentModel.DataAnnotations.Schema;

namespace ReyRemerasApi.Models
{
    public class StockProduct
    {
        public int Id { get; set; }

        [ForeignKey("Product")]
        public int Id_Product { get; set; }

        [ForeignKey("Color")]
        public int Id_Color { get; set; }

        [ForeignKey("Size")]
        public int Id_Size { get; set; }

        public int Quantity { get; set; }

        public virtual Product Product { get; set; }
        public virtual Color Color { get; set; }
        public virtual Size Size { get; set; }
    }
}
