namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            using(StreamReader reader = new StreamReader(@"../../../TextFile1.txt"))
            {
                string line = reader.ReadLine();
                int row = 0;
                while (line != null)
                {
                    Console.WriteLine($"{++row}.{line}");
                    line = reader.ReadLine();
                }
            }

        }
    }
}