var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

int n = array[0];
int s = array[1];
int x = array[2];

var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

var stack = new Stack<int>(input);

for (int i = 0; i < s; i++)
{
    stack.Pop();
}

if (stack.Count == 0)
{
    Console.WriteLine("0");
}
else if (stack.Contains(x))
{
    Console.WriteLine("true");
}
else if (!(stack.Contains(x)))
{
    Console.WriteLine(stack.Min());
}