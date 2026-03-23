// Problem 744. Find Smallest Letter Greater Than Target
// Link https://leetcode.com/problems/find-smallest-letter-greater-than-target/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    char[] letters = { 'c', 'f', 'j' };
    char target = 'a';
    char output = NextGreatestLetter(letters, target);
    Console.WriteLine(output);
  }
  public static char NextGreatestLetter(char[] letters, char target)
  {
    for (int i = 0; i < letters.Length; i++)
    {
      if (letters[i] > target) return letters[i];
    }

    return letters[0];
  }
}
