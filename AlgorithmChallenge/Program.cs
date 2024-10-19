// See https://aka.ms/new-console-template for more information
using AlgorithmChallenge;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;
using System.Diagnostics.Metrics;
using static System.Console;

//Console.WriteLine("Hello!");

//var result = ChallengeSolution.TwoNumbersFromAnArraySumUptoEqualTargetNumber(new List<int> { 2, 7, 11, 15 }, 9);
//foreach (var item in result)
//{
//    Console.Write(item + " ");
//}
//Console.WriteLine("\n");

//  BenchmarkDotNet.Artifacts\results\AlgorithmChallenge.Benchmarking-report.csv
//var summary = BenchmarkRunner.Run<If_Switch_Benchmark>();

//  BenchmarkDotNet.Artifacts\results\AlgorithmChallenge.For_Loop_Recursion_Benchmark-report.csv
//var summary = BenchmarkRunner.Run<For_Loop_Recursion_Benchmark>();


//var result = ChallengeSolution.RunningTotalSum(new int[] { 1, 2, 3 });
//WriteLine(result);
//var result3 = Benchmarking.RunningTotalSumWithSwitch(new int[] { 1, 2, 3 });
//WriteLine(result3);
//var result2 = ChallengeSolution.RunningTotalSum(new int[] { 80, 30, 30 });
//WriteLine(result2);

var result = TestGround.TargetSum(new List<int>{ 2, 3, 3, 4 }, 6);
foreach (var item in result)
{
    WriteLine("Target sum result is {0}", item);
}




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
WriteLine($"This {s2 + s1}");


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

string someWord = "rosebud";
int someNumber = 42,
    anotherNumber = 43,
    chainNumbers = 44;
bool rich = true, famous = false;

const double f = 2.99792458E08;
//f += 10; // Compile-time error constant can not be changed after declaration

string v = new string('c', 3);
WriteLine(v);


TellMeTheType(12);
TellMeTheType("hello");
TellMeTheType(true);
TellMeTheType('c');
void TellMeTheType(object x) // object allows any type.
{
    switch (x)
    {
        case int i:
            Console.WriteLine("It's an int!");
            Console.WriteLine($"The square of {i} is {i * i}");
            break;
        case string s:
            Console.WriteLine("It's a string");
            Console.WriteLine($"The length of {s} is {s.Length}");
            break;
        case bool s:
            Console.WriteLine("It's a boolean");
            Console.WriteLine($"The value is {s}");
            break;
        default:
            Console.WriteLine("I don't know what x is");
            break;
    }
}

var cardNumber = 0;
string cardName = cardNumber switch
{
    13 => "King",
    12 => "Queen",
    11 => "Jack",
    _ => "Pip card" // equivalent to 'default'
};


// Fibunacci sequence
for (int j = 0, prevFib = 1, curFib = 1; j < 10; j++)
{
    Console.WriteLine(prevFib);
    int newFib = prevFib + curFib;
    prevFib = curFib;
    curFib = newFib;
}

int k = 1;
startLoop: //label
if (k <= 5)
{
    Console.Write(i + " ");
    k++;
    goto startLoop;
}

public class Note
{
    public int Pitch { get; init; } = 20; // "Init-only" property
    public int Duration { get; init; } = 100; // "Init-only" property

    public void InitMethod()
    {
        var note = new Note { Pitch = 50 };
        //note.Pitch = 200; // Error – init-only setter!
    }

    int count = 123;
    string name = nameof(count); // name is "count"

}





//stopped at pg 121 Abstract Classes and Abstract Members

// Async/await
//async Task MakeDinnerAsync()
//{
//    // Start boiling water asynchronously
//    Task boilWaterTask = BoilWaterAsync();

//    // While water is boiling, chop vegetables
//    ChopVegetables();

//    // Wait for the water to finish boiling
//    await boilWaterTask;

//    // Continue with the next step
//    CookPasta();
//}

//await MakeDinnerAsync();
//async Task BoilWaterAsync()
//{
//    Console.WriteLine("Boiling water...");
//    await Task.Delay(5000); // Simulate waiting for 5 seconds
//    Console.WriteLine("Water is ready!");
//}

//void ChopVegetables()
//{
//    Console.WriteLine("Chopping vegetables...");
//}

//void CookPasta()
//{
//    Console.WriteLine("Cook Pasta...");
//}
