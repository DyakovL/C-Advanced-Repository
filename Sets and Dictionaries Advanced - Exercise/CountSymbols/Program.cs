namespace CountSymbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, char> kvp = Console.ReadLine().Select(char.Parse).To;
            
            Queue<char> queue = new Queue<char>();

            char input = char.Parse(Console.ReadLine());
            queue.Enqueue(input);

            for (int i = 0; i < queue.Count; i++)
            {

                if (true)
                {

                }
            }
        }
    }
}