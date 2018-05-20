using System;
using System.Collections.Generic;
using System.Text;

namespace TariffCompare.constants
{
    public class AppConstants
    {
        // PRODUCT A Constants
        public const int PRODUCT_A_BASE_TARIFF_PER_MONTH = 5;
        public const int MONTHS_PER_YEAR = 12;
        public const double PRODUCT_A_COST_PER_kWh = 0.22;   // 22 cents
        public const int PRODUCT_A_BASE_TARIFF_PER_YEAR = PRODUCT_A_BASE_TARIFF_PER_MONTH * MONTHS_PER_YEAR;

        // PRODUCT B Constants
        public const int PRODUCT_B_BASE_TARIFF = 800;
        public const int PRODUCT_B_FLAT_USAGE_POLICY = 4000;
        public const double PRODUCT_B_COST_PER_kWh = 0.3;
    }
}
