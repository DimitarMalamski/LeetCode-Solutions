// Problem 541. Reverse String II
// Link https://leetcode.com/problems/reverse-string-ii/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    string s = "abcdefg";
    int k = 2;
    string output = ReverseStr(s, k);
    Console.WriteLine(output);
  }
  public static string ReverseStr(string s, int k)
  {
    char[] arr = s.ToCharArray();

    for (int i = 0; i < arr.Length; i += 2 * k)
    {
      int left = i;
      int right = Math.Min(i + k - 1, arr.Length - 1);

      while (left < right)
      {
        char temp = arr[left];
        arr[left] = arr[right];
        arr[right] = temp;
        left++;
        right--;
      }
    }

    return new string(arr);
  }
}
