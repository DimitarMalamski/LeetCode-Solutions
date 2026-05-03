// Problem 933. Number of Recent Calls
// Link https://leetcode.com/problems/number-of-recent-calls/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    RecentCounter recentCounter = new RecentCounter();

    Console.WriteLine(recentCounter.Ping(1));
    Console.WriteLine(recentCounter.Ping(100));
    Console.WriteLine(recentCounter.Ping(3001));
    Console.WriteLine(recentCounter.Ping(3002));
  }
}
class RecentCounter
{
  private Queue<int> requests;

  public RecentCounter()
  {
    requests = new Queue<int>();
  }

  public int Ping(int t)
  {
    requests.Enqueue(t);

    while (requests.Peek() < t - 3000)
    {
      requests.Dequeue();
    }

    return requests.Count;
  } 
} 
