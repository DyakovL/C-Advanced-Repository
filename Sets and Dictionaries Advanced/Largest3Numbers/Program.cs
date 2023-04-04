List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
int[] sorted = numbers.OrderByDescending(x => x).Take(3).ToArray();

    Console.Write(string.Join(" ", sorted));
