var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

var queue = new Queue<int>(array);

var list = new List<int>();
int count = queue.Count;

for (int i = 0; i < count; i++)
{
	if (queue.Peek() % 2 == 0)
	{
		list.Add(queue.Peek());
		queue.Dequeue();
	}
	else
	{
		queue.Dequeue();
	}
	
}


Console.WriteLine(string.Join(", ", list));