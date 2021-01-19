using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name = "Apple";
            double Price = 15;
            string Definition = "Amasya apple";

            string[] fruits = new string[] {"Apple","Water melon"};

            Product product1 = new Product();
            product1.Name = "Apple";
            product1.Price = 15;
            product1.Definition = "Amasya apple";

            Product product2 = new Product();
            product2.Name = "Water melon";
            product2.Price = 80;
            product2.Definition = "Diyarbakır water melon";

            Product[] products = new Product[] {product1, product2 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Definition);
                Console.WriteLine("---------------");
            }

            Console.WriteLine("----Methods-----");
            BasketManager basketManager = new BasketManager();
            basketManager.Add(product1);
            basketManager.Add(product2);

            basketManager.Add2("Pear", "Green pear", 12, 10);
            basketManager.Add2("Apple", "Green apple", 12, 9);
            basketManager.Add2("Water melon", "Diyarbakır water melon", 12, 8);

        }

    }
}
