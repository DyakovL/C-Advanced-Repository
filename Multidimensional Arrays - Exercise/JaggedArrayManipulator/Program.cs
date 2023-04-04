int rows = int.Parse(Console.ReadLine());

int[][] jagged = new int[rows][];

for (int row = 0;row < rows; row++)
{
    jagged[row] = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
}

for (int row = 0; row < rows - 1; row++)
{
	if (jagged[row].Length == jagged[row + 1].Length)
	{
		for (int col = 0; col < jagged[row].Length; col++)
		{
			jagged[row][col] *= 2;
			jagged[row + 1][col] *= 2;
		}
	}
	else
	{
        for (int col = 0; col < jagged[row].Length; col++)
        {
            jagged[row][col] /= 2;
        }
		for (int col2 = 0; col2 < jagged[row + 1].Length; col2++)
		{
            jagged[row + 1][col2] /= 2;
        }
    }
}

string command;

while ((command = Console.ReadLine()) != "End")
{
	string[] cmdArgs = command.Split(" ");
	string cmdType = cmdArgs[0];
	int row = int.Parse(cmdArgs[1]);
	int col = int.Parse(cmdArgs[2]);
	int value = int.Parse(cmdArgs[3]);

	if (cmdType == "Add")
	{
		if (row >= 0 && row < rows)
		{
			if (col >= 0 && col < jagged[row].Length)
			{
				jagged[row][col] += value;
			}
		}
	}
	else if (cmdType == "Subtract")
	{
        if (row >= 0 && row < rows)
        {
            if (col >= 0 && col < jagged[row].Length)
            {
                jagged[row][col] -= value;
            }
        }
    }
}

PrintMatrix(jagged);

static void PrintMatrix(int[][] jagged)
{
	for (int row = 0; row < jagged.GetLength(0); row++)
	{
		for (int col = 0; col < jagged[row].Length; col++)
		{
			Console.Write(jagged[row] [col] + " ");
		}
		Console.WriteLine();
	}
}