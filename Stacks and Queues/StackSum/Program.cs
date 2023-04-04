

    List<int> list =  Console.ReadLine().Split(' ').Select(int.Parse).ToList();

    Stack<int> stack = new Stack<int>(list);

    string command;

    while ((command = Console.ReadLine().ToLower()) != "end")
    {
        string[] cmdArgs = command.Split(' ');

        string cmdType = cmdArgs[0];

        if (cmdType == "add")
        {
            int numOne = int.Parse(cmdArgs[1]);
            int numTwo = int.Parse(cmdArgs[2]);

            stack.Push(numOne);
            stack.Push(numTwo);
        }
        else if (cmdType == "remove")
        {
            int remove = int.Parse(cmdArgs[1]);

            if (stack.Count >= remove)
            {
                for (int i = 0; i < remove; i++)
                {
                    stack.Pop();
                }
            }
            else
            {
                continue;
            }
        }

    }

    Console.WriteLine($"Sum: {stack.Sum()}");
 