using System;
using System.IO;

namespace CombinationsExercise
{
    class Program
    {
        private static string[] array;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            array = new string[k];

          
            CombinationWithRepetition(0,1, k,n);


        }

        private static void CombinationWithRepetition(int combIndex,int index, int k,int n)
        {
            if (combIndex>=k)
            {
                Console.WriteLine(String.Join(" ",array));
                return;

            }

            for (int i = index; i <= n; i++)
            {
                array[combIndex] = i.ToString();
                //if u wanna combine without repetition just remove '+1; after i 
                CombinationWithRepetition(combIndex + 1, i+1,k,n);

            }
        }
    }
}
