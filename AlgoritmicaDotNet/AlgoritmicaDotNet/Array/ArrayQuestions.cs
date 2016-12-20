using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmicaDotNet.Array
{
    public static class ArrayQuestions
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            var numElements = nums.Length;
            int[] result = new int[2];

            if (numElements == 2)
            {
                if ((nums[0] + nums[1]) == target)
                {
                    result[0] = nums[0];
                    result[1] = nums[1];
                }
            }
            else if (numElements > 2)
            {
                var founded = false;

                for (int i = 0; !founded && i < (nums.Length - 1); i++)
                {
                    var sumSofar = nums[i];
                    if ((i + 1) < nums.Length)
                    {
                        for (int j = i + 1; !founded && j < nums.Length; j++)
                        {
                            if (sumSofar + nums[j] == target)
                            {
                                founded = true;
                                result[1] = j;
                                result[0] = i;
                            }
                        }
                    }
                }
            }
            return result;
        }


        public static string GetRelativePath(string src, string dst)
        {
            var source = src.Split('/'); //->["usr", "a","b"]
            var destin = dst.Split('/'); // ->["usr","c"]

            string result = string.Empty;
            int aux = 0;
            bool founded = false;

            for (int i = 0; i < source.Length && !founded; i++)
            {
                if (i < destin.Length)
                {
                    if (source[i] != destin[i])
                    {
                        aux = i;
                        founded = true;
                    }

                }
            }

            for (int i = aux; i < source.Length; i++)
            {
                result = $"{ result}../";

            }
            result = $"{result}{destin[aux]}";
            return result;
        }
        
    }
}
