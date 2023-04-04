Queue<string> songs = new(
	Console.ReadLine()
	.Split(", ", StringSplitOptions.RemoveEmptyEntries));

while(songs.Any())
{
	string[] cmdArgs = Console.ReadLine()
		.Split(" ", StringSplitOptions.RemoveEmptyEntries);

	string cmdType = cmdArgs[0];

	switch (cmdType)
	{
		case "Play":
			songs.Dequeue();
			break;
		case "Add":
			string songName = string.Join(" ", cmdArgs.Skip(1));
			if (songs.Contains(songName))
			{
				Console.WriteLine($"{songName}, is already contained!");
			}
			else
			{
                songs.Enqueue(songName);
            }
			break;
		case "Show":
			Console.WriteLine(string.Join(", ", songs));
			break;
	}
}

Console.WriteLine("No more songs!");