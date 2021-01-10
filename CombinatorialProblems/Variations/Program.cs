using System;
using System.IO;
using System.Linq;

namespace Variations
{
    class Program
    {
        static string[] permutations;
        static string[] array;
        static int k;
        static bool[] used;

        static void Main(string[] args)
        {
            array = Console.ReadLine().Split().ToArray();

            k =int.Parse(Console.ReadLine());

            used = new bool[array.Length];

            permutations = new string[k];

            // VariationsWithoutRepetitions(0);

            VariationsWithRepetitons(0);

        }

        private static void VariationsWithRepetitons(int index)
        {
            if (index >= permutations.Length)
            {
                Console.WriteLine(String.Join(" ", permutations));
                return;

            }

            for (int i = 0; i < array.Length; i++)
            {
                
                
                   
                    permutations[index] = array[i];

                    VariationsWithRepetitons(index + 1);

                   




                

            }
        }

        private static void VariationsWithoutRepetitions(int index)
        {
            if (index>=permutations.Length)
            {
                Console.WriteLine(String.Join(" ",permutations));
                return;

            }

            for (int i = 0; i < array.Length; i++)
            {
                if (!used[i])
                {
                    used[i] = true;
                    permutations[index] = array[i];

                    VariationsWithoutRepetitions(index + 1);

                    used[i] = false;




                }

            }
        }
    }
}
