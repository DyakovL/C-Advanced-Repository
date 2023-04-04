using System.Data.Common;

int rows = int.Parse(Console.ReadLine());

int[][] jagged = new int[rows][];

for (int row = 0;row < rows; row++)
{
	jagged[row] = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

}

string command;

while ((command = Console.ReadLine().ToLower()) != "end")
{
	string[] cmdArgs = command.Split(" ");

	string cmdType = cmdArgs[0];
	int row = int.Parse(cmdArgs[1]);
	int col = int.Parse(cmdArgs[2]);
	int n = int.Parse(cmdArgs[3]);
	if (row < 0 || col < 0 || row >= jagged.Length || col >= jagged[row].Length)
	{
		Console.WriteLine("Invalid coordinates");
		continue;
	}
	else if (cmdType == "add")
	{
		jagged[row][col] += n;
	}
	else if (cmdType == "subtract")
	{
		jagged[row][col] -= n;
	}
}

foreach (var item in jagged)
{
	Console.WriteLine(string.Join(" ", item));
}