int[] matrixSize = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int rows = matrixSize[0];
int cols = matrixSize[1];

string[,] matrix = new string[rows, cols];

for (int row = 0; row < rows; row++)
{
    string[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = data[col];
    }
}

string command;

while ((command = Console.ReadLine()) != "END")
{
    string[] cmdArgs = command.Split();

    if (cmdArgs.Length > 5 || cmdArgs.Length < 5)
    {
        Console.WriteLine($"Invalid input!");
        continue;
    }

    string cmdType = cmdArgs[0];
    int row1 = int.Parse(cmdArgs[1]);
    int col1 = int.Parse(cmdArgs[2]);
    int row2 = int.Parse(cmdArgs[3]);
    int col2 = int.Parse(cmdArgs[4]);

    if (row1 > matrix.GetLength(0) || row1 < 0 ||row2 >= matrix.GetLength(0) 
        || row2 < 0 || col1 >= matrix.GetLength(1) ||
        col1 < 0 || col2 >= matrix.GetLength(1) || col2 < 0)
    {
        Console.WriteLine($"Invalid input!");
        continue;
    }

    if (cmdType != "swap" )
    {
        Console.WriteLine($"Invalid input!");
        continue;
    }

    string rememberCell = matrix[row1, col1];
    matrix[row1, col1] = matrix[row2, col2];
    matrix[row2, col2] = rememberCell;

    PrintMatrix(matrix);
}


static void PrintMatrix(string[,] matrix)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            Console.Write(matrix[row, col] + " ");
        }
        Console.WriteLine();
    }
}