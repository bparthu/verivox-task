using System;
using System.Collections.Generic;
using System.Text;

namespace TariffCompare.Service
{
    public interface ITariffService
    {
        int getProducts(int usage);
    }

    public class TariffService : ITariffService
    {
        public int getProducts(int usage)
        {
            throw new NotImplementedException();
        } 
    }
}
