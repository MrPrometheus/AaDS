using System;
using AlgorithmsDataStructuresLibrary;

namespace ArrayLinearList132
{
    internal class Program
    {
        private static ArrayList132<int> _intList;
        private static ArrayList132<string> _stringList;
        private static int _size;
        
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите размер списка");
                if (Int32.TryParse(Console.ReadLine(), out _size))
                {
                    Console.WriteLine("С каким типом данных хотите работать int - 1, string - 2");
                    switch (Console.ReadKey().Key)
                    {
                        case ConsoleKey.D1: 
                            _intList = new ArrayList132<int>(_size);
                            break;
                        case ConsoleKey.D2: 
                            _stringList = new ArrayList132<string>(_size);
                            break;
                    }
                    break;
                }
                
                Console.WriteLine("Ошибка ввода");
            }

            if (_intList != null)
            {
                while (true)
                {
                    Console.WriteLine("\n1) Добавить число\n" +
                                      "2) Удалить число\n" +
                                      "3) Вывести список\n" +
                                      "4) Выход");
                    int number;
                    if (!Int32.TryParse(Console.ReadLine(), out number)) continue;
                    switch (number)
                    {
                        case 1:
                            if (_intList.IsFull)
                            {
                                Console.WriteLine("Список переполнен");
                                break;
                            }
                            Console.WriteLine("Введите число");
                            int num;
                            if (Int32.TryParse(Console.ReadLine(), out num))
                            {
                                _intList.Add(num);
                                Console.WriteLine($"Элемент {num} добавлен");
                            }
                            else
                            {
                                Console.WriteLine("Ошибка ввода");
                            }
                            break;
                        case 2:
                            if (_intList.Count == 0)
                            {
                                Console.WriteLine("Список пуст");
                                break;
                            }
                            Console.WriteLine("Введите число, которое хотите удалить");
                            int numm;
                            if (Int32.TryParse(Console.ReadLine(), out numm))
                            {
                                if (!_intList.Contains(numm))
                                {
                                    Console.WriteLine($"Элемента {numm} нет в списке");
                                    break;
                                }
                                _intList.Remove(numm);
                                Console.WriteLine($"Элемент {numm} удален");
                            }
                            else
                            {
                                Console.WriteLine("Ошибка ввода");
                            }
                            break;
                        case 3:
                            Console.WriteLine("Элементы списка:");
                            Console.WriteLine("------Начало-----");
                            foreach (var item in _intList)
                            {
                                Console.WriteLine(item);
                            }
                            Console.WriteLine("----------------");
                            break;
                        case 4: 
                            Environment.Exit(0);
                            break;
                    }
                }
            }
            else
            {
                while (true)
                {
                    Console.WriteLine("\n1) Добавить Строку\n" +
                                      "2) Удалить строку\n" +
                                      "3) Вывести список\n" +
                                      "4) Выход");
                    int number;
                    if (!Int32.TryParse(Console.ReadLine(), out number)) continue;
                    switch (number)
                    {
                        case 1:
                            if (_stringList.IsFull)
                            {
                                Console.WriteLine("Список переполнен");
                                break;
                            }
                            Console.WriteLine("Введите строку");
                            _stringList.Add(Console.ReadLine());
                            break;
                        case 2:
                            if (_stringList.Count == 0)
                            {
                                Console.WriteLine("Список пуст");
                                break;
                            }
                            Console.WriteLine("Введите строку, которое хотите удалить");
                            var str = Console.ReadLine();
                            if (!_stringList.Contains(str))
                            {
                                Console.WriteLine($"Строки '{str}' нет в списке");
                                break;
                            }
                            _stringList.Remove(str);
                            break;
                        case 3:
                            Console.WriteLine("Элементы списка:");
                            Console.WriteLine("---------------");
                            foreach (var item in _stringList)
                            {
                                Console.WriteLine(item);
                            }
                            Console.WriteLine("----------------");
                            break;
                        case 4: 
                            Environment.Exit(0);
                            break;
                    }
                }
            }
        }
    }
}