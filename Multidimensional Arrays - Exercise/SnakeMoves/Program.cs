internal class Program
{
    private static void Main(string[] args)
    {
        int[] rowsAndColsData = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int rows = rowsAndColsData[0];
        int cols = rowsAndColsData[1];

        string snake = Console.ReadLine();

        Queue<char> symbols = new Queue<char>();

        char[,] matrixSnake = new char[rows, cols];

        int snakeIndex = 0;

        for (int row = 0; row < rows * cols; row++)
        {
            symbols.Enqueue(snake[snakeIndex]);
            snakeIndex++;
            if (snakeIndex == snake.Length)
            {
                snakeIndex = 0;
            }

        }

        while (symbols.Count != 0)
        {
            for (int row = 0; row < rows; row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        matrixSnake[row, col] = symbols.Dequeue();
                    }
                }

                if (row % 2 == 1)
                {
                    for (int col = cols - 1; col >= 0; col--)
                    {
                        matrixSnake[row, col] = symbols.Dequeue();
                    }
                }
            }

            PrintMatrix(matrixSnake);
        }




        static void PrintMatrix(char[,] matrixSnake)
        {
            for (int row = 0; row < matrixSnake.GetLength(0); row++)
            {
                for (int col = 0; col < matrixSnake.GetLength(1); col++)
                {
                    Console.Write(matrixSnake[row, col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
