// Problem 566. Reshape the Matrix
// Link https://leetcode.com/problems/reshape-the-matrix/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    int[][] mat = new int[][]
    {
        new int[] { 1, 2 },
        new int[] { 3, 4 }
    };
    int r = 1;
    int c = 4;
    int[][] output = MatrixReshape(mat, r, c);
    
    for (int i = 0; i < output.Length; i++)
    {
      for (int j = 0; j < output[i].Length; j++)
      {
        Console.Write(output[i][j] + " ");
      }
      Console.WriteLine();
    }
  }
  public static int[][] MatrixReshape(int[][] mat, int r, int c)
  {
    int m = mat.Length;
    int n = mat[0].Length;

    if (m * n != r * c) return mat;

    int[][] result = new int[r][];

    for (int i = 0; i < r; i++)
    {
      result[i] = new int[c];
    }

    for (int i = 0; i < m * n; i++)
    {
      int originalRow = i / n;
      int originalCol = i % n;

      int newRow = i / c;
      int newCol = i % c;

      result[newRow][newCol] = mat[originalRow][originalCol];
    }

    return result;
  }
}
