using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practik3
{
    internal class MethodsForeach
    {
        public static bool LinearSearch(int[] array,int num)
        {
            
            foreach(int number in array)
            {
                if (number == num) return true;
            }
            return false;
        }

        public static bool BinarySearch(int[] array, int num)
        {
            if(array.Length == 0) return false;
            int mid = array.Length/2;
            if (num == array[mid]) return true;
            else if (num < array[mid])
            {
                for (int i = 0; i < mid; i++) if (array[i] == num) return true;

            }
            else 
            {
                for (int i = mid + 1; i < array.Length; i++) if (array[i] == num) return true;
            }
            return false;
        }

        public static void ReadArray(int[] array)
        {
            foreach (int num in array) Console.WriteLine(num);
        }


        
    }
}
