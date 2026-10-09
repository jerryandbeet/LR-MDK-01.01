using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumWork
{
    internal class CoffeeMachineDiagnostics
    {
        public BrewGroupState status = BrewGroupState.Standby;

        public static void PrintCommands()
        {
            string[] states = Enum.GetNames(typeof(BrewGroupState));
            Console.WriteLine("Доступные состояния кофемашины: ");
            foreach (string state in states) Console.WriteLine(state);
        }
        public static BrewGroupState SetState(string input)
        {
            bool inputState = Enum.TryParse(input, ignoreCase : true , out BrewGroupState newstate);
            if (inputState)
            {
                return newstate;
            } else
            return BrewGroupState.MechanismJammed;
        }
        public static void ExecuteCurrentState(CoffeeMachineDiagnostics coffeeMachine)
        {
            switch (coffeeMachine.status)
            {
                case BrewGroupState.Standby:
                    Console.WriteLine("Кофемашина в состоянии ожидания");
                    break;
                case BrewGroupState.WarmingUp:
                    Console.WriteLine("Кофемашина в состоянии нагрева термоблока");
                    break;
                case BrewGroupState.Grinding:
                    Console.WriteLine("Кофемашина в состоянии помола зерен");
                    break;
                case BrewGroupState.Brewing:
                    Console.WriteLine("Кофемашина в состоянии варки кофейка");
                    break;
                case BrewGroupState.Rinsing:
                    Console.WriteLine("Кофемашина в состоянии промывки системы");
                    break;
                case BrewGroupState.MechanismJammed:
                    Console.WriteLine("Кофемашина в состоянии заклинивания механизма");
                    break;
                default:
                    break;
            }
        }
    }
}
