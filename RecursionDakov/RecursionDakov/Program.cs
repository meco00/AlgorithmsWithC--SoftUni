using System;

namespace RecursionDakov
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] maze = 
           {

                "010000",
                "000000",
                "00100E",
                "000000",



            };

            string[] newMaze=
            {
                "000",
                "010",
                "00E",

            };

            FindPath(maze, new bool[maze.Length, maze[0].Length],0,0, "");
           
            


        }

        private static void FindPath(string[] maze, bool[,] isThere, int row, int col, string path)
        {
            if (maze[row][col]=='E')
            {

                Console.WriteLine(path);
                return;

            }

            isThere[row, col] = true;

            if (IsSafe(maze,isThere,row+1,col))
            {
                FindPath(maze, isThere, row + 1, col, path + "D");

            }
            if (IsSafe(maze, isThere, row , col+1))
            {
                FindPath(maze, isThere, row , col+1, path + "R");

            }
            if (IsSafe(maze, isThere, row - 1, col))
            {
                FindPath(maze, isThere, row - 1, col, path + "U");

            }
            if (IsSafe(maze, isThere, row, col-1))
            {
                FindPath(maze, isThere, row , col-1, path + "L");

            }
            isThere[row, col] = false;




        }

        private static bool IsSafe(string[] maze, bool[,] isThere, int row, int col)
        {

            if (row < 0 || col < 0 || row >= maze.Length || col >= maze[0].Length)
            {
                return false;

            }
            if (maze[row][col]=='1'||isThere[row,col])
            {
                return false;

            }


            return true;


        }

       
    }
}
