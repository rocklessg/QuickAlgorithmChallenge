// See https://aka.ms/new-console-template for more information
using AlgorithmChallenge;

Console.WriteLine("Hello, Supervisor!");

var result = ChallengeSolution.TwoNumbersFromAnArraySumUptoEqualTargetNumber(new List<int> { 15, 11, 7, 2, 9 }, 9);
foreach (var item in result)
{
    Console.Write(item + " ");
}
