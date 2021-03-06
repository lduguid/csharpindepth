﻿using System.Collections.Generic;

namespace Product
{
    internal class ProductNameComparerV2 : IComparer<ProductStuffV2>
    {
        public int Compare(ProductStuffV2 x, ProductStuffV2 y)
        {
            // return first.Name.CompareTo(second.Name);
            return string.CompareOrdinal(x.Name, y.Name);
        }
    }
}
