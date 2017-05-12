using System;
using System.Collections.Generic;

namespace _09LargestArea
{
    class Program
    {
        static void Main()
        {
            bool[,] matrix = new bool[,]
            {
                {true, true, false, true, true },
                {false, true, true, false, false },
                {true, true, false, true, true },
                {true, false, true, true, true },
                {true, false, true, true, true }
            };

            bool[,] visited = new bool[,]
            {
                {false, false, false, false, false },
                {false, false, false, false, false },
                {false, false, false, false, false },
                {false, false, false, false, false },
                {false, false, false, false, false }
            };

            int row = 0;
            int col = 0;
            int maxCells = 0;
            while (col < matrix.GetLength(1))
            {
                if (!visited[row, col] && matrix[row, col])
                {
                    List<string> path = new List<string>();
                    MakeRound(matrix, visited, path, row, col);
                    Console.WriteLine(string.Join(", ", path));

                    if (path.Count > maxCells)
                    {
                        maxCells = path.Count;
                    }
                }

                row++;
                if (row >= matrix.GetLength(0))
                {
                    row = 0;
                    col++;
                }
            }

            Console.WriteLine($"Maximum connected cells: {maxCells}");
        }

        public static void MakeRound(bool[,] matrix, bool[,] visited, List<string> path, int row, int col)
        {
            if (AllCellsAroundVisited(matrix, visited, row, col))
            {
                visited[row, col] = true;
                path.Add($"({row} {col})");
            }
            else
            {
                if (matrix[row, col])
                {
                    visited[row, col] = true;
                    path.Add($"({row} {col})");
                    if (row + 1 < matrix.GetLength(0) && !visited[row + 1, col] && matrix[row + 1, col])
                    {
                        MakeRound(matrix, visited, path, row + 1, col);
                    }

                    if (row > 0 && !visited[row - 1, col] && matrix[row - 1, col])
                    {
                        MakeRound(matrix, visited, path, row - 1, col);
                    }

                    if (col > 0 && !visited[row, col - 1] && matrix[row, col - 1])
                    {
                        MakeRound(matrix, visited, path, row, col - 1);
                    }

                    if (col + 1 < matrix.GetLength(1) && !visited[row, col + 1] && matrix[row, col + 1])
                    {
                        MakeRound(matrix, visited, path, row, col + 1);
                    }
                }
            }
        }

        private static bool AllCellsAroundVisited(bool[,] matrix, bool[,] visited, int row, int col)
        {
            if ((row + 1 < matrix.GetLength(0) && !visited[row + 1, col] && matrix[row + 1, col]) ||
                (row > 0 && !visited[row - 1, col] && matrix[row - 1, col]) ||
                (col > 0 && !visited[row, col - 1] && matrix[row, col - 1]) ||
                (col + 1 < matrix.GetLength(1) && !visited[row, col + 1] && matrix[row, col + 1]))
            {
                return false;
            }

            return true;
        }
    }
}
