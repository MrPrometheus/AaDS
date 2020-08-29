using System;
using System.Linq;
using AlgorithmsDataStructuresLibrary;

namespace CircleArrayQueue125
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CAQueue125<int> queue;
            while (true)
            {
                Console.WriteLine("Введите размер очереди");
                var str = Console.ReadLine();
                int number;
                if(Int32.TryParse(str, out number))
                {
                    if (number < 0)
                    {
                        Console.WriteLine("Число должно быть больше 0");
                        continue;
                    }
                    queue = new CAQueue125<int>(number);
                    break;
                }
                else
                {
                    Console.WriteLine("Введите число");
                }
            }

            InitialText();

            while (true)
            {
                Console.WriteLine("Доступные команды:\n" +
                    "1) Добавить элемент в очередь.\n" +
                    "2) Удалить элемент.\n" +
                    "3) Печать очереди.\n" +
                    "4) Выйти из программы.\n");
                switch (Console.ReadLine())
                {
                    case "1":  // Меню добавление элемента  
                        if (queue.IsFull())
                        {
                            Console.WriteLine("Очередь заполнена");
                            break;
                        }
                        Console.WriteLine("Введите чилсо, которое хотите довавить в очередь");
                        var str = Console.ReadLine();
                        int number;
                        if (Int32.TryParse(str, out number))
                        {
                            queue.Enqueue(number);
                        }
                        else
                        {
                            Console.WriteLine("Введите число");
                        }
                        break;
                    case "2":    // удаление элемента
                        Console.WriteLine($"элемент {queue.Dequeue()} был удален из очереди");
                        break;
                    case "3": // Печать
                        PrintQueue(queue);
                        break;
                    case "4": // Выход из программы
                        Console.WriteLine("Программа закрыта.");
                        Environment.Exit(0);
                        break;
                }
            }
        }
        private static void PrintQueue(CAQueue125<int> items)
        {
            if (items.Count == 0)
            {
                Console.WriteLine("Очередь пуста");
                return;
            }

            int maxlen = items.Max().ToString().Length;
            var start = "Начало";
            if(maxlen < start.Length)
            {
                maxlen = start.Length;
            }

            var diff1 = (maxlen - start.Length) / 2;
            Console.Write(@"\");
            for (int i = 0; i < diff1; i++)
            {
                Console.Write(" ");
            }
            Console.Write(start);
            for (int i = diff1 + start.Length; i < maxlen; i++)
            {
                Console.Write(" ");
            }
            Console.Write("/\n");

            foreach (var item in items)
            {
                var diff = (maxlen - item.ToString().Length) / 2;
                Console.Write("|");
                for (int i = 0; i < diff; i++)
                {
                    Console.Write(" ");
                }
                Console.Write(item.ToString());
                for (int i = diff + item.ToString().Length; i < maxlen; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("|\n");
            }
        }

        private static void InitialText()
        {
            Console.WriteLine("Программа работет только с целочисленными значениями.");
            Console.WriteLine("Очередь типа int создан.");
        }
    }
}