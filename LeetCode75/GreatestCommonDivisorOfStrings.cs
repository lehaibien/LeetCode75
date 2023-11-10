using System.Numerics;

namespace LeetCode75;

public static class GreatestCommonDivisorOfStrings
{
    public static string Solve(string str1, string str2)
    {
        return str1 + str2 == str2 + str1 ? str1[..Gcd(str1.Length, str2.Length)] : "";
    }

    private static int Gcd(int num1, int num2)
    {
        while (num2 != 0)
        {
            int temp = num1 % num2;
            num1 = num2;
            num2 = temp;
        }

        return num1;
    }
}