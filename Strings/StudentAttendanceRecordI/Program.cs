// Problem 551. Student Attendance Record I
// Link https://leetcode.com/problems/student-attendance-record-i/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    string s = "PPALLP";
    bool output = CheckRecord(s);
    Console.WriteLine(output);
  }
  public static bool CheckRecord(string s)
  {
    int absenceCount = 0;
    int lateStreak = 0;

    foreach (char c in s)
    {
      if (c == 'A')
      {
        absenceCount++;
        if (absenceCount >= 2) return false;

        lateStreak = 0;
      }
      else if (c == 'L')
      {
        lateStreak++;
        if (lateStreak >= 3) return false;
      }
      else
      {
        lateStreak = 0;
      }
    }

    return true;
  }
}
