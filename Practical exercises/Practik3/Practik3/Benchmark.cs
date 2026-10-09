using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practik3
{
    internal class Benchmark
    {
        private static double BinarySearchTime (int[]array,int num)
        {
            var stopwatch = Stopwatch.StartNew();
            bool resultOne = MethodsForeach.BinarySearch(array, num);
            stopwatch.Stop();
            return stopwatch.Elapsed.TotalMilliseconds;
        }

        private static double LinearSearchTime(int[] array, int num)
        {
            var stopwatch = Stopwatch.StartNew();
            bool resultOne = MethodsForeach.LinearSearch(array, num);
            stopwatch.Stop();
            return stopwatch.Elapsed.TotalMilliseconds;
        }

        public static double[] Result(int[] array, int num)
        {
            double[] results = new double[2];
            results[0] = BinarySearchTime(array, num);
            results[1] = LinearSearchTime(array, num);
            return results;
            
        }

    }
}
