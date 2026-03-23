// Problem 733. Flood Fill
// Link https://leetcode.com/problems/flood-fill/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    int[][] image =
    {
      new int[] { 1, 1, 1 },
      new int[] { 1, 1, 0 },
      new int[] { 1, 0, 1 }
    };

    int sr = 1;
    int sc = 1;
    int color = 2;

    Solution sol = new Solution();
    int[][] result = sol.FloodFill(image, sr, sc, color);

    PrintImage(result);
  }
  public int[][] FloodFill(int[][] image, int sr, int sc, int color)
  {
    int originalColor = image[sr][sc];

    if (originalColor == color) return image;

    DFS(image, sr, sc, originalColor, color);
    return image;
  }
  private void DFS(int[][] image, int row, int col, int originalColor, int newColor)
  {
    if (row < 0 || row >= image.Length || col < 0 || col >= image[0].Length) return;

    if (image[row][col] != originalColor) return;

    image[row][col] = newColor;

    DFS(image, row + 1, col, originalColor, newColor);
    DFS(image, row - 1, col, originalColor, newColor);
    DFS(image, row, col + 1, originalColor, newColor);
    DFS(image, row, col - 1, originalColor, newColor);
  }
  static void PrintImage(int[][] image)
  {
    for (int i = 0; i < image.Length; i++)
    {
      Console.Write("[");
      for (int j = 0; j < image[i].Length; j++)
      {
        Console.Write(image[i][j]);
        if (j < image[i].Length - 1)
          Console.Write(", ");
      }
      Console.WriteLine("]");
    }
  }
}
