using System;

namespace NameOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            string setName;
            string setSymbol;
            int sum = 0;
        
            Console.WriteLine("Введите ваше имя");
            setName = Console.ReadLine();

            Console.WriteLine("Введите символ");
            setSymbol = Console.ReadLine();

            sum += (setSymbol.Length + setSymbol.Length) + setName.Length;

            Console.Clear();

            for (int i = 0; i < sum; i++)
            {
                Console.Write($"{setSymbol}");
            }

            Console.WriteLine();
            Console.Write(setSymbol);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(setName);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(setSymbol);
            Console.WriteLine();

            for (int i = 0; i < sum; i++)
            {
                Console.Write($"{setSymbol}");
            }

            Console.WriteLine();
        }
    }
}
