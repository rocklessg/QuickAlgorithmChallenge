using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmChallenge
{
    public static class ChallengeSolution
    {
        public static List<int> TwoNumbersFromAnArraySumUptoEqualTargetNumber(List<int> array, int target)
        {
            List<int> result = new List<int>();

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
