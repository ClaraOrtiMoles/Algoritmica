using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmicaDotNet.Backtracking
{
    public static class Subsets
    {
        public static IList<IList<int>> SubsetsWithDup(int[] nums)
        {

            List<IList<int>> result = new List<IList<int>>();
            var orderedNums = nums.OrderBy(x => x).ToArray<int>();
            var queueAux = new Queue<int>();
            subsetsWithDup(result, queueAux, orderedNums, 0);
            return result;

        }
        private static void subsetsWithDup(List<IList<int>> result, Queue<int> queueAux, int[] nums, int begin)
        {
            result.Add(queueAux.ToList());
            var r = result[2];
            for (int i = begin; i != nums.Length; i++)
            {
                if (i == begin || nums[i] != nums[i - 1])
                {
                    queueAux.Enqueue(nums[i]);
                    subsetsWithDup(result, queueAux, nums, i + 1);
                    queueAux.Dequeue();
                }
            }
        }
    }
}
