

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
