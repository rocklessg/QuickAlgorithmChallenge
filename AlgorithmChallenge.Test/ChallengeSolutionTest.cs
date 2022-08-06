using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmChallenge.Test
{
    public class ChallengeSolutionTest
    {
        [Theory]
        [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 2, 7 })]
        [InlineData(new int[] { 16, 10, 7, 2 }, 9, new int[] { 7, 2 })]
        public void ChallengeSolution_ValidateAlgorithmResult_ReturnArrayOfExpectedNumbers(int[] array, int target, int[] result)
        {
            var act = ChallengeSolution.TwoNumbersFromAnArraySumUptoEqualTargetNumber(array.ToList(), target);
            Assert.Equal(result.ToList(), act);
        }
    }
}
