// Problem 661. Image Smoother
// Link https://leetcode.com/problems/image-smoother/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    int[][] img = new int[][]
    {
      new int[] {1,1,1},
      new int[] {1,0,1},
      new int[] {1,1,1}
    };

    Solution sol = new Solution();
    int[][] result = sol.ImageSmoother(img);

    PrintMatrix(result);
  }
  public int[][] ImageSmoother(int[][] img)
  {
    int rows = img.Length;
    int cols = img[0].Length;

    int[][] result = new int[rows][];
    for (int i = 0; i < rows; i++)
        result[i] = new int[cols];

    int[] dirs = { -1, 0, 1 };

    for (int r = 0; r < rows; r++)
    {
      for (int c = 0; c < cols; c++)
      {
        int sum = 0;
        int count = 0;

        foreach (int dr in dirs)
        {
          foreach (int dc in dirs)
          {
            int nr = r + dr;
            int nc = c + dc;

            if (nr >= 0 && nr < rows && nc >= 0 && nc < cols)
            {
              sum += img[nr][nc];
              count++;
            }
          }
        }

        result[r][c] = sum / count;
      }
    }

    return result;
  }

  private static void PrintMatrix(int[][] matrix)
  {
    foreach (var row in matrix)
    {
      Console.WriteLine(string.Join(" ", row));
    }
  }
}
