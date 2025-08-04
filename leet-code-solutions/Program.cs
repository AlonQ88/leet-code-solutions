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

        // ReverseLinkedListSolution Test
        var reverseListSolution = new ReverseLinkedListSolution();

        // Helper to build a linked list from array
        ListNode BuildList(int[] values)
        {
            ListNode head = null;
            for (int i = values.Length - 1; i >= 0; i--)
            {
                head = new ListNode(values[i], head);
            }
            return head;
        }

        // Helper to print a linked list
        void PrintList(ListNode head)
        {
            while (head != null)
            {
                Console.Write(head.val);
                if (head.next != null) Console.Write(" -> ");
                head = head.next;
            }
            Console.WriteLine();
        }

        // Test 1: 1 -> 2 -> 3 -> null
        var list1 = BuildList(new[] { 1, 2, 3 });
        Console.Write("Original List: ");
        PrintList(list1);
        var reversed1 = reverseListSolution.ReverseList(list1);
        Console.Write("Reversed List: ");
        PrintList(reversed1);
        Console.WriteLine(new string('-', 40));

        // Test 2: 1 -> null
        var list2 = BuildList(new[] { 1 });
        Console.Write("Original List: ");
        PrintList(list2);
        var reversed2 = reverseListSolution.ReverseList(list2);
        Console.Write("Reversed List: ");
        PrintList(reversed2);
        Console.WriteLine(new string('-', 40));

        // Test 3: Empty list
        var list3 = BuildList(Array.Empty<int>());
        Console.Write("Original List: ");
        PrintList(list3);
        var reversed3 = reverseListSolution.ReverseList(list3);
        Console.Write("Reversed List: ");
        PrintList(reversed3);
        Console.WriteLine(new string('-', 40));

        // RemoveElementSolution Test
        var removeElementSolution = new RemoveElementSolution();

        // Test 1
        int[] numsRE1 = { 3, 2, 2, 3 };
        int val1 = 3;
        int kRE1 = removeElementSolution.RemoveElement(numsRE1, val1);
        Console.WriteLine($"RemoveElement: k = {kRE1}, nums = [{string.Join(", ", numsRE1[..kRE1])}]"); // Output: k = 2, nums = [2, 2]
        Console.WriteLine(new string('-', 40));

        // Test 2
        int[] numsRE2 = { 0, 1, 2, 2, 3, 0, 4, 2 };
        int val2 = 2;
        int kRE2 = removeElementSolution.RemoveElement(numsRE2, val2);
        Console.WriteLine($"RemoveElement: k = {kRE2}, nums = [{string.Join(", ", numsRE2[..kRE2])}]"); // Output: k = 5, nums = [0, 1, 3, 0, 4] (order may vary)
        Console.WriteLine(new string('-', 40));

        // Test 3: All elements are val
        int[] numsRE3 = { 1, 1, 1, 1 };
        int val3 = 1;
        int kRE3 = removeElementSolution.RemoveElement(numsRE3, val3);
        Console.WriteLine($"RemoveElement: k = {kRE3}, nums = [{string.Join(", ", numsRE3[..kRE3])}]"); // Output: k = 0, nums = []
        Console.WriteLine(new string('-', 40));

        // Test 4: No elements are val
        int[] numsRE4 = { 5, 6, 7 };
        int val4 = 1;
        int kRE4 = removeElementSolution.RemoveElement(numsRE4, val4);
        Console.WriteLine($"RemoveElement: k = {kRE4}, nums = [{string.Join(", ", numsRE4[..kRE4])}]"); // Output: k = 3, nums = [5, 6, 7]
        Console.WriteLine(new string('-', 40));

        // Test 5: Empty array
        int[] numsRE5 = { };
        int val5 = 0;
        int kRE5 = removeElementSolution.RemoveElement(numsRE5, val5);
        Console.WriteLine($"RemoveElement: k = {kRE5}, nums = [{string.Join(", ", numsRE5[..kRE5])}]"); // Output: k = 0, nums = []
        Console.WriteLine(new string('-', 40));

        Console.ReadLine();
    }
}