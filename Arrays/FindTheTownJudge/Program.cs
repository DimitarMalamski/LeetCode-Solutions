// Problem 997. Find the Town Judge
// Link https://leetcode.com/problems/find-the-town-judge/description/
// Difficulty: Easy
class Solution {
  static void Main(string[] args) {
    int n = 2;
    int[][] trust = {[1,2]};
    int output = FindJudge(n, trust);
    Console.WriteLine(output);
  }
  public static int FindJudge(int n, int[][] trust) {
    int[] trustsOthers = new int[n + 1];
    int[] trustedByOthers = new int[n + 1];

    foreach (int[] relation in trust)
    {
      int personA = relation[0];
      int personB = relation[1];

      trustsOthers[personA]++;
      trustedByOthers[personB]++;
    }

    for (int person = 1; person <= n; person++)
    {
      if (trustsOthers[person] == 0 && trustedByOthers[person] == n - 1)
      {
        return person;
      }
    }

    return - 1;
  }
}