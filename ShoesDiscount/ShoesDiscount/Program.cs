using System;

namespace ShoesDiscount
{
    class Program
    {
        class Product
        {
            public string Name { get; set; }
            public int Price { get; set; }
            public override string ToString() => $"{Name} {Price}";
        }

        static void ApplyDiscount(Product shoes)
        {
            shoes = new Product { Name = "discounted shoes", Price = shoes.Price / 2 };
        }

        static void Main(string[] args)
        {
            var shoes = new Product { Name = "my shoes", Price = 100 };
            ApplyDiscount(shoes);
            Console.WriteLine(shoes); // Output: my shoes 100
        }
    }
}
