// Problem 599. Minimum Index Sum of Two Lists
// Link https://leetcode.com/problems/minimum-index-sum-of-two-lists/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    string[] list1 = { "Shogun", "Tapioca Express", "Burger King", "KFC" };
    string[] list2 = { "Piatti", "The Grill at Torrey Pines", "Hungry Hunter Steakhouse", "Shogun" };
    string[] output = FindRestaurant(list1, list2);
    Console.WriteLine(string.Join(",", output));
  }
  public static string[] FindRestaurant(string[] list1, string[] list2)
  {
    Dictionary<string, int> map = new Dictionary<string, int>();

    for (int i = 0; i < list1.Length; i++)
    {
      map[list1[i]] = i;
    }

    List<string> result = new List<string>();
    int minSum = int.MaxValue;

    for (int i = 0; i < list2.Length; i++)
    {
      if (map.ContainsKey(list2[i]))
      {
        int indexSum = i + map[list2[i]];

        if (indexSum < minSum)
        {
          result.Clear();
          result.Add(list2[i]);
          minSum = indexSum;
        }
        else if (indexSum == minSum)
        {
          result.Add(list2[i]);
        }
      }
    }

    return result.ToArray();
  }
}
