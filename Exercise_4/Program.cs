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
            XMLCreator xmlCreator = new XMLCreator(listPerson);

            Console.WriteLine(@"1. Добавить
2. Показать");

            int switcher = int.Parse(Console.ReadLine());

            switch (switcher)
            {
                case 1: Go(listPerson, xmlCreator); break;
                case 2: PrintList(); break;
            }

            Console.ReadKey();

        }

        static void Go(List<Person> listPerson, XMLCreator xmlCreator)
        {
            bool isExit = false;

            do
            {
                Console.Clear();

                string _fio;
                string _streetAddress;
                int _houseNumber;
                int _flatNumber;
                long _mobilePhone;
                int _flatPhone;
                char choose;


                Console.Write("Введите ФИО: ");
                _fio = Console.ReadLine();

                Console.Write("Введите название улицы: ");
                _streetAddress = Console.ReadLine();

                Console.Write("Введите номер дома: ");
                _houseNumber = int.Parse(Console.ReadLine());

                Console.Write("Введите номер квартиры: ");
                _flatNumber = int.Parse(Console.ReadLine());

                Console.Write("Введите номер сотового телефона: ");
                _mobilePhone = long.Parse(Console.ReadLine());

                Console.Write("Введите номер домашнего телефона: ");
                _flatPhone = int.Parse(Console.ReadLine());


                listPerson.Add(new Person(_fio, _streetAddress, _houseNumber, _flatNumber, _mobilePhone, _flatPhone));

                Console.Write("Добавить нового пользователя?(Y - да\\N - нет): ");

                do
                {
                    while (!char.TryParse(Console.ReadLine(), out choose))
                    {
                        char.ToLower(choose);
                        Console.WriteLine("Ошибка ввода");
                    }

                    if (choose == 'y')
                    {
                        isExit = false;
                    }
                    else if (choose == 'n')
                    {
                        isExit = true;
                    }
                    else
                        Console.WriteLine("Неправильный символ");

                } while ((choose == 'n' || choose != 'y') &&
                            (choose != 'n' || choose == 'y'));

            } while (!isExit);


            xmlCreator.SerializationPersonList(@"Person.xml");
        }

        static void PrintList()
        {
            XMLCreator xmlPrint = new XMLCreator();

            foreach (var item in xmlPrint.DeserializationPersonList(@"Person.xml"))
            {
                Console.WriteLine($"{item.FIO}");
            }


        }
    }
}
