

namespace Product
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            foreach (ProductStuff item in ProductStuff.GetSampleProducts())
            {
                System.Console.WriteLine(item);
            }
        }
    }
}