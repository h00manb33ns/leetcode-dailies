Solution solution = new Solution();
Console.WriteLine(solution.LongestPalindrome("aacabdkacaa"));
int[] twoSum = solution.TwoSum(new[] {3,4,52,1,23,4,7, 3}, 6);
Console.WriteLine(string.Join(",", twoSum));


public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int count = nums.Count();
        for (int i = 0; i < count; i++)
        {
            for (int j = i + 1; j < count; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new[] { i, j };
                }
            }
        }
        return null;
    }

    public string LongestPalindrome(string s)
    {
        char[] chars = s.ToCharArray();
        string palindrome = "";
        string checkPalindrome = "";
        string truePalindrome = "";
        for (int i = 0; i < s.Length; i++)
        {
            for(int j = i; j < s.Length; j++)
            {
                if(chars[i] == chars[j])
                {
                    if (truePalindrome.Length < s.Substring(i, j - i + 1).Length)
                    {
                        palindrome = s.Substring(i, j - i + 1);
                        char[] charArray = palindrome.ToCharArray();
                        Array.Reverse(charArray);
                        checkPalindrome = new string(charArray);
                        if (checkPalindrome == palindrome)
                            truePalindrome = palindrome;
                    }
                }
            }
            
        }
        return truePalindrome;
    }
}

