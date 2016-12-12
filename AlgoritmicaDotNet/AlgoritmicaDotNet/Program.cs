using AlgoritmicaDotNet.DP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmicaDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MaxSubArrayOf: {3,1,-2,-3,-1,3,2,-2,-1}");
            int[] array = new int[9] { 3, 1, -2, -3, -1, 3, 2, -2, -1 };
            var maxSubArray = MaxSubArray.GetMaxSubArray(array);
            Console.WriteLine(maxSubArray);
            Console.ReadLine();
        }
    }
}
