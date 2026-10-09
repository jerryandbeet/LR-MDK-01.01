using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practik3
{
    internal class Arrays
    {
        private static void FillElements(int[]array)
        {
            Random random = new Random();
            for(int i = 0; i < array.Length; i++) array[i]=random.Next(0,1001);
        }
      

        public static void AddAndSortElements(int[] array)
        {
            
            FillElements(array);
            Array.Sort(array);
        }
        
    }
}
