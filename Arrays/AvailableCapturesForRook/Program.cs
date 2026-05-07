// Problem 999. Available Captures for Rook
// Link https://leetcode.com/problems/available-captures-for-rook/description/
// Difficulty: Easy
class Solution {
  static void Main(string[] args) {
    char[][] board =
    {
      new char[] {'.', '.', '.', '.', '.', '.', '.', '.'},
      new char[] {'.', '.', '.', 'p', '.', '.', '.', '.'},
      new char[] {'.', '.', '.', 'R', '.', '.', '.', 'p'},
      new char[] {'.', '.', '.', '.', '.', '.', '.', '.'},
      new char[] {'.', '.', '.', '.', '.', '.', '.', '.'},
      new char[] {'.', '.', '.', 'p', '.', '.', '.', '.'},
      new char[] {'.', '.', '.', '.', '.', '.', '.', '.'},
      new char[] {'.', '.', '.', '.', '.', '.', '.', '.'}
    };

    int output = NumRookCaptures(board);
    Console.WriteLine(output);
  }
  public static int NumRookCaptures(char[][] board) {
    int rookRow = 0;
    int rookCol = 0;

    for (int row = 0; row < 8; row++)
    {
      for (int col = 0; col < 8; col++)
      {
        if (board[row][col] == 'R')
        {
          rookRow = row;
          rookCol = col;
        }
      }
    }

    int captures = 0;

    int[][] directions =
    {
      new int[] {-1, 0},
      new int[] {1, 0},
      new int[] {0, -1},
      new int[] {0, 1}
    };

    foreach (int[] direction in directions)
    {
      int row = rookRow + direction[0];
      int col = rookCol + direction[1];

      while (row >= 0 && row < 8 && col >= 0 && col < 8)
      {
        if (board[row][col] == 'p')
        {
          captures++;
          break;
        }

        if (board[row][col] == 'B')
        {
          break;
        }

        row += direction[0];
        col += direction[1];
      }
    }

    return captures;
  }
}
