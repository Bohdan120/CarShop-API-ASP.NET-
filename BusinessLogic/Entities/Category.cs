namespace DataAccess.Data.Entities
{
    public enum Categories
    {
        Gasoline = 1,
        Diesel,
        Hybrid,
        Electric,
        Other
    }
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Product>? Products { get; set; } 
    }
}
