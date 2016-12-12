using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmicaDotNet.DP
{
    public static class MaxSubArray
    { 
        public static int GetMaxSubArray(int[] nums)
        {
            var count = nums.Length;
            int max;
            if (count == 1)
            {
                return nums[0];
            }
            if (count == 0)
            {
                return 0;
            } 
            max = nums[0];
            var sofar = nums[0]; 
            for (int i = 1; i < count; i++)
            {
                var current = nums[i];
                if (current < (sofar + current))
                {
                    sofar += current;
                }
                else
                {
                    sofar = current;
                }
              
                max = sofar > max ? sofar : max;
            }

            return max;

        }
    }
}
