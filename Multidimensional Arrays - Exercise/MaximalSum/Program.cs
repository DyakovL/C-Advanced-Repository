int[] matrixSize = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int rows = matrixSize[0];
int cols = matrixSize[1];

int[,] matrix = new int[rows, cols];

for (int row = 0; row < rows; row++)
{
    int[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = data[col];
    }
}

int maxSum = 0;
int currSum = 0;
int maxRow = 0;
int maxCol = 0;

for (int row = 0; row < matrix.GetLength(0); row++)
{

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        currSum = 0;
        if (row >= matrix.GetLength(0) - 2 || col >= matrix.GetLength(1) - 2)
        {
            continue;
        }
        currSum += matrix[row, col];
        currSum += matrix[row, col + 1];
        currSum += matrix[row, col + 2];
        currSum += matrix[row + 1, col];
        currSum += matrix[row + 1, col + 1];
        currSum += matrix[row + 1, col + 2];
        currSum += matrix[row + 2, col];
        currSum += matrix[row + 2, col + 1];
        currSum += matrix[row + 2, col + 2];

        if (currSum > maxSum)
        {
            maxSum = currSum;
            maxCol = col;
            maxRow = row;
        }
    }
}


Console.WriteLine($"Sum = {maxSum}");
Console.WriteLine($"{matrix[maxRow, maxCol]} {matrix[maxRow, maxCol + 1]} {matrix[maxRow, maxCol + 2]}");
Console.WriteLine($"{matrix[maxRow + 1, maxCol]} {matrix[maxRow + 1, maxCol + 1]} {matrix[maxRow + 1, maxCol + 2]}");
Console.WriteLine($"{matrix[maxRow + 2, maxCol]} {matrix[maxRow + 2, maxCol + 1]} {matrix[maxRow + 2, maxCol + 2]}");