namespace ReyRemerasApi.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Id_Fabric { get; set; }
        public virtual Fabric Fabric { get; set; }  

        public string? Description { get; set; }

    }
}
