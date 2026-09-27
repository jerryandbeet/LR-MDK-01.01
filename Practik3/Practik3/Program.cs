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
            static bool foreachement(int[] array, int num)
            {
                bool result = false;
                foreach (int number in array)
                {
                    if (number == num) result = true;
                }
                return result;

            }

            static bool foreachementBinary(int[] array, int num)
            {
                bool result = false;
                if (array.Length > 0)
                {
                    if (num >= array[array.Length / 2])
                    {
                        for (int i = array.Length / 2 - 1; i < array.Length; i++)
                        {
                            if (array[i] == num) result = true;
                        }
                    }
                    else
                    {
                        for (int i = 0; i < array.Length / 2; i++)
                        {
                            if (array[i] == num) result = true;
                        }
                    }
                    return result;
                }
                else return result;

            }





            static void ForeachArray(int[] array)
            {
                foreach (int num in array) Console.WriteLine(num);
            }
            static void Main(string[] args)
            {
                Random rand = new Random();
                int num = 1;
                Dictionary<string, double[]> timeArrays = new Dictionary<string, double[]>();


                int[] arrayOne = new int[10];
                for (int i = 0; i < arrayOne.Length; i++)
                {
                    arrayOne[i] = rand.Next(0, 10000);
                }
                Array.Sort(arrayOne);

                var stopwatchOne = Stopwatch.StartNew();
                bool resultOne = foreachement(arrayOne, num);
                stopwatchOne.Stop();
                var stopwatchTwo = Stopwatch.StartNew();
                bool resultTwo = foreachementBinary(arrayOne, num);
                stopwatchTwo.Stop();

                double[] mass = new double[2];
                mass[0] = stopwatchOne.Elapsed.TotalMilliseconds;
                mass[1] = stopwatchTwo.Elapsed.TotalMilliseconds;
                timeArrays.Add($"array {arrayOne.Length} elements", mass);



                int[] arrayTwo = new int[100];
                for (int i = 0; i < arrayTwo.Length; i++)
                {
                    arrayTwo[i] = rand.Next(0, 9999);
                }
                Array.Sort(arrayTwo);

                stopwatchOne = Stopwatch.StartNew();
                resultOne = foreachement(arrayTwo, num);
                stopwatchOne.Stop();
                stopwatchTwo = Stopwatch.StartNew();
                resultTwo = foreachementBinary(arrayTwo, num);
                stopwatchTwo.Stop();

                mass[0] = stopwatchOne.Elapsed.TotalMilliseconds;
                mass[1] = stopwatchTwo.Elapsed.TotalMilliseconds;
                timeArrays.Add($"array {arrayTwo.Length} elements", mass);



                int[] arrayTree = new int[1000];
                for (int i = 0; i < arrayTree.Length; i++)
                {
                    arrayTree[i] = rand.Next(0, 9999);
                }
                Array.Sort(arrayTree);

                stopwatchOne = Stopwatch.StartNew();
                resultOne = foreachement(arrayTree, num);
                stopwatchOne.Stop();
                stopwatchTwo = Stopwatch.StartNew();
                resultTwo = foreachementBinary(arrayTree, num);
                stopwatchTwo.Stop();

                mass[0] = stopwatchOne.Elapsed.TotalMilliseconds;
                mass[1] = stopwatchTwo.Elapsed.TotalMilliseconds;
                timeArrays.Add($"array {arrayTree.Length} elements", mass);



                int[] arrayFoo = new int[10000];
                for (int i = 0; i < arrayFoo.Length; i++)
                {
                    arrayFoo[i] = rand.Next(0, 9999);
                }
                Array.Sort(arrayFoo);

                stopwatchOne = Stopwatch.StartNew();
                resultOne = foreachement(arrayFoo, num);
                stopwatchOne.Stop();
                stopwatchTwo = Stopwatch.StartNew();
                resultTwo = foreachementBinary(arrayFoo, num);
                stopwatchTwo.Stop();

                mass[0] = stopwatchOne.Elapsed.TotalMilliseconds;
                mass[1] = stopwatchTwo.Elapsed.TotalMilliseconds;
                timeArrays.Add($"array {arrayFoo.Length} elements", mass);



                int[] arrayFive = new int[1000000];
                for (int i = 0; i < arrayFive.Length; i++)
                {
                    arrayFive[i] = rand.Next(0, 9999);
                }
                Array.Sort(arrayFive);

                stopwatchOne = Stopwatch.StartNew();
                resultOne = foreachement(arrayFive, num);
                stopwatchOne.Stop();
                stopwatchTwo = Stopwatch.StartNew();
                resultTwo = foreachementBinary(arrayFive, num);
                stopwatchTwo.Stop();

                mass[0] = stopwatchOne.Elapsed.TotalMilliseconds;
                mass[1] = stopwatchTwo.Elapsed.TotalMilliseconds;
                timeArrays.Add($"array {arrayFive.Length} elements", mass);

                foreach (var result in timeArrays)
                {
                    Console.WriteLine($"{result.Key}: " +
                                      $"линейный поиск = {result.Value[0]:F4} мс, " +
                                      $"бинарный поиск = {result.Value[1]:F4} мс");
                }










                //int[] array = new int[10000];
                //Random rand = new Random();
                //for (int i = 0;i<array.Length;i++)
                //{
                //    array[i] = rand.Next(0,100001);
                //}


                //var stopwatch = Stopwatch.StartNew(); 

                //// Код, время выполнения которого нужно измерить
                //ForeachArray(array);

                //stopwatch.Stop();

                //Console.WriteLine($"Время выполнения: {stopwatch.ElapsedMilliseconds} мс");

                //var stopwatchOne = Stopwatch.StartNew();
                //bool resultOne = foreachement(array, num);
                //Console.WriteLine(resultOne);
                //stopwatchOne.Stop();
                //Console.WriteLine($"Время выполнения (поэлементный поиск): {stopwatchOne.ElapsedMilliseconds} мс");

                //var stopwatchTwo = Stopwatch.StartNew();
                //bool resultTwo = foreachementBinary(array, num);
                //Console.WriteLine(resultTwo);
                //stopwatchTwo.Stop();
                //Console.WriteLine($"Время выполнения (бинарный поиск): {stopwatchTwo.ElapsedMilliseconds} мс");


            }
        }
    }
