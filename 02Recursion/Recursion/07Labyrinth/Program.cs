using System;
using System.Collections.Generic;

namespace _07Labyrinth
{
    class Program
    {
        static void Main()
        {
            bool[,] matrix = new bool[,]
            {
                {true, true, false, true },
                {false, true, true, false },
                {true, true, false, true },
                {true, false, false, false },
            };

            bool[,] visited = new bool[,]
            {
                {false, false, false, false },
                {false, false, false, false },
                {false, false, false, false },
                {false, false, false, false }
            };

            int startRow = 3;
            int startCol = 0;
            int targetRow = 0;
            int targetCol = 1;
            List<string> path = new List<string>();
            if (!matrix[targetRow, targetCol] || !MakeStep(matrix, visited, path, startRow, startCol, targetRow, targetCol))
            {
                Console.WriteLine("Cannot pass through labyrinth");
            }
        }

        public static bool MakeStep(bool[,] matrix, bool[,] visited, List<string> path, int row, int col, int targetRow, int targetCol)
        {
            if (row == targetRow && col == targetCol)
            {
                path.Add($"({row} {col})");
                Console.WriteLine(String.Join("->", path));
                path.RemoveAt(path.Count - 1);

                return true;
            }
            else
            {
                bool found = false;
                if (matrix[row, col])
                {
                    visited[row, col] = true;
                    path.Add($"({row} {col})");
                    if (row + 1 < matrix.GetLength(0) && !visited[row + 1, col])
                    {
                        found = MakeStep(matrix, visited, path, row + 1, col, targetRow, targetCol) || found;
                    }

                    if (row > 0 && !visited[row - 1, col])
                    {
                        found = MakeStep(matrix, visited, path, row - 1, col, targetRow, targetCol) || found;
                    }

                    if (col > 0 && !visited[row, col - 1])
                    {
                        found = MakeStep(matrix, visited, path, row, col - 1, targetRow, targetCol) || found;
                    }

                    if (col + 1 < matrix.GetLength(1) && !visited[row, col + 1])
                    {
                        found = MakeStep(matrix, visited, path, row, col + 1, targetRow, targetCol) || found;
                    }

                    visited[row, col] = false;
                    path.RemoveAt(path.Count - 1);

                    return found;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
