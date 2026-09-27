    using System;
    using System.Collections.Generic;
    using System.ComponentModel.Design;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Practik3
    {
        internal class Program
        {
            static void Main(string[] args)
            {
               
                int num = 1;
                Dictionary<string, double[]> results = new Dictionary<string, double[]>();
                int[] arrayOne = new int[10];
                Arrays.AddAndSortElements(arrayOne);
                SaveResults.Save(arrayOne,num,results);
                int[] arrayTwo = new int[100];
                Arrays.AddAndSortElements(arrayTwo);
                SaveResults.Save(arrayTwo, num, results);
                int[] arrayTree = new int[1000];
                Arrays.AddAndSortElements(arrayTree);
                SaveResults.Save(arrayTree, num, results);
                int[] arrayFoo = new int[10000];
                Arrays.AddAndSortElements(arrayFoo);
                SaveResults.Save(arrayFoo, num, results);
                int[] arrayFive = new int[1000000];
                Arrays.AddAndSortElements(arrayFive);
                SaveResults.Save(arrayFive, num, results);
                foreach (var result in results)
                     {
                        Console.WriteLine($"{result.Key}: " +
                                      $"линейный поиск = {result.Value[0]:F4} мс, " +
                                      $"бинарный поиск = {result.Value[1]:F4} мс");
                     }
            }
        }
    }
