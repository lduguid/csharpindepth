using System.Collections.Generic;

namespace Product
{
    internal class ProductStuff
    {
        /// <summary>
        /// 
        /// C# 2 version from c# indepth
        /// 
        /// Problems with c# version 1.
        /// 
        /// Strongly typed collections!
        /// 
        /// 1. should use generics for types if possible
        /// 2. private setters
        /// 
        /// </summary>
        private string name;
        private decimal price;

        public ProductStuff(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                this.name = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }

            private set
            {
                this.price = value;
            }
        }

        public static List<ProductStuff> GetSampleProducts()
        {
            List<ProductStuff> list = new List<ProductStuff>();
            list.Add(new ProductStuff("West Side Story", 9.99m));
            list.Add(new ProductStuff("Assassins", 4.99m));
            list.Add(new ProductStuff("Frogs", 13.99m));
            list.Add(new ProductStuff("Sweeny Todd", 10.99m));
            return list;
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}", 
                arg0: this.name, arg1: this.price);
        }
    }
}