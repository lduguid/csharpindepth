using System.Collections;

namespace Product
{
    internal class ProductStuffV1
    {
        /// <summary>
        /// 
        /// C# 1 version from c# indepth
        /// 
        /// </summary>
        private readonly string name;
        private readonly decimal price;

        private ProductStuffV1(string name, decimal price)
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
        
        private decimal Price
        {
            get
            {
                return this.price;
            }
        }

        public static ArrayList GetSampleProducts()
        {
            ArrayList list = new ArrayList();
            list.Add(new ProductStuffV1("West Side Story", 9.99m));
            list.Add(new ProductStuffV1("Assassins", 4.99m));
            list.Add(new ProductStuffV1("Frogs", 13.99m));
            list.Add(new ProductStuffV1("Sweeny Todd", 10.99m));
            return list;
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}", this.Name, this.Price);
        }
    }
}