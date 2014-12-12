using System.Collections.Generic;

namespace Product
{
    public class ProductStuffV2
    {
        private string name;
        private decimal price;

        private ProductStuffV2(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }
        
        public decimal Price
        {
            get { return this.price; }
            private set { this.price = value; }
        }
        
        public static List<ProductStuffV2> GetSampleProducts()
        {
            List<ProductStuffV2> list = new List<ProductStuffV2>();
            list.Add(new ProductStuffV2("West Side Story", 9.99m));
            list.Add(new ProductStuffV2("Assassins", 14.99m));
            list.Add(new ProductStuffV2("Frogs", 13.99m));
            list.Add(new ProductStuffV2("Sweeney Todd", 10.99m));
            return list;
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}", this.name, this.price);
        }
    }
}