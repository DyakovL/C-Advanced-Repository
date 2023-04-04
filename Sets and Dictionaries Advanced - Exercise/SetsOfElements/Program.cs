HashSet<int> n = new HashSet<int>();
HashSet<int> m = new HashSet<int>();
int[] cmd = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

int nSize = cmd[0];
int mSize = cmd[1];

for (int i = 0;i < nSize; i++)
{
    n.Add(int.Parse(Console.ReadLine()));
}

for (int i = 0; i < mSize; i++)
{
    m.Add(int.Parse(Console.ReadLine()));
}

n.IntersectWith(m);

Console.WriteLine(string.Join(" ", n));