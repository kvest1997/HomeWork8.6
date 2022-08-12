using System;
using System.Collections.Generic;

namespace Exercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<PhoneBook> listPhoneBook = EnterPhoneBook();
            Dictionary<long, string> PhoneBook = new Dictionary<long, string>();

            foreach (var item in listPhoneBook)
            {
                PhoneBook.Add(item.NumberPhone, item.FIO);
            }

            Console.Clear();

            foreach (var item in PhoneBook)
            {
                Console.WriteLine($"ФИО - {item.Value} \nНомер телефона - {item.Key}");
            }

            Console.ReadKey();
            Console.Clear();

            Console.Write("Введите номер телефона, что бы найти владельца: ");
            long searchNumber = long.Parse(Console.ReadLine());

            FoundUser(PhoneBook, searchNumber);

            Console.ReadKey();
        }

        private static List<PhoneBook> EnterPhoneBook()
        {
            List<PhoneBook> list = new List<PhoneBook>();
            Dictionary<int, string> PhoneBook = new Dictionary<int, string>();

            bool isExit = false;

            do
            {
                Console.Clear();

                Console.Write("Введите ФИО: ");
                string fio = Console.ReadLine();

                Console.Write("Введите номер телефона: ");
                string numberPhone = Console.ReadLine();

                if (fio != "" && numberPhone != "")
                    list.Add(new PhoneBook(long.Parse(numberPhone), fio));
                else
                    isExit = true;

            } while (!isExit);

            return list;
        }

        private static void FoundUser(Dictionary<long, string> PhoneBook, long numberPhone)
        {
            string result = "";

            if (PhoneBook.TryGetValue(numberPhone, out result))
            {
                Console.WriteLine($"{result}");
            }
            else
                Console.WriteLine("Такого пользователя нет");
        }
    }
}
