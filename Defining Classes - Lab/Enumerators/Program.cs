namespace Enumerators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int row = 0;
            int col = 0;
            int direction = 0;

            while (true)
            {
                Console.SetCursorPosition(row, col);
                Console.WriteLine("@");

                Thread.Sleep(50);

                if (direction == 0)
                {
                    row++;
                }
                if (direction == 1)
                {
                    col++;
                }
                if (direction == 2)
                {
                    col--;
                }
                if (direction == 3)
                {
                    row--;
                }

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();

                    if (key.Key == ConsoleKey.RightArrow) 
                    {
                        direction = 0;
                    }
                    if (key.Key == ConsoleKey.LeftArrow)
                    {
                        direction = 3;
                    }
                    if (key.Key == ConsoleKey.DownArrow)
                    {
                        direction = 1;
                    }
                    if (key.Key == ConsoleKey.UpArrow)
                    {
                        direction = 2;
                    }
                }

                Console.Clear();
            }
        }
    }
}