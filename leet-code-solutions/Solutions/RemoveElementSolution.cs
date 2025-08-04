namespace LeetCodeSolutions
{
    public class RemoveElementSolution
    {
        public int RemoveElement(int[] nums, int val)
        {
            int k = 0; // Number of elements not equal to val
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[k] = nums[i];
                    k++;
                }
            }
            return k; // The new length of the array (number of non-val elements)
        }
    }
}
