using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practik3
{
    internal class SaveResults
    {
        public static void Save(int[]array, int num, Dictionary<string,double[]> results)
        {
            double[] times = Benchmark.Result(array, num);
            results.Add($"array [{array.Length}] elements", times);
        }
    }
}
