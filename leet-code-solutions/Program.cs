using System;
using LeetCodeSolutions;

class Program
{
    static void Main()
    {
        // TwoSumSolution Test
        var twoSum = new TwoSumSolution();
        int[] nums1 = { 2, 7, 11, 15 };
        int target1 = 9;
        Console.WriteLine("TwoSum: " + string.Join(", ", twoSum.TwoSum(nums1, target1))); // Output: 0, 1

        int[] nums2 = { 3, 2, 4 };
        int target2 = 6;
        Console.WriteLine("TwoSum: " + string.Join(", ", twoSum.TwoSum(nums2, target2))); // Output: 1, 2

        int[] nums3 = { 3, 3 };
        int target3 = 6;
        Console.WriteLine("TwoSum: " + string.Join(", ", twoSum.TwoSum(nums3, target3))); // Output: 0, 1

        // LongestCommonPrefixSolution Test
        var lcp = new LongestCommonPrefixSolution();
        string[] strs1 = { "flower", "flow", "flight" };
        Console.WriteLine("LongestCommonPrefix: " + lcp.LongestCommonPrefix(strs1)); // Output: "fl"

        string[] strs2 = { "dog", "racecar", "car" };
        Console.WriteLine("LongestCommonPrefix: " + lcp.LongestCommonPrefix(strs2)); // Output: ""

        // SumOfDigitsSolution Test
        var sumDigits = new SumOfDigitsSolution();
        int n1 = 12345;
        Console.WriteLine($"SumOfDigits({n1}): {sumDigits.SumOfDigits(n1)}"); // Output: 15

        int n2 = 0;
        Console.WriteLine($"SumOfDigits({n2}): {sumDigits.SumOfDigits(n2)}"); // Output: 0

        // PalindromeSolution Test
        var palindrome = new PalindromeSolution();
        string[] testStrings = { "racecar", "level", "hello", "a", "", "abccba", "abc", null };
        foreach (var test in testStrings)
        {
            Console.WriteLine($"Is \"{test}\" a palindrome? {palindrome.IsPalindrome(test)}");
        }

        // ValidParenthesisSolution Test
        var validParenthesis = new ValidParenthesisSolution();
        string[] testParentheses = { "()", "()[]{}", "(]", "([])", "([)]", "{[()]}", "{[()()]}", "((()))", "((())", "(()))" };
        foreach (var test in testParentheses)
        {
            Console.WriteLine($"Is \"{test}\" valid? {validParenthesis.IsValidParenthesis(test)}");
        }

        // MergeTwoListsSolution Test
        var mergeLists = new MergeTwoListsSolution();
        var l1 = new ListNode(1, new ListNode(2, new ListNode(4)));
        var l2 = new ListNode(1, new ListNode(3, new ListNode(4)));
        var merged = mergeLists.MergeTwoLists(l1, l2);
        Console.Write("Merged List: ");
        while (merged != null)
        {
            Console.Write(merged.val + " ");
            merged = merged.next;
        }
        Console.WriteLine();
    }
}