using System;

namespace ABC.bl
{
    public class ProductRepository
    {
        public Product Download(int ProductID)
        {
            Product product = new Product(ProductID);
            Object mojobkiekt = new Object();
            Console.WriteLine("obiekt: "+mojobkiekt.ToString());
            Console.WriteLine("obiekt: " + product.ToString());

            if (ProductID == 2) 
            {
                product.ProductName = "Klocki";
                product.Description = "Kolcki hamulcowe dla dzieci powyżej 2 lat";
                product.OrderPrice = 199.99M;

            }
            return product;
        }

        //zapisywanie porduktu
        public bool Save(Product product)
        {
            var success = true;
            if (product.IsChanged && product.IsDataCorrect) 
            {
                if(product.IsNew)
                {
                    //wywołujemy insert
                }
                else
                {
                    //wywołujemy update
                }
            }
            return success;
        }
    }
}
