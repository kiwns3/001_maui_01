// See https://aka.ms/new-console-template for more information

namespace Test_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("구구단");

            for (int y =1; y <= 9; y++)
            {
                for (int x = 2; x <= 9; x++)
                {
                    Console.Write("{0} * {1} = {2}\t", x, y, x * y);
                }
                Console.WriteLine();
            }
        }
    }
}