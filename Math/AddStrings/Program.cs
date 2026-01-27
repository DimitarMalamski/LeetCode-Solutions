// Problem 415. Add Strings
// Link https://leetcode.com/problems/add-strings/description/
// Difficulty: Easy
using System.Text;
class Solution
{
  static void Main(string[] args)
  {
    string num1 = "11";
    string num2 = "123";
    string output = AddStrings(num1, num2);
    Console.WriteLine(output);
  }
  public static string AddStrings(string num1, string num2)
  {
    int i = num1.Length - 1;
    int j = num2.Length - 1;
    int carry = 0;

    StringBuilder sb = new StringBuilder();

    while (i >= 0 || j >= 0 || carry > 0)
    {
      int d1 = (i >= 0) ? num1[i] - '0' : 0;
      int d2 = (j >= 0) ? num2[j] - '0' : 0;

      int sum = d1 + d2 + carry;
      carry = sum / 10;

      sb.Append(sum % 10);

      i--;
      j--;
    }

    char[] arr = sb.ToString().ToCharArray();
    Array.Reverse(arr);
    return new string(arr);
  }
}
