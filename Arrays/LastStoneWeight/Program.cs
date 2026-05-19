// Problem 1046. Last Stone Weight
// Link https://leetcode.com/problems/last-stone-weight/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    int[] stones = { 2, 7, 4, 1, 8, 1 };
    int output = LastStoneWeight(stones);
    Console.WriteLine(output);
  }
  public static int LastStoneWeight(int[] stones)
  {
    List<int> stoneList = new List<int>(stones);

    while (stoneList.Count > 1)
    {
      stoneList.Sort();

      int y = stoneList[stoneList.Count - 1];
      int x = stoneList[stoneList.Count - 2];

      stoneList.RemoveAt(stoneList.Count - 1);
      stoneList.RemoveAt(stoneList.Count - 1);

      if (y != x)
      {
        stoneList.Add(y - x);
      }
    }

    return stoneList.Count == 0 ? 0 : stoneList[0];
  }
}
