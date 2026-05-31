// Problem 1185. Day of the Week
// Link https://leetcode.com/problems/day-of-the-week/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    int day = 31, month = 8, year = 2019;
    string output = DayOfTheWeek(day, month, year);
    Console.WriteLine(output);
  }
  public static string DayOfTheWeek(int day, int month, int year)
  {
    string[] days =
    {
      "Friday", "Saturday", "Sunday", "Monday",
      "Tuesday", "Wednesday", "Thursday"
    };

    int[] monthDays =
    {
      31, 28, 31, 30, 31, 30,
      31, 31, 30, 31, 30, 31
    };

    int totalDays = 0;

    for (int y = 1971; y < year; y++)
    {
      totalDays += IsLeapYear(y) ? 366 : 365;
    }

    for (int m = 1; m < month; m++)
    {
      totalDays += monthDays[m - 1];

      if (m == 2 && IsLeapYear(year))
      {
        totalDays += 1;
      }
    }

    totalDays += day - 1;

    return days[totalDays % 7];
  }
  private static bool IsLeapYear(int year)
  {
    return year % 400 == 0 || 
      (year % 4 == 0 && year % 100 != 0);
  } 
}
