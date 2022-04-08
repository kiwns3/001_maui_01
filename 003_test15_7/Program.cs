// See https://aka.ms/new-console-template for more information

namespace Test_7  // 2중 반복문을 이용한 구구단 출력 프로그램
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("구구단!");

            for(int y = 1; y <= 9; y++) // y = 1~9 반복
            {
                for(int x = 2; x <= 9; x++) // x = 2~9 반복(2단~9단)
                {
                    Console.Write("{0} * {1} = {2}\t", x, y, x * y);
                }
                Console.WriteLine();
            }
        }
    }
}