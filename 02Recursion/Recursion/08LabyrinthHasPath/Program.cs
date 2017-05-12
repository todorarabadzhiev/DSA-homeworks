using System;
using System.Collections.Generic;

namespace _08LabyrinthHasPath
{
    class Program
    {
        static void Main()
        {
            int n = 100;
            bool[,] matrix = new bool[n, n];
            bool[,] visited = new bool[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = true;
                    visited[i, j] = false;
                }
            }

            int startRow = 2;
            int startCol = 3;
            int targetRow = 1;
            int targetCol = 0;
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
                if (matrix[row, col])
                {
                    visited[row, col] = true;
                    path.Add($"({row} {col})");
                    if (row + 1 < matrix.GetLength(0) && !visited[row + 1, col])
                    {
                        if (MakeStep(matrix, visited, path, row + 1, col, targetRow, targetCol))
                        {
                            return true;
                        }
                    }

                    if (row > 0 && !visited[row - 1, col])
                    {
                        if (MakeStep(matrix, visited, path, row - 1, col, targetRow, targetCol))
                        {
                            return true;
                        }
                    }

                    if (col > 0 && !visited[row, col - 1])
                    {
                        if (MakeStep(matrix, visited, path, row, col - 1, targetRow, targetCol))
                        {
                            return true;
                        }
                    }

                    if (col + 1 < matrix.GetLength(1) && !visited[row, col + 1])
                    {
                        if (MakeStep(matrix, visited, path, row, col + 1, targetRow, targetCol))
                        {
                            return true;
                        }
                    }

                    visited[row, col] = false;
                    path.RemoveAt(path.Count - 1);

                    return false;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
