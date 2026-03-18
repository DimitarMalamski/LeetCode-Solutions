// Problem 706. Design HashMap
// Link https://leetcode.com/problems/design-hashmap/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    var map = new MyHashMap();

    map.Put(1, 1);
    map.Put(2, 2);
    Console.WriteLine(map.Get(1));
    Console.WriteLine(map.Get(3));
    map.Put(2, 1);
    Console.WriteLine(map.Get(2));
    map.Remove(2);
    Console.WriteLine(map.Get(2));
  }
  public class MyHashMap
  {
    private int[] map;

    public MyHashMap()
    {
      map = new int[1_000_001];
      Array.Fill(map, -1);
    }

    public void Put(int key, int value)
    {
      map[key] = value;
    }

    public int Get(int key)
    {
      return map[key];
    }

    public void Remove(int key)
    {
      map[key] = -1;
    }
  }
}
