using BenchmarkDotNet.Attributes;

namespace AlgorithmChallenge
{
    [MemoryDiagnoser]
    public class For_Loop_Recursion_Benchmark
    {
        private int y = 0;

        [GlobalSetup]
        public void Setup()
        {
            y = 20;
        }

        private int Factorial(int x)
        {
            if (x == 0) return 1;
            return x * Factorial(x - 1);
        }

        [Benchmark]
        public void Factorial_With_Recursion()
        {
            Factorial(y);
        }


        [Benchmark]
        public int Factorial_With_For_Loop()
        {
            if (y == 0) return 1;

            int total = 1;
            for (int i = 1; i <= y; i++)
            {
                total *= i;
            }
            return total;
        }
    }
}
