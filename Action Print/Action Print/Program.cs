using System.Buffers;
using System.Linq;

namespace Action_Print
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            foreach (var item in names)
            {
                if (item.Sum(ch => ch ) >= n)
                {
                    Console.WriteLine(item.ToString());
                    break;
                }
            }
        }
    }

}