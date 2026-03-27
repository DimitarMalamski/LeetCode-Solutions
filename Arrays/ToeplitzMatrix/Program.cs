// Problem 766. Toeplitz Matrix
// Link https://leetcode.com/problems/toeplitz-matrix/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    int[][] matrix = {
      new int[] { 1,2,3,4 },
      new int[] { 5,1,2,3},
      new int[] { 9,5,1,2}
    };

    Solution sol = new Solution();
    bool output = sol.IsToeplitzMatrix(matrix);
    Console.WriteLine(output);
  }
  public bool IsToeplitzMatrix(int[][] matrix)
  {
    int rows = matrix.Length;
    int cols = matrix[0].Length;

    for (int r = 1; r < rows; r++)
    {
      for (int c = 1; c < cols; c++)
      {
        if (matrix[r][c] != matrix[r - 1][c - 1]) return false;
      }
    }

    return true;
  }
}

