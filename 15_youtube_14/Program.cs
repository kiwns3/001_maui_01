// See https://aka.ms/new-console-template for more information

namespace Test_14  // 재귀함수를 이용한 팩토리얼 계산
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n!을 계산하고자 합니다. n을 입력하세요 : ");
            int n = int.Parse(Console.ReadLine());

            int factorial = 1;
            for(int i = 1; i <= n; i ++)
                factorial *= i;

            Console.WriteLine("{0}! = {1}", n, factorial);

            Console.WriteLine("{0}! = {1}", n, Facto(n));

            for (int i = 1; i <= 10; i++)
                Console.WriteLine("{0,2}! = {1,0}", i, Facto(i));
        }
        private static int Facto(int n)
        {
            if (n == 1)
                return 1;
            else
                return Facto(n - 1) * n;
        }
    }
}