using System;
using System.Collections.Generic;

namespace Queens
{
    class Program
    {
        static HashSet<int> attackedRows = new HashSet<int>();
        static HashSet<int> attackedColls = new HashSet<int>();
        static HashSet<int> attackedLeftDiagonal = new HashSet<int>();
        static HashSet<int> attackedRightDiagonal = new HashSet<int>();

        static void Main(string[] args)
        {
            bool[,] matrix = new bool[8, 8];


            PutQueens(matrix, 0);

        }

        private static void PutQueens(bool[,] matrix, int row)
        {
            if (row == matrix.GetLength(0))
            {
                PrintQueens(matrix);
                return;

            }

            for (int coll = 0; coll < matrix.GetLength(1); coll++)
            {
                if (!IsAttacked(row, coll))
                {
                    matrix[row, coll] = true;
                    attackedRows.Add(row);
                    attackedColls.Add(coll);
                    attackedLeftDiagonal.Add(row - coll);
                 attackedRightDiagonal.Add(row + coll);

                    PutQueens(matrix, row + 1);


                    matrix[row, coll] = false;
                    attackedRows.Remove(row);
                    attackedColls.Remove(coll);
                    attackedLeftDiagonal.Remove(row - coll);
                    attackedRightDiagonal.Remove(row + coll);

                }

            }



        }

        private static bool IsAttacked(int row, int coll)
        {
            return attackedRows.Contains(row)
                || attackedColls.Contains(coll)
                || attackedLeftDiagonal.Contains(row - coll)
                || attackedRightDiagonal.Contains(row + coll);

        }

        private static void PrintQueens(bool[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j])
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("- ");    
                    }
                }
                Console.WriteLine();

            }

            Console.WriteLine();
        }
    }
}
