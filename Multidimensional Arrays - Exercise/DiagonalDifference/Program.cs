int rows = int.Parse(Console.ReadLine());
int cols = rows;

int[,] matrix = new int[rows, cols];

for (int row = 0;row < rows; row++)
{
    int[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = data[col];
    }
}

int sum1 = 0;
int sum2 = 0;

for (int row = 0; row < rows; row++)
{

    for (int col = row; col <= row; col++)
    {
        sum1 += matrix[row, col];
        sum2 += matrix[row, cols - 1 - row];
    }

}


if (sum1 > sum2)
{
    Console.WriteLine(sum1 - sum2);
}
else
{
    Console.WriteLine(sum2 - sum1);
}