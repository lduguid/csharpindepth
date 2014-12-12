using System.Collections;

namespace Product
{
    internal class ProductNameComparerV1 : IComparer
    {
        public int Compare(object x, object y)
        {
            ProductStuffV1 first = (ProductStuffV1)x;
            ProductStuffV1 second = (ProductStuffV1)y;
            return first.Name.CompareTo(second.Name);
        }
    }
}
