using System;
using System.IO;

namespace NestedLoopToRecursion
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int n =int.Parse(Console.ReadLine());

            var array = new int[n];

            

            RecursiveLoop(0,array);
        }

        private static void RecursiveLoop(int index,int[] array)
        {
            if (index>=array.Length)
            {
                Console.WriteLine(String.Join(" ",array));
                return;
            }

            for (int i = 1; i <= array.Length; i++)
            {
                
                
                    array[index] = i;
                    RecursiveLoop(index+1, array);
                   

            }
            
        }
    }
}
