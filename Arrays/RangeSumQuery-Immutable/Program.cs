// Problem 303. Range Sum Query - Immutable
// Link https://leetcode.com/problems/range-sum-query-immutable/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      int[] nums = { -2, 0, 3, -5, 2, -1 };

      NumArray numArray = new NumArray(nums);

      Console.WriteLine(numArray.SumRange(0, 2));
      Console.WriteLine(numArray.SumRange(2, 5));
      Console.WriteLine(numArray.SumRange(0, 5));
   }

   public class NumArray
   {
      private int[] prefix;

      public NumArray(int[] nums)
      {
         prefix = new int[nums.Length + 1];
         prefix[0] = 0;

         for (int i = 0; i < nums.Length; i++)
         {
            prefix[i + 1] = prefix[i] + nums[i];
         }
      }
      public int SumRange(int left, int right)
      {
         return prefix[right + 1] - prefix[left];
      }
   }
}
