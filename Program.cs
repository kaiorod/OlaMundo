using System;

namespace OlaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Olá usuário, eu me chamo ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("Caio!");
            Console.ResetColor();
        }
    }
}
