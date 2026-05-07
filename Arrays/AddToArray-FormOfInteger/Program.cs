// Problem 989. Add to Array-Form of Integer
// Link https://leetcode.com/problems/add-to-array-form-of-integer/description/
// Difficulty: Easy
class Solution {
  static void Main(string[] args) {
    int[] num = {1,2,0,0};
    int k = 34;
    List<int> output = AddToArrayForm(num, k);
    Console.WriteLine(string.Join(",", output));
  }
  public static List<int> AddToArrayForm(int[] num, int k) {
    List<int> result = new List<int>();

    int i = num.Length - 1;

    while (i >= 0 || k > 0) {
      if (i >= 0) {
        k += num[i];
        i--;
      }

      result.Add(k % 10);
      k /= 10;
    }

    result.Reverse();
    return result;
  }
}
