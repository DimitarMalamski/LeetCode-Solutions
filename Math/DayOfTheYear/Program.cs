// Problem 1154. Day of the Year
// Link https://leetcode.com/problems/day-of-the-year/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    string date = "2019-01-09";
    int output = DayOfYear(date);
    Console.WriteLine(output);
  }
  public static int DayOfYear(string date)
  {
    int year = int.Parse(date.Substring(0, 4));
    int month = int.Parse(date.Substring(5, 2));
    int day = int.Parse(date.Substring(8, 2));

    int[] daysInMonth =
    {
      31, 28, 31, 30, 31, 30,
      31, 31, 30, 31, 30, 31
    };

    if (IsLeapYear(year))
    {
      daysInMonth[1] = 29;
    }

    int result = day;

    for (int i = 0; i < month - 1; i++)
    {
      result += daysInMonth[i];
    }

    return result;
  }
  private static bool IsLeapYear(int year)
  {
    return (year % 400 == 0) ||
      (year % 4 == 0 && year % 100 != 0);
  }
}
