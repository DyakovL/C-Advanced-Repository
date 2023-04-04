HashSet<string> vipGuests = new HashSet<string>();
HashSet<string> regulars = new HashSet<string>();

string command;

while ((command = Console.ReadLine()) != "PARTY")
{

	if (char.IsDigit(command[0]))
	{
		vipGuests.Add(command);
	}
	else
	{
		regulars.Add(command);
	}
}

while ((command = Console.ReadLine()) != "END")
{
    if (char.IsDigit(command[0]))
    {
        vipGuests.Remove(command);
    }
    else
    {
        regulars.Remove(command);
    }
}

Console.WriteLine(vipGuests.Count + regulars.Count);

if (vipGuests.Count > 0)
{
    Console.WriteLine(string.Join("\n", vipGuests));
}

if (regulars.Count > 0)
{
    Console.WriteLine(string.Join("\n", regulars));
}