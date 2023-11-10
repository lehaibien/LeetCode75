// See https://aka.ms/new-console-template for more information

using LeetCode75;

Console.WriteLine("Hello, World!");

string mergeStringsAlternately = MergeStringsAlternately.Solve("abc", "pqr");
Console.WriteLine("Merge String Alternately: " + mergeStringsAlternately);

string gcdOfStrings = GreatestCommonDivisorOfStrings.Solve("ABCABC", "ABC");
Console.WriteLine("Greatest Common Divisor Of Strings: " + gcdOfStrings);

var kidsWithCandies = KidsWithCandies.Solve(new []{2,3,5,1,3}, 3);
Console.WriteLine($"[{string.Join(", ", kidsWithCandies)}]");