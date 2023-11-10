namespace LeetCode75;

public class KidsWithCandies

{
    public static IList<bool> Solve(int[] candies, int extraCandies)
    {
        int max = candies.Max();
        return candies.Select(t => t + extraCandies >= max).ToList();
    }
}