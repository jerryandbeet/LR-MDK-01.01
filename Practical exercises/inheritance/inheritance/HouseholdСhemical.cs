using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    public class HouseholdСhemical : Product
    {
        public override int CalculateDiscount()
        {
            if (soldCount_ >= 20 && soldCount_ < 150)
            {
                return 10;
            }
            else if (soldCount_ >= 150 && soldCount_ < 300)
            {
                return 30;
            }
            else
            if (soldCount_ >= 300)
            {
                return 50;
            }
            else return base.CalculateDiscount();
            
        }
    }
}
