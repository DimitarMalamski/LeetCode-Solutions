// Problem 350. Intersection of Two Arrays II
// Link https://leetcode.com/problems/intersection-of-two-arrays-ii/description/
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
      Dictionary<int, int> freq = new Dictionary<int, int>();

      foreach (int num in nums1)
      {
         if (!freq.ContainsKey(num))
         {
            freq[num] = 0;
         }

         freq[num]++;
      }

      List<int> result = new List<int>();

      foreach (int num in nums2)
      {
         if (freq.ContainsKey(num) && freq[num] > 0)
         {
            result.Add(num);
            freq[num]--;
         }
      }

      return result.ToArray();
   }
}
