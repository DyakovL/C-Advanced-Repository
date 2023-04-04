int qty = int.Parse(Console.ReadLine());

Queue<int> orders = new(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

Console.WriteLine(orders.Max());

while (orders.Any())
{

	qty -= orders.Peek();
	if (qty < 0)
	{
		break;
	}
	
	orders.Dequeue();
}

if (orders.Any())
{
    Console.WriteLine($"Orders left: {string.Join(' ', orders)}");
}
else
{
	Console.WriteLine("Orders complete");
}