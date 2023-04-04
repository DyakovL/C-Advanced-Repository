HashSet<string> cars = new HashSet<string>();

string command;

while ((command = Console.ReadLine()) != "END")
{
    string[] cmdArgs = command.Split(", ", StringSplitOptions.RemoveEmptyEntries);
    string direction = cmdArgs[0];
    string plateNumber = cmdArgs[1];

    switch (direction)
    {
        case "IN":
            if (!cars.Contains(plateNumber))
            {
                cars.Add(plateNumber);
            }
            break;
        case "OUT":
            if (cars.Contains(plateNumber))
            {
                cars.Remove(plateNumber);
            }
            break;
        default:
            break;
    }
}

if (cars.Count > 0)
{
    foreach (var car in cars)
    {
        Console.WriteLine(car);
    }
}
else
{
    Console.WriteLine("Parking Lot is Empty");
}