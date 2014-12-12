using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Product
{
    

    internal class Program
    {
        
        internal static void Main(string[] args)
        {
            foreach (ProductStuffV1 item in ProductStuffV1.GetSampleProducts())
            {
                System.Console.WriteLine(item);
            }
        }
    }

}
