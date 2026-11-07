using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    public class Product
    {
        protected string name_;
        protected decimal price_;
        protected int soldCount_;
        
        public string GetName()
        {
            return name_;
        }
        public void SetName(string name_)
        {
            this.name_ = name_;
        }
        public decimal GetPrice()
        {
            return price_;
        }
        public void SetPrice(decimal price_)
        {
            this.price_ = price_;
        }
        public int GetSoldCount()
        {
            return soldCount_;
        }
        public void SetSoldCount(int soldCount_)
        {
            this.soldCount_ = soldCount_;
        }
        public virtual int CalculateDiscount()
        {
            return 0;
        }
    }
}
