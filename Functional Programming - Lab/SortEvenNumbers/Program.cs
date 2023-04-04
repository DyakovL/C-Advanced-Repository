using System.Linq;

namespace SortEvenNumbers
{
    public  class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> dic = new Dictionary<string, int>();
            dic = new();

            for (int i = 0; i < n; i++)
            {
                string[] people = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string name = people[0];
                int age = int.Parse(people[1]);

                dic.Add(name, age);
            }

            string yongerOrOlder = Console.ReadLine();
            int desiredAge = int.Parse(Console.ReadLine());

            string[] desiredPrint = Console.ReadLine().Split(" ");

            if (desiredPrint.Length == 2)
            {
                OlderWithNameAndAge(dic, yongerOrOlder, desiredAge);
            }
            else if (desiredPrint[0] == "name")
            {
                YoungerOrOlderWithOnlyAName(dic, yongerOrOlder, desiredAge);
            }
            else
            {
                YoungerOrOlderWithOnlyAge(dic, yongerOrOlder, desiredAge);

            }
        }

        public static void OlderWithNameAndAge(Dictionary<string, int> dic, string yongerOrOlder, int desiredAge)
        {

            if (yongerOrOlder == "younger")
            {
                foreach (var item in dic)
                {
                    if (item.Value <= desiredAge)
                    {
                        Console.WriteLine($"{item.Key} - {item.Value}");
                    }
                }
            }
            else
            {
                foreach (var item in dic)
                {
                    if (item.Value >= desiredAge)
                    {
                        Console.WriteLine($"{item.Key} - {item.Value}");
                    }
                }
            }
        }

        public static void YoungerOrOlderWithOnlyAName(Dictionary<string, int> dic, string yongerOrOlder, int desiredAge)
        {

            if (yongerOrOlder == "younger")
            {
                foreach (var item in dic)
                {
                    if (item.Value <= desiredAge)
                    {
                        Console.WriteLine($"{item.Key}");
                    }
                }
            }
            else
            {
                foreach (var item in dic)
                {
                    if (item.Value >= desiredAge)
                    {
                        Console.WriteLine($"{item.Key}");
                    }
                }
            }
        }

        public static void YoungerOrOlderWithOnlyAge(Dictionary<string, int> dic, string yongerOrOlder, int desiredAge)
        {

            if (yongerOrOlder == "younger")
            {
                foreach (var item in dic)
                {
                    if (item.Value <= desiredAge)
                    {
                        Console.WriteLine($"{item.Value}");
                    }
                }
            }
            else
            {
                foreach (var item in dic)
                {
                    if (item.Value >= desiredAge)
                    {
                        Console.WriteLine($"{item.Value}");
                    }
                }
            }
        }
    }
}