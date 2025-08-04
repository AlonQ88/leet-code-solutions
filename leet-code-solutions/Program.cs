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
        Console.WriteLine(new string('-', 40));

        int[] nums2 = { 3, 2, 4 };
        int target2 = 6;
        Console.WriteLine("TwoSum: " + string.Join(", ", twoSum.TwoSum(nums2, target2))); // Output: 1, 2
        Console.WriteLine(new string('-', 40));

        int[] nums3 = { 3, 3 };
        int target3 = 6;
        Console.WriteLine("TwoSum: " + string.Join(", ", twoSum.TwoSum(nums3, target3))); // Output: 0, 1
        Console.WriteLine(new string('-', 40));

        // LongestCommonPrefixSolution Test
        var lcp = new LongestCommonPrefixSolution();
        string[] strs1 = { "flower", "flow", "flight" };
        Console.WriteLine("LongestCommonPrefix: " + lcp.LongestCommonPrefix(strs1)); // Output: "fl"
        Console.WriteLine(new string('-', 40));

        string[] strs2 = { "dog", "racecar", "car" };
        Console.WriteLine("LongestCommonPrefix: " + lcp.LongestCommonPrefix(strs2)); // Output: ""
        Console.WriteLine(new string('-', 40));

        // SumOfDigitsSolution Test
        var sumDigits = new SumOfDigitsSolution();
        int n1 = 12345;
        Console.WriteLine($"SumOfDigits({n1}): {sumDigits.SumOfDigits(n1)}"); // Output: 15
        Console.WriteLine(new string('-', 40));

        int n2 = 0;
        Console.WriteLine($"SumOfDigits({n2}): {sumDigits.SumOfDigits(n2)}"); // Output: 0
        Console.WriteLine(new string('-', 40));

        // PalindromeSolution Test
        var palindrome = new PalindromeSolution();
        string[] testStrings = { "racecar", "level", "hello", "a", "", "abccba", "abc", null };
        foreach (var test in testStrings)
        {
            Console.WriteLine($"Is \"{test}\" a palindrome? {palindrome.IsPalindrome(test)}");
        }
        Console.WriteLine(new string('-', 40));

        // ValidParenthesisSolution Test
        var validParenthesis = new ValidParenthesisSolution();
        string[] testParentheses = { "()", "()[]{}", "(]", "([])", "([)]", "{[()]}", "{[()()]}", "((()))", "((())", "(()))" };
        foreach (var test in testParentheses)
        {
            Console.WriteLine($"Is \"{test}\" valid? {validParenthesis.IsValidParenthesis(test)}");
        }
        Console.WriteLine(new string('-', 40));

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
        Console.WriteLine(new string('-', 40));

        // RemoveDuplicatesSolution Test
        var removeDuplicates = new RemoveDuplicatesSolution();

        int[] numsRD1 = { 1, 1, 2 };
        int k1 = removeDuplicates.RemoveDuplicates(numsRD1);
        Console.WriteLine($"RemoveDuplicates: k = {k1}, nums = [{string.Join(", ", numsRD1[..k1])}]"); // Output: k = 2, nums = [1, 2]
        Console.WriteLine(new string('-', 40));

        int[] numsRD2 = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
        int k2 = removeDuplicates.RemoveDuplicates(numsRD2);
        Console.WriteLine($"RemoveDuplicates: k = {k2}, nums = [{string.Join(", ", numsRD2[..k2])}]"); // Output: k = 5, nums = [0, 1, 2, 3, 4]
        Console.WriteLine(new string('-', 40));

        Console.ReadLine();
    }
}