using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class BudgetData
    {
        public static string[] names_ = new string[0];
        public static decimal[] limits_ = new decimal[0];
        public static decimal[]spent_ = new decimal[0];

        public static void Init()
        {
            int n = 5;
            names_ = new string[n];
            limits_ = new decimal[n];
            spent_ = new decimal[n];

            names_[(int)CategoryIndex.products_] = "продукты";
            limits_[(int)CategoryIndex.products_] = 20000m;
            spent_[(int)CategoryIndex.products_] = 6500m;

            names_[(int)CategoryIndex.transport_] = "транспорт";
            limits_[(int)CategoryIndex.transport_] = 8000m;
            spent_[(int)CategoryIndex.transport_] = 3200m;

            names_[(int)CategoryIndex.housing_] = "жильё";
            limits_[(int)CategoryIndex.housing_] = 40000m;
            spent_[(int)CategoryIndex.housing_] = 25000m;

            names_[(int)CategoryIndex.entertainment_] = "развлечения";
            limits_[(int)CategoryIndex.entertainment_] = 12000m;
            spent_[(int)CategoryIndex.entertainment_] = 4000m;

            names_[(int)CategoryIndex.clothing_] = "одежда";
            limits_[(int)CategoryIndex.clothing_] = 15000m;
            spent_[(int)CategoryIndex.clothing_] = 9500m;
        }

        public static int Count => names_.Length;

        public static decimal Remaining(int i) => limits_[i] - spent_[i];
    }
}
