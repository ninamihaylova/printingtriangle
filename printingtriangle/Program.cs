
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            PrintTriangle(num);
        }
 
        static void  PrintRow (int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
 
            Console.WriteLine();
        }
        static void PrintTriangle(int n)
        {
            for (int row = 1; row <= n; row++)
            {
               PrintRow(1, row);
            }
            for (int row = n - 1;  row >= 1; row--)
            {
                PrintRow(1, row);
            }
        }
    }
