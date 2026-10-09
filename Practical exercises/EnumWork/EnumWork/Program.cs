using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CoffeeMachineDiagnostics m1 = new CoffeeMachineDiagnostics();
            string status = "";
            CoffeeMachineDiagnostics.ExecuteCurrentState(m1);
            while (true)
            {

                CoffeeMachineDiagnostics.PrintCommands();
                Console.WriteLine("Введите новое состояние (exit - для выхода из программы): ");
                
                status = Console.ReadLine();
                if (status.ToLower() == "exit") break;
                else
                m1.status = CoffeeMachineDiagnostics.SetState(status);
                CoffeeMachineDiagnostics.ExecuteCurrentState(m1);



            }
        }
    }
}
