Dictionary<string, Dictionary<string, double>> shops = new Dictionary<string, Dictionary<string, double>>();

string command;

while ((command = Console.ReadLine()) != "Revision")
{
    string[] cmdArgs = command.Split(", ");
    string shopName = cmdArgs[0];
    string product = cmdArgs[1];
    double price = double.Parse(cmdArgs[2]);

    if (!shops.ContainsKey(shopName))
    {
        shops.Add(shopName, new Dictionary<string, double>());
    }

    shops[shopName].Add(product, price);
}

shops = shops.OrderBy(x => x.Key).ThenBy(x => x.Value.Keys).ThenBy(x => x.Value.Values).ToDictionary(x => x.Key, x => x.Value);

foreach (var shop in shops)
{
    Console.WriteLine($"{shop.Key}->");
    foreach (var product in shop.Value)
    {
        Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
    }
    
}