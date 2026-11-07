using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasledovanie_pract
{
    public class Drinks : Product
    {
        public override double CalculeteDiscont()
        {
            if (count_ >= 20 && count_ < 150)
            {
                return 10;
            }
            else if (count_ >= 150 && count_ < 300)
            {
                return 30;
            }
            else if (count_ >=300)
            {
                return 50;
            }

        }
    }
}
