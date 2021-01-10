using System;
using System.IO;
using System.Linq;

namespace RecursionAndCombinatorialProblemsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var array =Console.ReadLine().Split().ToArray();

            ReverseWithRecursion(0, array);
        }

        private static void ReverseWithRecursion(int index, string[] array)
        {
            if (index>=array.Length/2)
            {
                Console.WriteLine(String.Join(" ",array));
                return;
            }

            int secondIndex = array.Length - 1 - index;

            Swap(index, secondIndex, array);

            ReverseWithRecursion(index + 1, array);

        }

        private static void Swap(int index, int secondIndex, string[] array)
        {
            string temp = array[index];

            array[index] = array[secondIndex];
            array[secondIndex] = temp;
        }
    }
}
