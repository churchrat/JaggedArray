namespace PascalPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] triangle = new int[n + 1][];
            for (int row = 0; row < n; row++)
            {
                triangle[row] = new int[row + 1];
            }
            triangle[0][0] = 1;
            for (int row = 0; row < n - 1; row++)
            {
                for (int col = 0; col <= row; col++)
                {
                    triangle[row + 1][col] += triangle[row][col];
                    triangle[row + 1][col + 1] += triangle[row][col];
                }
            }
            int tabs = triangle.Length;
            for (int row = 0; row < n; row++)
            {
                for (int i = 0; i <= tabs; i++)
                {
                    Console.Write(" ");
                }
                tabs--;
                for (int col = 0; col <= row; col++)
                {                  
                    Console.Write(triangle[row][col] + " ");             
                }
                Console.WriteLine();
            }
        }
    }
}
