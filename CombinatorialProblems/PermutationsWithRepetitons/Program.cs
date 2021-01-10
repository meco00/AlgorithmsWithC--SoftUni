using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PermutationsWithRepetitons
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

            PermutationsWithRepetiton(0);

           
        }

        private static void PermutationsWithRepetiton( int index)
        {
            if (index>=array.Length)
            {
               
                Console.WriteLine(String.Join(" ",array));
                return;
            }

            PermutationsWithRepetiton(index + 1);

            var swapped = new HashSet<string> { array[index] };
            

            for (int i = index+1; i < array.Length; i++)
            {
                if (!swapped.Contains(array[i]))
                {
                    Swap(index, i);
                    PermutationsWithRepetiton(index + 1);
                    Swap(index, i);
                    swapped.Add(array[i]);
                }




            }
        }

        private static void Swap(int firstIndex, int secondIndex)
        {
            string temp = array[firstIndex];

            array[firstIndex] = array[secondIndex];
            array[secondIndex] = temp;
        }
    }
}
