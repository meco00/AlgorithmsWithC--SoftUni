using System;
using System.IO;
using System.Linq;

namespace CombinatorialProblems
{
    class Program
    {
        static string[] permutations;
        static string[] array;

        static void Main(string[] args)
        {
             array = Console.ReadLine().Split().ToArray();

            var used = new bool[array.Length];

            permutations = new string[array.Length];

           // PermutationWithoutRepetition(used, 0);

            OptimizePermutation(0);

        }

        private static void OptimizePermutation(int index)
        {
            if (index >= array.Length)
            {
                Console.WriteLine(String.Join(" ", array));
                return;
            }

            OptimizePermutation(index + 1);

            for (int i = index + 1; i < array.Length; i++)
            {


                Swap(index, i);
               

                OptimizePermutation( index+1);

                Swap(index, i);




            }
        }

        private static void Swap(int firstIndex, int secondIndex)
        {
            string temp = array[firstIndex];

            array[firstIndex] = array[secondIndex];
            array[secondIndex] = temp;
        }

        private static void PermutationWithoutRepetition(bool[] used, int index)
        {
            if (index == array.Length)
            {
                Console.WriteLine(String.Join(" ", permutations));
                return;
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (!used[i])
                {
                    used[i] = true;
                    permutations[index] = array[i];

                    PermutationWithoutRepetition( used, index + 1);

                    used[i] = false;


                }

            }
        }
    }
}
