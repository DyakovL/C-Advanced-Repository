using CarManufacturer;
using System.Runtime.CompilerServices;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
            string[] tiresCommand = Console.ReadLine().Split(" ").ToArray();

            while (tiresCommand.ToString() != "No more tires")
            {
                var tire = new Tire(0, 0);

                tire.Year = int.Parse(tiresCommand[0]);
                tire.Pressure = double.Parse(tiresCommand[1]);

                tiresCommand = Console.ReadLine().Split(" ").ToArray();

            }

            string[] engineCommand = Console.ReadLine().Split(" ").ToArray();

            while (engineCommand.ToString() != "Engines stop")
            {
                var engine = new Engine(0,0);
                engine.HorsePower = int.Parse(engineCommand[0]);
                engine.CubicCapacity = int.Parse(engineCommand[1]);

               
                engineCommand = Console.ReadLine().Split(" ").ToArray();
            }

            string[] showSpecialCommand = Console.ReadLine().Split(" ").ToArray();

            while (showSpecialCommand.ToString() != "Show special")
            {
                

            }
        }
    }
}