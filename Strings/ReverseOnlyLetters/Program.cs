// Problem 917. Reverse Only Letters
// Link https://leetcode.com/problems/reverse-only-letters/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    string s = "a-bC-dEf-ghIj";
    string output = ReverseOnlyLetters(s);
    Console.WriteLine(output);
  }
  public static string ReverseOnlyLetters(string s)
  {
    char[] chars = s.ToCharArray();
    int left = 0;
    int right = chars.Length - 1;

    while (left < right)
    {
      if (!char.IsLetter(chars[left]))
      {
        left++;
      }
      else if (!char.IsLetter(chars[right]))
      {
        right--;
      }
      else
      {
        char temp = chars[left];
        chars[left] = chars[right];
        chars[right] = temp;

        left++;
        right--;
      }
    }

    return new string(chars);
  }
}
