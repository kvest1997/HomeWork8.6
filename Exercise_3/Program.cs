using System;
using System.Collections.Generic;

namespace Exercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> kitValues = new HashSet<int>();
            do
            {
                int temp;
                    temp = int.Parse(Console.ReadLine());                
                    
                if (kitValues.Add(temp))
                {
                    Console.WriteLine($"Число {temp} успешно сохранено");
                }
                else
                    Console.WriteLine("Такое число уже есть!!!");
            } while (true);
        }
    }
}
