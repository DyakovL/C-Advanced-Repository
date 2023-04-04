using System.Diagnostics;

namespace KnightGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n < 3)
            {
                Console.WriteLine(0);

                return;
            }
            
            char[,] knightsMatrix = new char[n, n];
            FillUpMatrix(n, knightsMatrix);

            int removeKnight = 0;
            removeKnight = KnightRemoval(knightsMatrix, removeKnight);

            Console.WriteLine(removeKnight);


            PrintMatrix(knightsMatrix);

        }



        static void PrintMatrix(char[,] knightsMatrix)
        {
            for (int row = 0; row < knightsMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < knightsMatrix.GetLength(1); col++)
                {
                    Console.Write(knightsMatrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        private static int KnightRemoval(char[,] knightsMatrix, int removeKnight)
        {
            for (int row = 0; row < knightsMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < knightsMatrix.GetLength(1); col++)
                {
                    if (knightsMatrix[row, col] == '0')
                    {
                        continue;
                    }

                    if (knightsMatrix[row, col] == 'K')
                    {

                        if (row + 2 < knightsMatrix.GetLength(0) && col + 1 < knightsMatrix.GetLength(1))
                        {
                            if (knightsMatrix[row + 2, col + 1] == 'K')
                            {
                                knightsMatrix[row + 2, col + 1] = '0';
                                removeKnight++;
                            }
                        }

                        if (row + 2 < knightsMatrix.GetLength(0) && col - 1 >= 0)
                        {
                            if (knightsMatrix[row + 2, col - 1] == 'K')
                            {
                                knightsMatrix[row + 2, col - 1] = '0';
                                removeKnight++;
                            }
                        }

                        if (row - 2 >= 0 && col + 1 < knightsMatrix.GetLength(1))
                        {
                            if (knightsMatrix[row - 2, col + 1] == 'K')
                            {
                                knightsMatrix[row - 2, col + 1] = '0';
                                removeKnight++;
                            }
                        }

                        if (row - 2 >= 0 && col - 1 >= 0)
                        {
                            if (knightsMatrix[row - 2, col - 1] == 'K')
                            {
                                knightsMatrix[row - 2, col - 1] = '0';
                                removeKnight++;
                            }
                        }

                        if (row + 1 < knightsMatrix.GetLength(0) && col + 2 < knightsMatrix.GetLength(1))
                        {
                            if (knightsMatrix[row + 1, col + 2] == 'K')
                            {
                                knightsMatrix[row + 1, col + 2] = '0';
                                removeKnight++;
                            }
                        }

                        if (row + 1 < knightsMatrix.GetLength(0) && col - 2 >= 0)
                        {
                            if (knightsMatrix[row + 1, col - 2] == 'K')
                            {
                                knightsMatrix[row + 1, col - 2] = '0';
                                removeKnight++;
                            }
                        }

                        if (row - 1 >= 0 && col + 2 < knightsMatrix.GetLength(1))
                        {
                            if (knightsMatrix[row - 1, col + 2] == 'K')
                            {
                                knightsMatrix[row - 1, col + 2] = '0';
                                removeKnight++;
                            }
                        }

                        if (row - 1 >= 0 && col - 2 >= 0)
                        {
                            if (knightsMatrix[row - 1, col - 2] == 'K')
                            {
                                knightsMatrix[row - 1, col - 2] = '0';
                                removeKnight++;
                            }
                        }
                    }
                    
                }
            }
            return removeKnight;
        }

        private static void FillUpMatrix(int n, char[,] knightsMatrix)
        {
            for (int row = 0; row < n; row++)
            {
                string inputData = Console.ReadLine();

                for (int col = 0; col < n; col++)
                {
                    knightsMatrix[row, col] = inputData[col];
                }
            }
        }
    }
}