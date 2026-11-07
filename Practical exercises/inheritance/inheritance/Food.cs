using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    public class Food : Product
    {
        public override int CalculateDiscount()
        {
            if (soldCount_ >= 5 && soldCount_ < 10)
            {
                return 15;
            }
            else if (soldCount_ >= 10)
            {
                return 25;
            }else return base.CalculateDiscount();

        }
    }
}
