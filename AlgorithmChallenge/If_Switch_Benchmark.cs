using BenchmarkDotNet.Attributes;

namespace AlgorithmChallenge
{
    [MemoryDiagnoser]
    public class If_Switch_Benchmark
    {
        private int[] my_list = new int[] {};


        [GlobalSetup]
        public void Setup()
        {
            my_list = new[] { 1, 2, 3, 4, 5, 10, 20, 30, 50, 50, 60, 70, 80, 90, 100 };
        }

        [Benchmark]
        public int Compute_Total_Sum_With_If()
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

        [Benchmark]
        public int Compute_Total_Sum_With_Switch()
        {
            int total = 0;

            for (int i = 0; i < my_list.Length; i++)
            {
                total += i switch
                {
                    0 => my_list[i],
                    _ when i % 2 == 0 => my_list[i],
                    _ when i % 2 == 1 => -my_list[i],
                    _ => 0
                };
            }
            return total;
        }
    }
}
