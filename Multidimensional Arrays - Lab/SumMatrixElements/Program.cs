string[] sizes = Console.ReadLine().Split(", ");
int rows = int.Parse(sizes[0]);
int cols = int.Parse(sizes[1]);

int[,] matrix = new int[rows, cols];

for (int row = 0; row < rows; row++)
{
    int[] data = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

	for (int col = 0; col < cols; col++)
	{
		matrix[row, col] = data[col];
	}
}

int sum = 0;

for (int row = 0; row < matrix.GetLength(0); row++)
{
	for (int col = 0; col < matrix.GetLength(1); col++)
	{
		sum += matrix[row, col];
	}
}

Console.WriteLine(rows);
Console.WriteLine(cols);
Console.WriteLine(sum);