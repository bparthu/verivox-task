using System;
using System.Collections.Generic;
using System.Text;

namespace TariffCompare
{
    public abstract class ProductModel
    {
        public string Name { get; set; }
        public int AnnualUsage { get; set; }
    }
}
