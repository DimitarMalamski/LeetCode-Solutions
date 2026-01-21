// Problem 228. Summary Ranges
// Link https://leetcode.com/problems/summary-ranges/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      int[] nums = { 0, 1, 2, 4, 5, 7 };
      List<string> output = SummaryRanges(nums);
      Console.WriteLine(string.Join(",", output));
   }
   public static List<string> SummaryRanges(int[] nums)
   {
      List<string> result = new List<string>();

      if (nums.Length == 0) return result;

      int start = nums[0];

      for (int i = 1; i <= nums.Length; i++)
      {
         if (i == nums.Length || nums[i] != nums[i - 1] + 1)
         {
            int end = nums[i - 1];

            if (start == end)
            {
               result.Add(start.ToString());
            }
            else
            {
               result.Add(start + "->" + end);
            }

            if (i < nums.Length)
            {
               start = nums[i];
            }
         }
      }

      return result;
   }
}
