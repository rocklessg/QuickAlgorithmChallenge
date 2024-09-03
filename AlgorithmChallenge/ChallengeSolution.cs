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

        public static int RunningTotalSum(int[] my_list)
        {
            int total = 0;

            for (int i = 0; i < my_list.Length; i++)
            {
                if (i == 0)
                {
                    total += my_list[i];
                }
                else if (i % 2 == 0)
                {
                    total += my_list[i];
                }
                else if (i % 2 == 1)
                {
                    total -= my_list[i];
                }
            }
            return total;
        }
    }
}
