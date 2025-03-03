namespace ReyRemerasApi.Models
{
    public class PriceSizeCategory
    {
        public int Id_Category { get; set; }

        public virtual Category Category{get;set;}
        public decimal Price { get; set; }
    }
}
