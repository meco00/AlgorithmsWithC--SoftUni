using System;
using System.IO;
using System.Linq;

namespace Combinations
{
    class Program
    {
        static string[] permutations;
        static string[] array;
        static int k;

        static void Main(string[] args)
        {
            array = Console.ReadLine().Split().ToArray();

            k =int.Parse(Console.ReadLine());

            permutations = new string[k];

            CombinationsWithoutRepetition(0, 0);
        }

        private static void CombinationsWithoutRepetition(int combineIndex, int startIndex)
        {
            if (combineIndex >= permutations.Length)
            {
                Console.WriteLine(String.Join(" ", permutations));
                return;

            }

            for (int i = startIndex; i < array.Length; i++)
            {

                permutations[combineIndex] = array[i];

                CombinationsWithoutRepetition(combineIndex+1,i);

            }
        }
    }
}
