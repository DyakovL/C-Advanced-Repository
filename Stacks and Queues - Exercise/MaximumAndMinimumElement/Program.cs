var stack = new Stack<int>();

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string[] cmd = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

    int command = int.Parse(cmd[0]);

    switch (command)
    {
        case 1:
            int num = int.Parse(cmd[1]);
            stack.Push(num);
            break;
        case 2:
            stack.Pop();
            break;
        case 3:
            if (stack.Any())
            {
                Console.WriteLine(stack.Max());
            }
            break;
        case 4:
            if (stack.Any())
            {
                Console.WriteLine(stack.Min());
            }
            break;
    }
}


Console.Write(string.Join(", ", stack));

