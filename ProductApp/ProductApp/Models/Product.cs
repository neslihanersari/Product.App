namespace ProductApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product(int ıd, string name, decimal price)
        {
            Id = ıd;
            Name = name;
            Price = price;
        }
    }

}