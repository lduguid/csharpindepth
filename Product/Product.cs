using System.Collections.Generic;

namespace Product
{
    internal class ProductStuff
    {
        /// <summary>
        /// C# 4 version from c# indepth
        /// 
        /// Problems with c# version 3.
        /// 
        /// Named arguements for clear initialization code (C# 4)
        /// The benefits of specifying the argument names explicilty are
        /// relatively minimal in this particular example, but when a method
        /// or constructor has several parameters, it can make the meaning
        /// of the code much clearer - particularly if they're of the same
        /// type, or if you are passing in null for some arguements. You can
        /// choose when to use this feature, of course, only specifying 
        /// the names for arguments when it makes the code easier to understand.
        /// 
        /// </summary>
        private readonly string name;
        private readonly decimal price;

        private ProductStuff(string name, decimal price)
        {
            this.name = name;
            this.price = price;
        }

        private string Name
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

        public static List<ProductStuff> GetSampleProducts()
        {
            return new List<ProductStuff> 
            { 
                new ProductStuff(name: "West Side Story", price: 9.99m), 
                new ProductStuff(name: "Assassins", price: 4.99m), 
                new ProductStuff(name: "Frogs", price: 13.99m), 
                new ProductStuff(name: "Sweeny Todd", price: 10.99m) 
            };
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}", this.Name, this.Price);
        }
    }
}