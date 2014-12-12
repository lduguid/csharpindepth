using System.Collections.Generic;

namespace Product
{
    internal class ProductStuff
    {
        /// <summary>
        /// 
        /// C# 3 version from c# indepth
        /// 
        /// Problems with c# version 2.
        /// 
        /// Automatically implemented properties and simpler initialization
        /// Now the properties do not have any code (or visible variables!)
        /// associated with them, and you are building the hardcoded list
        /// in a very different way. With no name and price variables to
        /// access, you are forced to use the properties everywhere in the 
        /// class, improving consistency. You now have a private parameterless
        /// constructor for the sake of the new property-based initialization.
        /// The constructor is called for each item before the properties are
        /// set.
        /// 
        /// </summary>
        public ProductStuff()
        {
        }

        public string Name { get; private set; }

        public decimal Price { get; private set; }

        public static List<ProductStuff> GetSampleProducts()
        {
            return new List<ProductStuff>
                   {
                       new ProductStuff { Name = "West Side Story", Price = 9.99m }, 
                       new ProductStuff { Name = "Assassins", Price = 4.99m }, 
                       new ProductStuff { Name = "Frogs", Price = 13.99m }, 
                       new ProductStuff { Name = "Sweeny Todd", Price = 10.99m }
                   };
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}", this.Name, this.Price);
        }
    }
}