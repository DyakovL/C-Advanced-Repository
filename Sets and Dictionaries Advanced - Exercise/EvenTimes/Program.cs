Dictionary<int, int> kvp  = new Dictionary<int, int>();

int n = int.Parse(Console.ReadLine());

for(int i = 0;i < n; i++)
{
	int input = int.Parse(Console.ReadLine());
	if (!kvp.ContainsKey(input))
	{
		kvp.Add(input, 0);
	}
	kvp[input]++;
}


Console.WriteLine(kvp.Single(x => x.Value % 2 == 0).Key);