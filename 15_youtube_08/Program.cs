// See https://aka.ms/new-console-template for more information

namespace Test_08
{
    class Program
    {
        static void Main(string[] args)
        {
            int primeNumber = 0;
            for (int x =2; x <= 1000; x++)
            {
                int i;
                for ( i =2; i < x; i++) 
                {
                    if (x % i == 0)
                        break;
                }
                if(i == x)
                {
                    Console.Write("{0}\t", x);
                    primeNumber++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("소수의 갯수 = {0}", primeNumber);
        }
    }
}