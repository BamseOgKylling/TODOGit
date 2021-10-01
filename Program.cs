using System;
using static System.Console;
using System.Threading;

namespace TODOGit
{
    class Program
    {
        static void Main(string[] args)
        {

            bool applicationRunning = true;

            do
            {
                CursorVisible = false;

                WriteLine("1. Add task");
                WriteLine("2. List tasks");
                WriteLine("3. Exit");

                ConsoleKeyInfo input;
                bool invalidChoice;

                do
                {
                    input = ReadKey(true);

                    invalidChoice = !(input.Key == ConsoleKey.D1 || input.Key == ConsoleKey.NumPad1
                        || input.Key == ConsoleKey.D2 || input.Key == ConsoleKey.NumPad2
                        || input.Key == ConsoleKey.D3 || input.Key == ConsoleKey.NumPad3);

                } while (invalidChoice);

                CursorVisible = true;

                Clear();

                switch (input.Key)
                {
                    case ConsoleKey.D1:

                        break;

                    case ConsoleKey.D2:

                        break;

                    case ConsoleKey.D3:
                        applicationRunning = false;
                        break;
                }

                Clear();

            } while (applicationRunning);
                
        }
    }
}
