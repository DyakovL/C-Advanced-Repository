
Stack<int> stack = new(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

int capacity = int.Parse(Console.ReadLine());
int racks = 1;
int currRack = capacity;

while (stack.Any())
{
    currRack -= stack.Peek();

	if (currRack < 0)
	{
		currRack = capacity;
		racks++;
		continue;
	}
	stack.Pop();
}

Console.WriteLine(racks);

