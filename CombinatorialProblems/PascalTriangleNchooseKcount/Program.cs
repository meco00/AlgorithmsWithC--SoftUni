using System;
using System.IO;

namespace PascalTriangleNchooseKcount
{
    class Program
    {
        static void Main(string[] args)
        {
            int n =int.Parse(Console.ReadLine());
            int k =int.Parse(Console.ReadLine());

            Console.WriteLine(GetBinom(n,k));
        }

        private static int GetBinom(int row, int coll)
        {
            if (row==0||row==1||coll==0||coll==row)
            {
                return 1;

            }

            return GetBinom(row - 1, coll - 1) + GetBinom(row - 1, coll);
        }
    }
}
