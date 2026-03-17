// Problem 705. Design HashSet
// Link https://leetcode.com/problems/design-hashset/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    MyHashSet myHashSet = new MyHashSet();

    myHashSet.Add(1);
    myHashSet.Add(2);

    myHashSet.Contains(1);
    myHashSet.Contains(3);

    myHashSet.Add(2);

    myHashSet.Remove(2);

    myHashSet.Contains(2);
  }
  public class MyHashSet
  {
    private bool[] set;

    public MyHashSet()
    {
      set = new bool[1000001];
    }
    public void Add(int key)
    {
      set[key] = true;
    }
    public void Remove(int key)
    {
      set[key] = false;
    }
    public bool Contains(int key)
    {
      return set[key];
    }
  }
}
