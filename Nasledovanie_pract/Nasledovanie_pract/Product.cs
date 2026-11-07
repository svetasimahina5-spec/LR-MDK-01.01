using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasledovanie_pract
{
    public class Product
    {
        protected string name_;
        protected int price_;
        protected int count_;
    

        public void SetName(string name)
        {
            name_ = name;
        }

        public void SetPrice(int price)
        {
            price_ = price;
        }

        public void SetCount(int count)
        {
            count_ = count;
        }

        public string GetName()
        {
            return name_;
        }

        public int GetPrice()
        {
            return price_;
        }

        public int GetCount()
        {
            return count_;
        }

        public virtual double CalculeteDiscont()
        {
            return 0;
        }
    }
     
}
