using System;
using System.Linq;
using AlgorithmsDataStructuresLibrary;

namespace DynamicQueue127
{
    internal class Program
    {
        private const int START_RANGE_RANDOMIZE_ENQUEUE = 1;
        private const int END_RANGE_RANDOMIZE_ENQUEUE = 3;
        
        private const int START_RANGE_RANDOMIZE_DEQUEUE = 1;
        private const int END_RANGE_RANDOMIZE_DEQUEUE = 3;
        
        public static void Main(string[] args)
        {
            Queue127<char> queue = new Queue127<char>();
            Random rnd = new Random();
            Console.WriteLine("Объект Random сгенерирован");
            Console.WriteLine("Очередь типа char создана.");

            while (true)
            {
                if (rnd.Next(1, 100) % 2 == 0)
                {
                    int count = rnd.Next(START_RANGE_RANDOMIZE_ENQUEUE, END_RANGE_RANDOMIZE_ENQUEUE);
                    for (int i = 0; i < count; i++)
                    {
                        char element= (char) rnd.Next(65, 91);
                        queue.Enqueue(element);
                        Console.WriteLine($"Добавлен в очередь: {element}");
                    }
                }
                else
                {
                    int count = rnd.Next(START_RANGE_RANDOMIZE_DEQUEUE, END_RANGE_RANDOMIZE_DEQUEUE);
                    for (int i = 0; i < count; i++)
                    {
                        if (queue.IsEmpty) break;
                        Console.WriteLine($"Удален из очереди: {queue.Dequeue().Data}");
                    }
                }
                Console.WriteLine("Очередь:");
                PrintQueue(queue);

                Console.WriteLine("Если хотите завершить, нажмите 'q', иначе enter");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.Q:
                        Environment.Exit(0);
                        break;
                    case ConsoleKey.Enter: 
                        break;
                }
            }
        }
        
        private static void PrintQueue(Queue127<char> items)
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
    }
}