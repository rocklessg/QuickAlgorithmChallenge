// See https://aka.ms/new-console-template for more information
using AlgorithmChallenge;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;
using static System.Console;

//Console.WriteLine("Hello!");

//var result = ChallengeSolution.TwoNumbersFromAnArraySumUptoEqualTargetNumber(new List<int> { 2, 7, 11, 15 }, 9);
//foreach (var item in result)
//{
//    Console.Write(item + " ");
//}
//Console.WriteLine("\n");

//  BenchmarkDotNet.Artifacts\results\AlgorithmChallenge.Benchmarking-report.csv
//var summary = BenchmarkRunner.Run<Benchmarking>();

//  BenchmarkDotNet.Artifacts\results\AlgorithmChallenge.For_Loop_Recursion_Benchmark-report.csv
//var summary = BenchmarkRunner.Run<For_Loop_Recursion_Benchmark>();


var result = ChallengeSolution.RunningTotalSum(new int[] { 1, 2, 3 });
WriteLine(result);
//var result3 = Benchmarking.RunningTotalSumWithSwitch(new int[] { 1, 2, 3 });
//WriteLine(result3);
var result2 = ChallengeSolution.RunningTotalSum(new int[] { 80, 30, 30 });
WriteLine(result2);



//FileInputOutput.ReadFromFile();

char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
char lastElement = vowels[^4]; // 'u'
char secondToLast = vowels[^3]; // 'o'

//char[] firstTwo = vowels[..2]; // 'a', 'e'
char[] lastThree = vowels[2..]; // 'i', 'o', 'u'
char[] middleOne = vowels[2..3]; // 'i'
char[] lastTwo = vowels[^2..]; // 'o', 'u'

Index last = ^1;
Range firstTwoRange = 0..2;
char[] firstTwo = vowels[firstTwoRange]; // 'a', 'e'

//WriteLine(firstTwo);
//WriteLine(lastTwo);

#nullable enable // Enable nullable reference types from this point on
string s1 = null; // Generates a compiler warning! (s1 is non-nullable)
string? s2 = null; // OK: s2 is nullable reference type
Console.WriteLine(s2 + s1);


async IAsyncEnumerable<int> RangeAsync(int start, int count, int delay)
{
    for (int i = start; i < start + count; i++)
    {
        await Task.Delay(delay);
        yield return i;
    }
}

//await foreach (var number in RangeAsync(0, 10, 100))
//    WriteLine(number);

//WriteLine(million);

bool successful = int.TryParse("123d", out int results);
WriteLine(results);

var bob = ("Bob", 23);
//WriteLine(bob.Item1); // Bob
//WriteLine(bob.Item2); // 23

// int using = 123; // Illegal
int @using = 123; // Legal
int @myvar = 123; // @myvar is same as myvar

//WriteLine(myvar);

int x = 12345; // int is a 32-bit integer
long y = x; // Implicit conversion to 64-bit integer
short z = (short)x; // Explicit conversion to 16-bit integer

int i = 5;
System.Int32 ii = 5;

//Real literals can use decimal and/or exponential notation:
double d = 1.5;
double milion = 1E06;

WriteLine(1.0.GetType()); // Double (double)
//WriteLine(1E06.GetType()); // Double (double)
//WriteLine(1.GetType()); // Int32 (int)
//WriteLine(0xF0000000.GetType()); // UInt32 (uint)
//WriteLine(0x100000000.GetType()); // Int64 (long)

int a = 0, b = 0;
//WriteLine(a++); // Outputs 0; a is now 1 (a++ means give me the value of a then increment a)
//WriteLine(++b); // Outputs 1; b is now 1 (++b means increment b then give me the value)

int c = int.MinValue;
WriteLine(c);
c--;
WriteLine(c);

WriteLine(c == int.MaxValue); // True

static bool UseUmbrella(bool rainy, bool sunny, bool windy)
{
    return !windy && (rainy || sunny);
}

int total = Sum(1, 2, 3, 4);
WriteLine(total); // 10
                  // The call to Sum above is equivalent to:
_ = Sum(new int[] { 1, 2, 3, 4 });

int Sum(params int[] ints)
{
    int sum = 0;
    for (int i = 0; i < ints.Length; i++)
        sum += ints[i]; // Increase sum by ints[i]
    return sum;
}

void Foo(int y, int x = 23) // Optional parameter always comes last after all required paramenters
{ WriteLine(x +" "+ y); }

Foo(x: 1, y: 2); // 1, 2

Random r = new Random();
var e = r.Next();

x *= 2; // equivalent to x = x * 2
int m = 2;
m <<= 2; // equivalent to x = x << 1
WriteLine(m);

//stopped at pg 71 C# in a nut shell