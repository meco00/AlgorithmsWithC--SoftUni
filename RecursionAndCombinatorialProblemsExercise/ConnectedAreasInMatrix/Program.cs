using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConnectedAreasInMatrix
{
    class Program
    {
        public class Area
        {
            public int Row { get; set; }
            public int Coll { get; set; }

            public int Size { get; set; }
        }
        static void Main(string[] args)
        {
            List<Area> collection = new List<Area>();

            int row = int.Parse(Console.ReadLine());
            int coll = int.Parse(Console.ReadLine());

            char[,] matrix = new char[row, coll];

            bool[,] visited = new bool[row, coll];

            FillArray(matrix);

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (visited[i,j])
                    {
                        continue;

                    }

                    if (matrix[i,j]=='*')
                    {
                        continue;
                    }


                   int areaSize = FindPathOfArea(matrix, i, j, visited);
                    Area area = new Area { Row = i, Coll = j, Size = areaSize };
                    collection.Add(area);
                }

            }


            Console.WriteLine($"Total areas found: {collection.Count}");

            int index = 1;
            foreach (var item in collection.OrderByDescending(x=>x.Size).ThenBy(x=>x.Row).ThenBy(x=>x.Coll))
            {
                Console.WriteLine($"Area #{index++} at ({item.Row}, {item.Coll}), size: {item.Size}");
            }



        }

        private static int FindPathOfArea(char[,] matrix, int row, int coll, bool[,] visited)
        {
            if (IsOutside(matrix,row,coll))
            {
                return 0;

            }

            if (visited[row,coll])
            {
                return 0;
            }


            if (matrix[row,coll]=='*')
            {
                return 0;

            }

            visited[row, coll] = true;

            return 1 + FindPathOfArea(matrix, row, coll + 1, visited) + FindPathOfArea(matrix, row + 1, coll, visited)
                + FindPathOfArea(matrix, row, coll - 1, visited) + FindPathOfArea(matrix, row - 1, coll, visited);




        }

        private static bool IsOutside(char[,] matrix, int row, int coll)
        {
            return row >= matrix.GetLength(0)
                || row < 0
                || coll >= matrix.GetLength(1)
                || coll < 0;
        }

        private static void FillArray(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string toFillArray = Console.ReadLine();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = toFillArray[j];

                }

            }
        }

        private static void PrintArray(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j] );
                }
                Console.WriteLine();
            }
        }
    }
}
