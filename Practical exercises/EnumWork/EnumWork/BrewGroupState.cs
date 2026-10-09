using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumWork
{
    public enum BrewGroupState
    {
        Standby = 10,
        WarmingUp = 20, 
        Grinding = 30,
        Brewing = 40,
        Rinsing = 50,
        MechanismJammed = 99
    }
    
}
