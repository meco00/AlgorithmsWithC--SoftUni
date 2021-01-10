using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {

            //  int[] array = Console.ReadLine().Split().Select(int.Parse).OrderBy(x => x).ToArray();


            List<int> list = new List<int>()
            {
               3,5,2,1,8
            };

            // int key = int.Parse(Console.ReadLine());

            // Console.WriteLine(BinarySearch(array, 0, array.Length, key));


            var sorted = Program.Quicksort(list);

            Console.WriteLine(String.Join(", ",sorted));


        }

        private static List<int> MergeSort(List<int> list)
        {
            if (list.Count<=1)
            {
                return list;

            }

            int middle = list.Count / 2;
            List<int> leftList = MergeSort(list.GetRange(0, middle));
            List<int> rightList = MergeSort(list.GetRange(middle, list.Count-middle));


            return CombineArrays(leftList, rightList);
        }

        private static List<int> CombineArrays(List<int> left,List<int> right)
        {
            List<int> result = new List<int>();
            int leftIndex = 0;
            int rightIndex = 0;
            while (leftIndex<left.Count&&rightIndex<right.Count)
            {
                if (left[leftIndex]<right[rightIndex])
                {

                    result.Add(left[leftIndex]);
                    leftIndex++;
                }
                else
                {
                    result.Add(right[rightIndex]);
                    rightIndex++;
                }


            }

            for (int i = leftIndex; i < left.Count; i++)
            {
                result.Add(left[i]);

            }
            
            for (int i = rightIndex; i < right.Count; i++)
            {
                result.Add(right[i]);
            }

            return result;



        }
       
        


        static List<int> Quicksort(List<int> array)
        {
            if (array.Count==0)
            {
                return new List<int>();

            }
            int pivot = array[0];
            List<int> leftArray = new List<int>();
           
            List<int> rightArray = new List<int>();

            for (int i = 0; i < array.Count; i++)
            {
                if (array[i]<pivot)
                {
                    leftArray.Add(array[i]);


                }
                if (array[i]>pivot)
                {
                    rightArray.Add(array[i]);

                }

            }
            var leftSorted = Quicksort(leftArray);
            var rightSorted = Quicksort(rightArray);

            return leftSorted.Concat(new List<int>() {pivot}).Concat(rightSorted).ToList();


        }
        



     



        private static int BinarySearch(int[] array, int start, int end, int key)
        {

            if (start > end)
            {
                return -1;

            }

            int middle = (start + end-1) / 2;



            if (key < array[middle])
            {

                return BinarySearch(array, start, middle - 1, key);


            }
            else if (key > array[middle])
            {
                return BinarySearch(array, middle + 1, end, key);

            }
            else
            {
                return middle;
            }
        }
    }
}
