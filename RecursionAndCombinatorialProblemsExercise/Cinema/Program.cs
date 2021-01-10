using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Cinema
{
    class Program
    {
        public static string[] permutations ;
        public static HashSet<int> lockedSeats;
        private static string[] seats;



       
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(", ").ToList();

            seats = new string[list.Count];

            lockedSeats = new HashSet<int>();


            while (true)
            {
                string input = Console.ReadLine();

                if (input == "generate")
                {
                    break;
                }

                var command = input.Split(" - ").ToArray();

              list.Remove(command[0]);


                seats[int.Parse(command[1])-1] = command[0];
                lockedSeats.Add(int.Parse(command[1])-1);


            }

            

            permutations = new string[list.Count];


            GeneratePlaces(list, 0);




        }

        private static void GeneratePlaces(List<string> list,  int index)
        {
            if (index>=list.Count)
            {
                int indX = 0;
                for (int i = 0; i < seats.Length; i++)
                {
                    if (lockedSeats.Contains(i))
                    {
                        continue;
                    }


                    seats[i] = list[indX++];
                    
                   


                }
                Console.WriteLine(String.Join(" ",seats));
                return;

            }

            GeneratePlaces(list,  index + 1);
            for (int i = index+1; i < list.Count; i++)
            {
                Swap(index, i,list);

                GeneratePlaces(list, index + 1);
                Swap(index, i,list);

            }
        }

        private static void Swap(int index, int i, List<string> list)
        {
            string temp = list[index];
            list[index] = list[i];
            list[i] = temp;
        }
    }

}

