using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class BasketManager
    {
        public void Add(Product product) 
        {
            Console.WriteLine("Congratulations. Added to basket. : " + product.Name);
        }

        public void Add2(string productName, string definition, double price, int stockPiece)
        {
            Console.WriteLine("Congratulations. Added to basket. : " + productName);

        }
    }
}
