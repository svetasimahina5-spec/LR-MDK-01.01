using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasledovanie_pract
{
   public class Food:Product
    {
        public override double CalculateDiscont()
        {
            if (count_ >= 5 && count_ < 10)
            {
                return 15;
            }
            else if (count_ >= 10)
            {
                return 25;
            }

            return 0;
        }
    }
}
