using System;

namespace LineComparisionProblem
{
    internal class Program
    {
        public static void UC_1_Length(int x1, int y1, int x2, int y2)
        {
            double result, sum;
            sum = ((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1));
            result = Math.Sqrt(sum);
            Console.WriteLine(result);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to Line Comparison problem:");

            Console.WriteLine("Please enter X co-ordinates: (x1 and y1)");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter Y co-ordinates: (x2 and y2)");
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            Program.UC_1_Length(x1, y1, x2, y2);

        }
    }
}
