using System;

namespace YineYeniYeniden
{
    class Program
    {
        static void Main(string[] args)
        {
            var Product1 = new Product();
            Product1.Name = "Ayakkabı";
            Product1.Id = 1;
            Product1.Price = 720;
            Product1.Stock = 100;
            
            var Product2 = new Product();
            Product2.Name = "Elbise";
            Product2.Id = 2;
            Product2.Price = 300;
            Product2.Stock = 50;

            var Product3 = new Product();
            Product3.Name = "Şapka";
            Product3.Id = 3;
            Product3.Price = 100;
            Product3.Stock = 10;

            var Product4 = new Product();
            Product4.Name = "Tava";
            Product4.Id = 4;
            Product4.Price = 50;
            Product4.Stock = 200;

            Product[] products = new Product[] { Product1, Product2, Product3, Product4 };

            foreach (var alias in products)
            {
                Console.WriteLine("\nProduct Id = {0}\nProduct Name = {1}\nProduct Price = {2} TL\nProduct Stock = {3} ADET KALAN",alias.Id, alias.Name, alias.Price, alias.Stock);
            }

        }
        class Product

    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }

        }
    }
}
