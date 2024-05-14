namespace MaxPloshtadka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int[,] @int = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    @int[i, j] = int.Parse(Console.ReadLine());
                }
            }
            int bestSum = int.MinValue;
            int bestRow = 0;
            int bestCol = 0;

            // Намиране на максималната подматрица 2x2
            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < cols - 1; j++)
                {
                    int curSum = @int[i, j] + @int[i, j + 1] +
                                 @int[i + 1, j] + @int[i + 1, j + 1];

                    if (curSum > bestSum)
                    {
                        bestSum = curSum;
                        bestRow = i;
                        bestCol = j;
                    }
                }
            }
            Console.WriteLine($"{@int[bestRow, bestCol]} {@int[bestRow, bestCol + 1]}");
            Console.WriteLine($"{@int[bestRow + 1, bestCol]} {@int[bestRow + 1, bestCol + 1]}");
        }
    }
}
