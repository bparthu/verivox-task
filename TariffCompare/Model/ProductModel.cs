using System;
using System.Collections.Generic;
using System.Text;

namespace TariffCompare
{
    public abstract class ProductModel
    {
        protected string name { get; set; }
        protected double annualTariff { get; set; }
    }
}
