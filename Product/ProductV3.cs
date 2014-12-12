using System.Collections.Generic;

namespace Product
{
    internal class ProductStuffV3
    {
        /// <summary>
        /// 
        /// C# 3 version from c# indepth
        /// 
        /// </summary>
        public ProductStuffV3(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        private ProductStuffV3()
        {
        }

        internal string Name { get; private set; }

        internal decimal Price { get; private set; }
        
        public static List<ProductStuffV3> GetSampleProducts()
        {
            return new List<ProductStuffV3>
                   {
                       new ProductStuffV3 { Name = "West Side Story", Price = 9.99m },
                       new ProductStuffV3 { Name = "Assassins", Price = 14.99m }, 
                       new ProductStuffV3 { Name = "Frogs", Price = 13.99m }, 
                       new ProductStuffV3 { Name = "Sweeney Todd", Price = 10.99m }
                   };
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}", this.Name, this.Price);
        }
    }
}