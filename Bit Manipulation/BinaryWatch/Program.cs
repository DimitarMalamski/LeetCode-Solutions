// Problem 401. Binary Watch
// Link https://leetcode.com/problems/binary-watch/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      int turnedOn = 1;
      IList<string> output = ReadBinaryWatch(turnedOn);
      Console.WriteLine(string.Join(",", output));
   }
   public static IList<string> ReadBinaryWatch(int turnedOn)
   {
      List<string> result = new List<string>();

      for (int hour = 0; hour < 12; hour++)
      {
         for (int minute = 0; minute < 60; minute++)
         {
            if (CountBits(hour) + CountBits(minute) == turnedOn)
            {
               result.Add($"{hour}:{minute:D2}");
            }
         }
      }

      return result;
   }

   private static int CountBits(int n) {
      int count = 0;

      while (n > 0)
      {
         count += n & 1;
         n >>= 1;
      }

      return count;
   }
}
