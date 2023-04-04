var queue = new Queue<string>();

string command;

while ((command = Console.ReadLine()) != "End")
{
	if (command == "Paid")
	{

		int count = queue.Count;
		for (int i = 0; i < count; i++)
		{
			Console.WriteLine(queue.Peek());
			queue.Dequeue();
		}
	}
	else
	{
		queue.Enqueue(command);
	}
	
}

Console.WriteLine($"{queue.Count} people remaining.");
