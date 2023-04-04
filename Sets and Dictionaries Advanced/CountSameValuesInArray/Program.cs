double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();

Dictionary<double, int> occurances = new Dictionary<double, int>();

foreach (var number in input)
{
    if (!occurances.ContainsKey(number))
    {
        occurances.Add(number, 0);
    }

    occurances[number]++;

}

foreach (var item in occurances)
{
    Console.WriteLine($"{item.Key} - {item.Value} times");
}

