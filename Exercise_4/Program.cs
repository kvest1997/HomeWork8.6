using System;
using System.Collections.Generic;

namespace Exercise_4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Start();
        }


        private static void Start()
        {
            List<Person> listPerson = new List<Person>();
            char choose;
            XMLCreator xmlCreator = new XMLCreator(listPerson);

            do
            {
                Console.Clear();

                string _fio;
                string _streetAddress;
                int _houseNumber;
                int _flatNumber;
                int _mobilePhone;
                int _flatPhone;


                Console.Write("Введите ФИО: ");
                _fio = Console.ReadLine();

                Console.Write("Введите название улицы: ");
                _streetAddress = Console.ReadLine();

                Console.Write("Введите номер дома: ");
                _houseNumber = int.Parse(Console.ReadLine());

                Console.Write("Введите номер квартиры: ");
                _flatNumber = int.Parse(Console.ReadLine());

                Console.Write("Введите номер сотового телефона: ");
                _mobilePhone = int.Parse(Console.ReadLine());

                Console.Write("Введите номер домашнего телефона: ");
                _flatPhone = int.Parse(Console.ReadLine());

                listPerson.Add(new Person(_fio, _streetAddress, _houseNumber, _flatNumber, _mobilePhone, _flatPhone));

                Console.Write("Добавить нового пользователя?(Y - да\\N - нет): ");


                while (!char.TryParse(Console.ReadLine(), out choose))
                {
                    Console.WriteLine("Ошибка ввода");
                }

                char.ToLower(choose);
            } while (choose != 'n');


            xmlCreator.SerializationPersonList(@"Person.xml");
        }
    }
}
