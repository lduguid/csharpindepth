using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Product
{
    internal static class Program
    {
        internal static void Main(string[] args)
        {
            // c# version 1
            ArrayList productsV1 = ProductStuffV1.GetSampleProducts();
            productsV1.Sort(new ProductNameComparerV1());
            foreach (ProductStuffV1 product in productsV1)
            {
                Console.WriteLine(product);
            }

            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine();

            // c# version 2.1
            // sorting
            List<ProductStuffV2> productsV21 = ProductStuffV2.GetSampleProducts();
            productsV21.Sort(new ProductNameComparerV2());
            foreach (ProductStuffV2 product in productsV21)
            {
                Console.WriteLine(product);
            }

            Console.WriteLine("-----Price > 10-----");

            // querying
            Predicate<ProductStuffV2> test = delegate(ProductStuffV2 pV21)
            {
                return pV21.Price > 10m;
            };
            List<ProductStuffV2> matches = productsV21.FindAll(test);
            Action<ProductStuffV2> print = Console.WriteLine;
            matches.ForEach(print);

            Console.WriteLine();

            // c# version 2.2
            List<ProductStuffV2> productsV22 = ProductStuffV2.GetSampleProducts();

            productsV22.Sort(
                delegate(ProductStuffV2 x, ProductStuffV2 y)
                {
                    //return x.Name.CompareTo(y.Name);
                    return string.CompareOrdinal(x.Name, y.Name);
                });
            
            foreach (ProductStuffV2 product in productsV22)
            {
                Console.WriteLine(product);
            }

            Console.WriteLine("-----Price > 10-----");
            
            // quering
            productsV22.FindAll(delegate(ProductStuffV2 p)
            {
                return p.Price > 10;
            }).ForEach(Console.WriteLine);

            Console.WriteLine();

            // c# version 2.3
            List<ProductStuffV2> productsv23 = ProductStuffV2.GetSampleProducts();
            
            //productsv2.Sort((x, y) => x.Name.CompareTo(y.Name));
            productsv23.Sort((x, y) => string.CompareOrdinal(x.Name, y.Name));
            foreach (ProductStuffV2 product in productsv23)
            {
                Console.WriteLine(product);
            }
            
            Console.WriteLine();

            // c# version 2.4
            List<ProductStuffV2> productsV24 = ProductStuffV2.GetSampleProducts();
            foreach (ProductStuffV2 product in productsV24.OrderBy(p => p.Name))
            {
                Console.WriteLine(product);
            }

            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine();

            // c# version 3
            foreach (ProductStuffV3 item in ProductStuffV3.GetSampleProducts())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----Price > 10-----");

            // query
            List<ProductStuffV3> productsV3 = ProductStuffV3.GetSampleProducts();
            foreach (ProductStuffV3 productsv3Q in productsV3.Where(p => p.Price > 10))
            {
                Console.WriteLine(productsv3Q);
            }

            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine();

            // c# version 4
            foreach (ProductStuffV4 item in ProductStuffV4.GetSampleProducts())
            {
                Console.WriteLine(item);
            }
        }
    }
}
