SortedSet<string> chemicals = new();

int n = int.Parse(Console.ReadLine());

for(int i = 0;i < n; i++)
{
    string[] elements = Console.ReadLine().Split(" ").ToArray();
    chemicals.UnionWith(elements);
}

Console.WriteLine(string.Join(" ", chemicals));