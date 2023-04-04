int rows = int.Parse(Console.ReadLine());
int cols = rows;

char[,] matrix = new char[rows, cols];

bool found = false;

for (int row = 0; row < rows; row++)
{
    string input = Console.ReadLine();

    char[] data = input.ToCharArray();


    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = data[col];

    }
}

char search = char.Parse(Console.ReadLine());

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        if (matrix[i,j] == search)
        {
            found = true;
            Console.WriteLine($"({i}, {j})");
            break;
        }
    }
    if (found == true)
    {
        break;
    }
    
}

if (found == false)
{
    Console.WriteLine($"{search} does not occur in the matrix");
}