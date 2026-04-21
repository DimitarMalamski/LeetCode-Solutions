// Problem 914. X of a Kind in a Deck of Cards
// Link https://leetcode.com/problems/x-of-a-kind-in-a-deck-of-cards/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    int[] deck = { 1, 2, 3, 4, 4, 3, 2, 1 };
    bool output = HasGroupsSizeX(deck);
    Console.WriteLine(output);
  }
  public static bool HasGroupsSizeX(int[] deck)
  {
    Dictionary<int, int> counts = new Dictionary<int, int>();

    foreach (int card in deck)
    {
      if (!counts.ContainsKey(card))
      {
        counts[card] = 0;
      }

      counts[card]++;
    }

    int gcd = 0;

    foreach (int count in counts.Values)
    {
      gcd = GCD(gcd, count);
    }

    return gcd > 1;
  }

  private static int GCD(int a, int b)
  {
    while (b != 0)
    {
      int temp = b;
      b = a % b;
      a = temp;
    }

    return a;
  }
}
