public class Program
{
    public static void Main() { }

    /**
     * Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', 
     * determine if the input string is valid.
     * 
     * https://leetcode.com/problems/valid-parentheses/
     */
    public static bool IsValid(string s)
    {
        var validParenthesis = new Dictionary<char, char>()
        {
            { '(', ')' },
            { '{', '}' },
            { '[', ']' },
        };

        var stack = new Stack<char>();
        foreach (var parenthesis in s)
        {
            if (validParenthesis.ContainsKey(parenthesis))
            {
                stack.Push(parenthesis);
                continue;
            }

            if (!stack.TryPop(out char previousParenthesis))
            {
                return false;
            }

            if (!validParenthesis.TryGetValue(previousParenthesis, out char closingParenthesis))
            {
                return false;
            }

            if (!parenthesis.Equals(closingParenthesis))
            {
                return false;
            }
        }

        return !(stack.Count > 0);
    }

    /**
     * You are given an array prices where prices[i] is the price of a given stock on the ith day.
     * You want to maximize your profit by choosing a single day to buy one stock 
     * and choosing a different day in the future to sell that stock.
     * Return the maximum profit you can achieve from this transaction. 
     * If you cannot achieve any profit, return 0.
     * { 7, 3, 5, 1, 2, 6 }
     * https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
     */
    public static int MaxProfit(int[] prices)
    {
        int minPrice = int.MaxValue;
        int maxProfit = 0;

        for (int i = 0; i < prices.Length; ++i)
        {
            if (prices[i] < minPrice)
            {
                minPrice = prices[i];
            }
            else if (prices[i] - minPrice > maxProfit)
            {
                maxProfit = prices[i] - minPrice;
            }
        }

        return maxProfit;
    }

    /**
     * A phrase is a palindrome if, after converting all uppercase letters
     * into lowercase letters and removing all non-alphanumeric characters,
     * it reads the same forward and backward.
     * Alphanumeric characters include letters and numbers.
     * Given a string s, return true if it is a palindrome, or false otherwise.
     * "A man, a plan, a canal: Panama"
     * https://leetcode.com/problems/valid-palindrome/
     */
    public static bool IsPalindrome(string s)
    {
        if (s.Length <= 1)
        {
            return true;
        }

        int start = 0;
        int end = s.Length - 1;
        while(start <= end)
        {
            // if start or end are whitespace or non-alpha, move left/right.
            if (char.IsWhiteSpace(s[start]) || !char.IsLetterOrDigit(s[start]))
            {
                ++start;
            }
            else if ((char.IsWhiteSpace(s[end]) || !char.IsLetterOrDigit(s[end])))
            {
                --end;
            }
            else
            {
                // if we're in the middle, we're at the end of the word. return true
                if (start >= end)
                {
                    return true;
                }

                var left = char.ToLower(s[start]);
                var right = char.ToLower(s[end]);
                if (!left.Equals(right))
                {
                    return false;
                }
                ++start;
                --end;
            }
        }

        return true;
    }


    /**
     * Given an integer array nums, return true if any value appears at least twice in the array, 
     * and return false if every element is distinct.
     * 
     * https://leetcode.com/problems/contains-duplicate/
     */
    public static bool ContainsDuplicate(int[] nums)
    {
        var hashset = nums.ToHashSet();
        return hashset.Count != nums.Length ? true : false;
    }

    /**
     * Given an integer array nums and an integer k, return true if 
     * there are two distinct indices i and j in the array such that 
     * nums[i] == nums[j] and abs(i - j) <= k.
     * 
     * https://leetcode.com/problems/contains-duplicate-ii/
     */
    public static bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        var dict = new Dictionary<int, HashSet<int>>();
        for (var i = 0; i < nums.Length; ++i)
        {
            if (!dict.ContainsKey(nums[i]))
            {
                dict.Add(nums[i], new HashSet<int>() { i });
            }
            else
            {
                if (dict[nums[i]].Count > 0)
                {
                    foreach (var index in dict[nums[i]])
                    {
                        if (Math.Abs(i - index) <= k)
                        {
                            return true;
                        }
                    }

                }
                dict[nums[i]].Add(i);
            }
        }
        return false;
    }
}