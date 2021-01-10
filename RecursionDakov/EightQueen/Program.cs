using System;
using System.Data;
using System.IO;

namespace EightQueen
{
    class Program
    {
        static void Main(string[] args)
        {
            int queens =int.Parse(Console.ReadLine());

            int[,] matrix = new int[queens, queens];

            Console.WriteLine( GetQueens(matrix, 0));
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j]==1)
                    {
                        Console.Write("Q"+" ");

                    }
                    else
                    {
                        Console.Write("_" + " ");
                    }
                }
                Console.WriteLine();

            }
            
            Console.WriteLine();
            Console.WriteLine();

        }

        private static int GetQueens(int[,] matrix, int row)
        {
            if (row==matrix.GetLength(0))
            {
                PrintMatrix(matrix);
                return 1;

            }

            int foundQueens = 0;

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (isSafe(matrix,row,col))
                {
                    matrix[row, col] = 1;
                   foundQueens += GetQueens(matrix, row + 1);
                    matrix[row, col] = 0;

                }

            }

            return foundQueens;
        }

        private static bool isSafe(int[,] matrix, int row, int col)
        {
            for (int i = 1; i < matrix.GetLength(0); i++)
            {
                if (row-i>=0&&matrix[row-i,col]==1)
                {
                    return false;

                }
                if (col-i>=0&&matrix[row,col-1]==1)
                {
                    return false;

                }


                if (row + i <matrix.GetLength(0) && matrix[row + i, col] == 1)
                {
                    return false;

                }
                if (col + i < matrix.GetLength(1) && matrix[row , col+i] == 1)
                {
                    return false;

                }


                if (col + i < matrix.GetLength(1) && row + i < matrix.GetLength(0)&&
                    matrix[row+i,col+i]==1
                   )
                {
                    return false;
                }

                if (col - i >=0 && row + i < matrix.GetLength(0)&&
                   matrix[row + i, col - i] == 1 
                   )
                {
                    return false;
                }

                if (col - i >=0 && row - i >= 0&&
                   matrix[row - i, col - i] == 1 
                   )
                {
                    return false;
                }

                if (col + i < matrix.GetLength(0) && row - i >= 0 &&
                   matrix[row - i, col + i] == 1 
                   )
                {
                    return false;
                }







            }
            return true;
        }
    }
}
