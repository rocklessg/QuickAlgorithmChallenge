
namespace AlgorithmChallenge
{
    public static class TestGround
    {
        // input => ([2,3,3,4], 5)
        // output => [2, 3]

        public static List<int> TargetSum(List<int> numbers, int target)
        {
            // create a container list
            // pick the first index as comparer
            // iterate over the numbers (start from the second index)
            // sum the present index with the first index
            // compare the sum result with target
            // if sum match the target, add both numbers to container list
            // else shift the comparer to the next index and repeat the process
            // return container

            //1 create a container list
            var container = new List<int>();

            //2 pick the first index as comparer
            var comparer = numbers[0];

            //3 iterate over the numbers (start from the second index)
            for (int i = 1; i < numbers.Count; i++)
            {
                //4 sum the present index with the first index
                var sum = comparer + numbers[i];

                //5 compare the sum result with target
                if (sum == target)
                {
                    //6 if sum match the target, add both numbers to container list
                    container.Add(comparer);
                    container.Add(numbers[i]);
                    return container;
                }
                else
                {
                    //7 else shift the comparer to the next index and repeat the process
                    comparer = numbers[i];
                }
            }
            //8 return container
            return container;
        }

        public static List<int> FindPairWithSum(int[] arr, int target)
        {
            HashSet<int> seen = new ();

            foreach (int num in arr)
            {
                int complement = target - num;
                if (seen.Contains(complement))
                {
                    return new List<int> { complement, num };
                }
                seen.Add(num);
            }

            return new List<int>(); // Return an empty list if no pair is found
        }
    }
}
