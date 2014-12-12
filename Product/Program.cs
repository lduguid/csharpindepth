

namespace Product
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            // c# version 1
            foreach (ProductStuffV1 item in ProductStuffV1.GetSampleProducts())
            {
                System.Console.WriteLine(item);
            }

            System.Console.WriteLine();

            // c# version 2
            foreach (ProductStuffV2 item in ProductStuffV2.GetSampleProducts())
            {
                System.Console.WriteLine(item);
            }

            System.Console.WriteLine();

            // c# version 3
            foreach (ProductStuffV3 item in ProductStuffV3.GetSampleProducts())
            {
                System.Console.WriteLine(item);
            }

        }
    }
}
