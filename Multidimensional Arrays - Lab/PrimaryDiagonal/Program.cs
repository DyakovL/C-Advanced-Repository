int rows = int.Parse(Console.ReadLine());
int cols = rows;

int[,] matrix = new int[rows, cols];

for (int row = 0; row < rows; row++)
{
    int[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = data[col];
    }
}

int sum = 0;    

for (int i = 0; i < matrix.GetLength(0); i++)
{

	//Console.Write(matrix[i, i] + " ");

    sum += matrix[i, i];
}

Console.WriteLine(sum);

//for (int i = 0; i < matrix.GetLength(0); i++)
//{
//	Console.Write(matrix[rows - i - 1, i] + " ");
//}

