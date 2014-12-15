using System.Collections.Generic;

namespace Product
{
    internal class ProductStuffV4
    {
        /// <summary>
        /// 
        /// C# 4 version from c# indepth
        /// 
        /// </summary>
        private readonly string name;

        private readonly decimal price;

        private ProductStuffV4(string name, decimal price)
        {
            this.name = name;
            this.price = price;
        }

        internal string Name
        {
            get
            {
                return this.name;
            }
        }

        internal decimal Price
        {
            get
            {
                return this.price;
            }
        }

        public static List<ProductStuffV4> GetSampleProducts()
        {
            return new List<ProductStuffV4>
                   {
                       new ProductStuffV4(name: "West Side Story", price: 9.99m),
                       new ProductStuffV4(name: "Assassins", price: 14.99m), 
                       new ProductStuffV4(name: "Frogs", price: 13.99m), 
                       new ProductStuffV4(name: "Sweeney Todd", price: 10.99m)
                   };
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}", this.name, this.price);
        }
    }
}