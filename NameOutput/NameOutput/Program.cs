using System;

namespace NameOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            string setName;
            string setSymbol;
            int quantity = 0;
            int addTwo = 2;

            Console.WriteLine("Введите ваше имя");
            setName = Console.ReadLine();
            quantity += addTwo + setName.Length;

            Console.WriteLine("Введите символ");
            setSymbol = Console.ReadLine();
     
            Console.Clear();

            for (int i = 0; i < quantity; i++)
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

            for (int i = 0; i < quantity; i++)
            {
                Console.Write($"{setSymbol}");
            }

            Console.WriteLine();
        }
    }
}
