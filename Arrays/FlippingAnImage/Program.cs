// Problem 832. Flipping an Image
// Link https://leetcode.com/problems/flipping-an-image/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    int[][] image = new int[][]
    {
      new int[] { 1, 1, 0 },
      new int[] { 1, 0, 1 },
      new int[] { 0, 0, 0 }
    };

    int[][] output = FlipAndInvertImage(image);

    foreach (var row in output)
    {
      Console.WriteLine("[" + string.Join(",", row) + "]");
    }
  }
  public static int[][] FlipAndInvertImage(int[][] image)
  {
    int n = image.Length;

    for (int i = 0; i < n; i++)
    {
      int left = 0;
      int right = n - 1;

      while (left <= right)
      {
        int temp = image[i][left] ^ 1;
        image[i][left] = image[i][right] ^ 1;
        image[i][right] = temp;

        left++;
        right--;
      }
    }

    return image;
  }
}
