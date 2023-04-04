int n = int.Parse(Console.ReadLine());

Dictionary<string,List<decimal>> studentGrades = new Dictionary<string,List<decimal>>();

for (int i = 0; i < n; i++)
{
    string[] cmdArgs = Console.ReadLine().Split(" ");
    string name = cmdArgs[0];
    decimal grade = Convert.ToDecimal(cmdArgs[1]);

    if (!studentGrades.ContainsKey(name))
    {
        studentGrades.Add(name,new List<decimal>());
    }

    studentGrades[name].Add(grade);
}

foreach (var student in studentGrades)
{
    Console.WriteLine($"{student.Key} -> {string.Join(" ", student.Value.Select(x=>$"{x:f2}").ToList())} (avg: {student.Value.Average():f2})");
}