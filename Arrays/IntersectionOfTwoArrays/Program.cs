// Problem 349. Intersection of Two Arrays
// Link https://leetcode.com/problems/intersection-of-two-arrays/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      int[] nums1 = { 1, 2, 2, 1 };
      int[] nums2 = { 2, 2 };
      int[] output = Intersection(nums1, nums2);
      Console.WriteLine(string.Join(",", output));
   }
   public static int[] Intersection(int[] nums1, int[] nums2)
   {
      HashSet<int> set1 = new HashSet<int>(nums1);
      HashSet<int> result = new HashSet<int>();

      foreach (int num in nums2)
      {
         if (set1.Contains(num))
         {
            result.Add(num);
         }
      }

      return result.ToArray();
   }
}
