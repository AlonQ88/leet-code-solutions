//PROBLEM 1
//Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
//You may assume that each input would have exactly one solution, and you may not use the same element twice.
//You can return the answer in any order.

//Example 1:

//Input: nums = [2,7,11,15], target = 9
//Output: [0,1]
//Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].

//Example 2:

//Input: nums = [3,2,4], target = 6
//Output: [1,2]

//Example 3:

//Input: nums = [3,3], target = 6
//Output: [0,1]

//Constraints:

//2 <= nums.length <= 104
//-109 <= nums[i] <= 109
//-109 <= target <= 109

//Only one valid answer exists.

// Test TwoSum

var result = TwoSum(new int[] { 2, 7, 11, 15 }, 9);
Console.WriteLine(string.Join(", ", result)); // Output: 0, 1
Console.ReadLine();

int[] TwoSum(int[] nums, int target)
{
    var dict = new Dictionary<int, int>();
    for (int i = 0; i < nums.Length; i++)
    {
        int complement = target - nums[i];
        if (dict.ContainsKey(complement))
            return new int[] { dict[complement], i };
        dict[nums[i]] = i;
    }
    return Array.Empty<int>();
}

//PROBLEM 2

//Write a function to find the longest common prefix string amongst an array of strings.
//If there is no common prefix, return an empty string "".

//Example 1:
//Input: strs = ["flower", "flow", "flight"] Output: "fl" Example 2:
//Input: strs = ["dog", "racecar", "car"] Output: "" Explanation: There is no common prefix among the input strings.

//Constraints:
//1 <= strs.length <= 200 0 <= strs[i].length <= 200 strs[i] consists of only lowercase English letters if it is non-empty.
string LongestCommonPrefix(string[] strs)
{
    if (strs == null || strs.Length == 0)
        return "";

    for (int i = 0; i < strs[0].Length; i++)
    {
        char c = strs[0][i];
        for (int j = 1; j < strs.Length; j++)
        {
            // If i is out of bounds for strs[j] or characters don't match
            if (i >= strs[j].Length || strs[j][i] != c)
                return strs[0].Substring(0, i);
        }
    }
    return strs[0];
}

var prefix = LongestCommonPrefix(new string[] { "flower", "flow", "flight" });
Console.WriteLine(prefix); // Output: "fl"
Console.ReadLine();

//PROBLEM 3

//Write a function to calculate the sum of digits of a given number.

//Input:

//An integer n.
//Output:

//The sum of digits of n.
//Example:

//Input: 12345
//Output: 15

int SumOfDigits(int n)
{
    int sum = 0;
    while (n > 0)
    {
        sum += n % 10;  // Add the last digit
        n /= 10;        // Remove the last digit
    }
    return sum;
}

Console.WriteLine("Number to Sum: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(SumOfDigits(n));
Console.ReadLine();