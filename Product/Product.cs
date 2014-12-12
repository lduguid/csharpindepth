using System;
using System.Collections;


namespace Product
{

    internal class ProductStuff
    {
        private string name;
        private decimal price;

        public ProductStuff(string name, decimal price)
        {
            this.name = name;
            this.price = price;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
        }
        
        public static ArrayList GetSampleProducts()
        {
            ArrayList list = new ArrayList();
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