var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

int n = array[0];
int s = array[1];
int x = array[2];

var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

var queue = new Queue<int>(input);

for (int i = 0; i < s; i++)
{
    queue.Dequeue();
}

if (queue.Count == 0)
{
    Console.WriteLine("0");
}
else if (queue.Contains(x))
{
    Console.WriteLine("true");
}
else if (!(queue.Contains(x)))
{
    Console.WriteLine(queue.Min());
}