using System;
using System.IO;
using System.Linq;

namespace RecursionAndBacktracking
{
    class Program
    {
        static void Main(string[] args)
        {
            //int row = int.Parse(Console.ReadLine());
            //int coll = int.Parse(Console.ReadLine());


            //var array = new char[row, coll];

            //FillArray(array);

            //FindAllPathsInLabyirint(array, 0, 0, "", "");

            long n =long.Parse(Console.ReadLine());

            Console.WriteLine(RecursiveFibbonaci(n));

            

            //int sum = GetSum(array, 0);


            //RecursiveDrawing(n);

            //var array = new int[n];

            //CreateVectors(array,0);





        }

        private static long RecursiveFibbonaci(long n)
        {
            if (n <= 1)
            {
                return 1;
            }
      

            return RecursiveFibbonaci(n - 2) + RecursiveFibbonaci(n - 1);
        }

        public static void FindAllPathsInLabyirint(char[,] array,int row,int coll,string path,string moves)
        {
            if (IsOutside(array,row,coll)||IsWall(array,row,coll)||IsVisited(array,row,coll))
            {
                return;

            }

            moves += path;

            if (IsExit(array,row,coll))
            {
                Console.WriteLine(moves);
                return;

            }

            array[row, coll] = 'v';



            FindAllPathsInLabyirint(array, row, coll+1, "R",moves);
            FindAllPathsInLabyirint(array, row, coll-1, "L",moves);
            FindAllPathsInLabyirint(array, row+1, coll, "D",moves);
            FindAllPathsInLabyirint(array, row-1, coll, "U",moves);

            array[row, coll] = '-';



           





        }

        private static bool IsExit(char[,] array, int row, int coll)
        {
            return array[row, coll] == 'e';
        }

        private static bool IsVisited(char[,] array, int row, int coll)
        {
            return array[row, coll] == 'v';
        }

        private static bool IsWall(char[,] array, int row, int coll)
        {
            return array[row, coll] == '*';
        }

        public static bool IsOutside(char[,] array, int row, int coll)
        {
            return row < 0 || row>=array.GetLength(0)||coll<0||coll >= array.GetLength(1);
        }



        public static void PrintArray(char[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i,j]);
                }

                Console.WriteLine();

            }
        }

        private static void FillArray(char[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                var input = Console.ReadLine();
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = input[j];

                }

            }
        }

        public static int RecursiveFactorial(int n)
        {
            if (n<=0)
            {
                return 1;

            }

            return n * RecursiveFactorial(n - 1);
        }

        public static void CreateVectors(int[] array,int index)
        {
            if (index==array.Length)
            {
                Console.WriteLine(String.Join("",array));
                return;

            }

            for (int i = 0; i <= 1; i++)
            {
                array[index] = i;
                CreateVectors(array, index + 1);

            }
            

        }

        public static void RecursiveDrawing(int n)
        {
            if (n<=0)
            {
                return;

            }

            Console.WriteLine(new string('*',n));
            RecursiveDrawing(n - 1);
            Console.WriteLine(new string('#', n));


        }

        public static int GetSum(int[] array, int index)
        {
            if (index==array.Length)
            {
                return 0;

            }


            return array[index] +GetSum(array,index+1);
        }
    }
}
