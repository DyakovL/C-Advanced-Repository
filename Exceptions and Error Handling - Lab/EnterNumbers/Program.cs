namespace EnterNumbers
{
    public class Program
    {
        static void Main(string[] args)
        {
			try
			{
				int start = 0;
				int end = 10;
				ReadNumber(start, end);

            }
			catch (FormatException fe)
			{

				Console.WriteLine(fe.InnerException);
			}
        }

		public static void ReadNumber(int start, int end)
		{
			List<int> list = new List<int>();

			for (int i = start; i < end; i++)
			{
				int command = int.Parse(Console.ReadLine());
				list.Add(command);

				if (char.IsLetter((char)command))
				{
                    list.RemoveAt(i);
                    i--;
					throw new FormatException("Invalid Number!");
				}

				if (list[i] > 100)
				{
                    list.RemoveAt(i);
                    i--;

                    throw new ArgumentException($"Your number is not in range {command} - 100!");
                }

				if (list[i] > command)
				{
					list.RemoveAt(i);
					i--;

					throw new Exception($"Your number is not in range {command} - 100!");
                }
			}

			 Console.WriteLine($"{string.Join(", ", list)}"); ;

			return;
		}
    }
}