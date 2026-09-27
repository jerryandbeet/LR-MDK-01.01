using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Practik2
{
    class Program
    {
       static void resizeArray (ref int[] array, int newSize)
        {
            int[] newArray = new int[newSize];
            for (int i  = 0; i < array.Length && i < newArray.Length; i++)
            {
                newArray [i] = array[i];
            }
            array = newArray;
        }

        static void ArrayAddElementIndex (ref int[] array, int valueElement, int indexElement)
        {
            int[] newArray = new int[array.Length+1];
            for (int i = 0,j=0; i < newArray.Length; i++)
            {
                if (i!=indexElement)
                {
                    newArray[i]=array[j];
                    j++;
                } else newArray[i] = valueElement;
            }
            array = newArray;
        }
        //static void deleteFirstElementArray(ref int[]array)
        //{
        //   List <int> temp = new List <int>();
        //    for (int i = 1; i < array.Length; i++) temp.Add(array[i]);
        //    array = new int[temp.Count]; 
        //    for (int i = 0,j = 0;i<array.Length;i++,j++) array[i] = temp[j];
        //}

        //static void deleteLastElementArray(ref int[] array)
        //{
        //    List<int> temp = new List<int>();
        //    for (int i = 0; i < array.Length-1; i++) temp.Add(array[i]);
        //    array = new int[temp.Count];
        //    for (int i = 0, j = 0; i < array.Length; i++, j++) array[i] = temp[j];
        //}
        //static void deleteElementArray(ref int[] array, int indexElement)
        //{
        //    List<int> temp = new List<int>();
        //    foreach (int num in array) temp.Add(num);
        //    array = new int[temp.Count-1];
        //    for (int i = 0, j = 0; i < array.Length; j++)
        //    {
        //        if (j != indexElement)
        //        {
        //            array[i] = temp[j];
        //            i++;
        //        }
                
        //    }
                
        //}

        static void Main(string[] args)
        {
           int[] array = new int[10] {1,2,3,4,5,6,7,8,9,10};
            foreach (int num in array) Console.WriteLine(num);
            ArrayAddElementIndex(ref array, 111,9);
            foreach (int num in array) Console.WriteLine(num);
            //foreach (int num in array) Console.WriteLine(num);
            //Console.WriteLine();
            //deleteFirstElementArray(ref array);
            //foreach (int num in array) Console.WriteLine(num);
            //Console.WriteLine();
            //deleteLastElementArray(ref array);
            //foreach (int num in array) Console.WriteLine(num);
            //Console.WriteLine();
            //deleteElementArray(ref array, (array.Length-1));
            //foreach (int num in array) Console.WriteLine(num);
            //Console.WriteLine();

            //foreach (int num in array) Console.WriteLine(num);
            //Console.WriteLine();
            //Console.WriteLine("Введите значение для вставки в качестве первого элемента массива: ");
            //addFirstElementArray(ref array, Convert.ToInt32(Console.ReadLine()));
            //foreach (int num in array) Console.WriteLine(num);
            //Console.WriteLine();
            //Console.WriteLine("Введите значение для вставки в качестве последнего элемента массива: ");
            //addLastElementArray(ref array, Convert.ToInt32(Console.ReadLine()));
            //foreach (int num in array) Console.WriteLine(num);

            //Console.WriteLine();
            //Console.WriteLine("Введите индекс в массиве, куда желаете вставить значения: ");
            //int index = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Введите значение для вставки в ячейку [{index}]: ");
            //int value = Convert.ToInt32(Console.ReadLine());
            //insertElementArray(ref array, value,index);
            //foreach (int num in array) Console.WriteLine(num);



        }
    }
}
