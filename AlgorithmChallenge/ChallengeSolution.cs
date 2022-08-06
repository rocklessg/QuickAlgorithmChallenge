using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmChallenge
{
    public static class ChallengeSolution
    {
        /// <summary>
        /// Please Check Repo ReadMe for the code flow explanation summary.
        /// Thank you
        /// </summary>
        /// <param name="array"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static List<int> TwoNumbersFromAnArraySumUptoEqualTargetNumber(List<int> array, int target)
        {
            List<int> result = new();

            for (int i = 0; i < array.Count; i++)
            {
                var targetCheck = target - array[i];

                if (array.Contains(targetCheck) && targetCheck + array[i] == target)
                {
                    result.Add(array[i]);
                    result.Add(targetCheck);
                    break;
                }
            }
            return result;
        }
    }
}
