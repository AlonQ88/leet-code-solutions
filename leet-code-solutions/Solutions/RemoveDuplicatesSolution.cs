namespace LeetCodeSolutions
{
    public class RemoveDuplicatesSolution
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums == null || nums.Length == 0) return 0;

            int k = 1; // At least one unique element exists
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[k - 1])
                {
                    nums[k] = nums[i];
                    k++;
                }
            }
            return k;
        }
    }
}