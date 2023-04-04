int carsThatCanPass = int.Parse(Console.ReadLine());
var queue = new Queue<string>();

int carsPassed = 0;

string command;

while ((command = Console.ReadLine()) != "end")
{
	if (command == "green")
	{
		

		for (int i = 0; i < carsThatCanPass; i++)
		{

			if (queue.Count == 0)
			{
				break;
			}

            Console.WriteLine($"{queue.Dequeue()} passed!");
            
			carsPassed++;

		}

		
	}
	else
	{
		queue.Enqueue(command);
	}
}

Console.WriteLine($"{carsPassed} cars passed the crossroads.");