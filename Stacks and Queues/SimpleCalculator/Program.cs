var list = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

list.Reverse();

Stack<string> stack = new Stack<string>(list);


while(stack.Count != 1)
{
    int firstNum = int.Parse(stack.Pop());
    char chare = char.Parse(stack.Pop());
    int secondNum = int.Parse(stack.Pop());

    if (chare == '-')
    {
        int result = firstNum - secondNum;
        stack.Push(result.ToString());
    }
    else
    {
        int result = firstNum + secondNum;
        stack.Push(result.ToString());
    }
    
}

Console.WriteLine(stack.Pop());