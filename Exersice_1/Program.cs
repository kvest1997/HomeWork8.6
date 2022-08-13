using System;
using System.Collections.Generic;

namespace Exercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listTest = new List<int>();

            listTest = ListFilling();

            ListPrint(listTest);

            Console.WriteLine("\n-------------------");

            listTest = DeleteToElementList(listTest);
            Console.WriteLine("\n-------------------");

            ListPrint(listTest);

            Console.ReadKey();
        }

        private static List<int> ListFilling()
        {
            List<int> list = new List<int>();
            Random rand = new Random();

            for (int i = 0; i < 100; i++)
            {
                list.Add(rand.Next(0, 100));
            }

            return list;
        }

        private static void ListPrint(List<int> list)
        {
            foreach (var item in list)
            {
                Console.Write($"{item} ");
            }
        }

        private static List<int> DeleteToElementList(List<int> list)
        {
            List<int> tempList = new List<int>();

            Console.WriteLine("Удаленные числа");
            foreach (var item in list)
            {
                if (!(item > 25 && item < 50))
                {
                    tempList.Add(item);
                }
                else
                    Console.Write($"{item} ");
            }

            return tempList;
        }
    }
}
