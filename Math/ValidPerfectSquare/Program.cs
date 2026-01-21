// Problem 367. Valid Perfect Square
// Link https://leetcode.com/problems/valid-perfect-square/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      int num = 14;
      bool output = IsPerfectSquare(num);
      Console.WriteLine(output);
   }
   public static bool IsPerfectSquare(int num)
   {
      long left = 1, right = num;

      while (left <= right)
      {
         long mid = left + (right - left) / 2;
         long square = mid * mid;

         if (square == num)
         {
            return true;
         }
         else if (square < num)
         {
            left = mid + 1;
         }
         else
         {
            right = mid - 1;
         }
      }

      return false;
   }
}