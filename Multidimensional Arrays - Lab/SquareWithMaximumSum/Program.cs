int[,] matrix = ReadMatrixWithCommas();

int maxSum = 0;
int currSum = 0;
int maxRow = 0;
int maxCol = 0;

for (int row = 0; row < matrix.GetLength(0); row++)
{
    
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        currSum = 0;
        if (row >= matrix.GetLength(0) - 1 || col >= matrix.GetLength(1) - 1)
        {
            continue;
        }
        currSum += matrix[row, col];
        currSum += matrix[row + 1, col];
        currSum += matrix[row, col + 1];
        currSum += matrix[row + 1, col + 1];

        if (currSum > maxSum)
        {
            maxSum = currSum;
            maxCol = col;
            maxRow = row; 
        }
    }
}


Console.WriteLine($"{matrix[maxRow,maxCol]} {matrix[maxRow, maxCol + 1]}");
Console.WriteLine($"{matrix[maxRow + 1, maxCol]} {matrix[maxRow + 1, maxCol + 1]}");
Console.WriteLine(maxSum);

static int[,] ReadMatrixWithCommas()
{
    int[] size = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

    int rows = size[0];
    int cols = size[1];

    int[,] matrix = new int[rows, cols];

    for (int row = 0; row < rows; row++)
    {
        int[] data = Console.ReadLine().Split(" , ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        for (int col = 0; col < cols; col++)
        {
            matrix[row, col] = data[col];
        }
    }

    return matrix;
}