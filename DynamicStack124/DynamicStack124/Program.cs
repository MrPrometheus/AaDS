using System;
using System.Linq;
using System.Threading;
using AlgorithmsDataStructuresLibrary;

namespace DynamicStack124
{
    internal class Program
    {
        private static Stack124<int> stack = new Stack124<int>();
        private static Stack124<int> delStack = new Stack124<int>();
        
        public static void Main(string[] args)
        {
            InitialText();
            while (true)
            {
                Console.WriteLine(Menu.PrintMainMenu());
                switch (Console.ReadLine())
                {
                    case "1":  // Меню добавление элемента
                        bool exitLoop = false;
                        while (!exitLoop)
                        {
                            Console.WriteLine(Menu.PrintAddMenu()); 
                            switch (Console.ReadLine())
                            {
                                case "1":
                                    Console.WriteLine(Menu.PrintAddMenuNew());
                                    int item;
                                    switch (Console.ReadLine())
                                    {
                                        case "1":
                                            Console.WriteLine(Menu.PrintAddNewElement());
                                            
                                            if (!Int32.TryParse(Console.ReadLine(), out item))
                                            {
                                                Console.WriteLine("Элемент не распознан, введите целочисленное значение.");
                                                continue;
                                            }
                                            stack.Push(item);
                                            exitLoop = true;
                                            break;
                                        case "2":
                                            Console.WriteLine("Введите количество добавляемых элементов(элементы будут созданы рандомно)");
                                            var items = Console.ReadLine();
                                            int itemm;
                                            if (!Int32.TryParse(items, out itemm))
                                            {
                                                Console.WriteLine("Элементы не распознаны, введите целочисленноы значения.");
                                                break;
                                            }
                                            foreach (var obj in items.Split(' '))
                                            {
                                                stack.Push(Int32.Parse(obj));
                                            }

                                            for (int i = 0; i < itemm-1; i++)
                                            {
                                                stack.Push(new Random().Next(-200, 201));
                                                Thread.Sleep(15);
                                            }
                                            break;
                                        case "3":
                                            break;
                                    }
                                    break;
                                case "2":
                                    if (delStack.Count == 0)
                                    {
                                        Console.WriteLine("Вспомогательный стек пуст");
                                        exitLoop = true;
                                        break;
                                    }
                                    var tempNode = delStack.Pop();
                                    stack.PushNode(tempNode);
                                    
                                    Console.WriteLine($"Верхний элемент {tempNode.Data} из встпомогательного стека добавлен в основнйо стек");
                                    exitLoop = true;
                                    break;
                                case "3": 
                                    exitLoop = true;
                                    break;
                            }
                        }
                        break;
                    case "2":    // Меню удаления элемента
                        exitLoop = false;
                        while (!exitLoop)
                        {
                            Console.WriteLine(Menu.PrintDelMenu());
                            switch (Console.ReadLine())
                            {
                                case "1":
                                    Console.WriteLine(Menu.PrintDelForeverMenu());
                                    switch (Console.ReadLine())
                                    {
                                        case "1":
                                            Console.WriteLine(Menu.PrintDelForever());
                                            if (stack.IsEmpty)
                                            {
                                                Console.WriteLine("Стек и так пуст.");
                                                break;
                                            }
                                            stack.Pop();
                                            exitLoop = true;
                                            break;
                                        case "2":
                                            Console.WriteLine("Введите количество элементов, которые хотите удалить.");
                                            var str = Console.ReadLine();
                                            int count;
                                            if(!Int32.TryParse(str, out count))
                                            {
                                                Console.WriteLine("Введите число");
                                                break;
                                            }
                                            Console.WriteLine(Menu.PrintDelRangeForever());
                                            while(!stack.IsEmpty && count-- > 0)
                                            {
                                                Console.Write(stack.Pop());
                                                Console.Write(" ");
                                            }
                                            Console.Write("\n");
                                            exitLoop = true;
                                            break;
                                        case "3":
                                            exitLoop = true;
                                            break;
                                    }
                                    break;
                                case "2":
                                    Console.WriteLine(Menu.PrintDelTemporarilyMenu());
                                    switch (Console.ReadLine())
                                    {
                                        case "1":
                                            Console.WriteLine(Menu.PrintDelTemporarily());
                                            delStack.PushNode(stack.Pop());
                                            break;
                                        case "2":
                                            Console.WriteLine("Введите количество элементов, которые хотите удалить.");
                                            var str = Console.ReadLine();
                                            int count;
                                            if (!Int32.TryParse(str, out count))
                                            {
                                                Console.WriteLine("Введите число");
                                                break;
                                            }
                                            Console.WriteLine(Menu.PrintDelRangeTemporarily());
                                            while (!stack.IsEmpty && count-- > 0)
                                            {
                                                delStack.PushNode(stack.Pop());
                                                Console.Write(delStack.Peek());
                                                Console.Write(" ");
                                            }
                                            Console.Write("\n");
                                            exitLoop = true;
                                            break;
                                        case "3":
                                            break;
                                    }
                                    exitLoop = true;
                                    break;
                                case "3":
                                    exitLoop = true;
                                    break;
                            }
                        }
                        break;
                    case "3": // Вывод основного стека
                        Console.WriteLine(Menu.PrintOutputMainStack());
                        PrintStack(stack);
                        break;
                    case "4": // Вывод стека удаленных элементов
                        Console.WriteLine(Menu.PrintOutputRemevedStack());
                        PrintStack(delStack);
                        break;
                    case "5":
                        Console.WriteLine("Программа закрыта.");
                        Environment.Exit(0); 
                        break;
                }
            }
        }
        
        private static void PrintStack(Stack124<int> items)
        {
            if (items.Count == 0)
            {
                Console.WriteLine("Стек пуст");
                return;
            }
            int maxlen = items.Max().ToString().Length;
                        
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
            Console.Write(@"\");
            for (int i = 0; i < maxlen; i++)
            {
                Console.Write("-");
            }
            Console.Write("/\n");
        }

        private static void InitialText()
        {
            Console.WriteLine("Программа работет только с целочисленными значениями.");
            Console.WriteLine("Стек типа int создан.");
        }
    }
}