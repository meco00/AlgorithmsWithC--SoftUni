using System;
using System.IO;
using System.Linq;

namespace AlgorithmsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr =Console.ReadLine().Split().Select(int.Parse).ToArray();

            // int Sum = Recursion(arr, 0);

            // Console.WriteLine(Factorial(5));

            Console.WriteLine(Factorial(int.Parse(Console.ReadLine())));

        }
        private static int Recursion(int [] arr,int startIndex)
        {
            if (startIndex==arr.Length-1)
            {
                return arr[startIndex];

            }

            return  arr[startIndex]+ Recursion(arr,startIndex + 1);

        }

        private static int Factorial(int n)
        {

            if (n==0)
            {
                return 1;

            }

            return n * Factorial(n - 1);

        }

    }
}
