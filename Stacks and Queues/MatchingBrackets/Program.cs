string expression = Console.ReadLine();

Stack<int> stack = new Stack<int>();

for (int i = 0; i < expression.Length; i++)
{
	if (expression[i] == '(')
	{
		stack.Push(i);
	}

	if (expression[i] == ')')
	{
		int openBrackets = stack.Pop();

		for (int j = openBrackets + 1; j < i; j++)
		{
			if (expression[j] == ' ')
			{
				continue;
			}
			Console.Write(expression[j]); 
		}
		Console.WriteLine();
	}
	
}