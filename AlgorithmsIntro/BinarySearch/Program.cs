using System;
using System.IO;
using System.Linq;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr =Console.ReadLine().Split().Select(int.Parse).ToArray();
            int search =int.Parse(Console.ReadLine());


            int index = IndexOfBinary(arr, search);

            Console.WriteLine(index);

        }

        public static int IndexOfBinary(int[] arr,int key)
        {
            int lo = 0;
            int hi = arr.Length - 1;


            int middle = hi / 2;
            while (lo<hi)
            {

                if (key<arr[middle])
                {
                    middle--;
                    

                }
                else if (key>arr[middle])
                {
                    middle++;
                }
                else
                {
                    return middle;
                }



            }


            return -1;

        }
    }
}
