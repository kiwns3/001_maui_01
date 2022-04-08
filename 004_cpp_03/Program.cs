// See https://aka.ms/new-console-template for more information

namespace pira
{
    class Program
    {
        static void Main(string[] args)
        {
            pyramid(3);
            pyramid(5);
            pyramid(7);
        }

        private static void pyramid(int v)
        {
           for (int i= 1; i <= v; i++)
            {
                for (int j = 1; j <= v - i; j++)
                    Console.Write(" ");
                for (int k = 1; k <= 2 * i - 1; k++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
    }
}
