int[] matrixSize = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int rows = matrixSize[0];
int cols = matrixSize[1];

char[,] matrix = new char[rows, cols];

for (int row = 0; row < rows; row++)
{
    char[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = data[col];
    }
}

int currSum1 = 0;
int currSum2 = 0;
int found = 0;

for (int row = 0; row < rows; row++)
{
    
    for (int col = 0; col < cols; col++)
    {
        currSum1 = 0;
        currSum2 = 0;

        if (row >= matrix.GetLength(0) - 1 || col >= matrix.GetLength(1) - 1)
        {
            continue;
        }

        if (matrix[row, col] == matrix[row, col + 1])
        {
            currSum1 += matrix[row, col];
            currSum1 += matrix[row, col + 1];
        }

        if (matrix[row + 1, col] == matrix[row + 1, col + 1])
        {
            currSum2 += matrix[row + 1, col];
            currSum2 += matrix[row + 1, col + 1];
        }
        
        if (currSum1 == currSum2 && currSum1 != 0 && currSum2 != 0)
        {
            found ++;
        }
    }
}

Console.WriteLine(found);