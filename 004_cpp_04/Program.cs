// See https://aka.ms/new-console-template for more information


namespace FFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("숫자를 입력하세요 : ");
            int n  = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(Factorial(i));
            }

            int Factorial(int n)
            {
                if (n == 1)
                    return 1;
                else
                    return Factorial(n - 1) * n;
            }
        }
    }
}
