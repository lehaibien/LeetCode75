using System.Text;

namespace LeetCode75;

public static class MergeStringsAlternately
{
    public static string Solve(string word1, string word2)
    {
        StringBuilder builder = new StringBuilder();
        int w1Length = word1.Length;
        int w2Length = word2.Length;
        int max = w1Length > w2Length ? w1Length : w2Length;
        for (int i = 0; i < max; i++)
        {
            if (w1Length > i)
            {
                builder.Append(word1[i]);
            }

            if (w2Length > i)
            {
                builder.Append(word2[i]);
            }
        }

        return builder.ToString();
    }
}