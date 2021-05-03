using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.Name = "Elma";
            product1.Price = 1.50;
            product1.Stock = 50;

            Product product2 = new Product();
            product2.Id = 2;
            product2.Name = "Çilek";
            product2.Price = 8.25;
            product2.Stock = 25;

            Product product3 = new Product();
            product3.Id = 3;
            product3.Name = "Muz";
            product3.Price = 10;
            product3.Stock = 15;

            Product[] products = new Product[] { product1, product2, product3, };

            foreach (var alias in products)
            {
                Console.WriteLine("\nProduct Id = {0}\nProduct Name = {1}\nProduct Price = {2}\nProduct Stock = {3}",alias.Id,alias.Name,alias.Price,alias.Stock);
            }



            SepetManager sepetmanager = new SepetManager();

            sepetmanager.Add(product1);
            sepetmanager.Add(product2);
























        }
    }
}
