// See https://aka.ms/new-console-template for more information

namespace Test_9  // 2중 반복문으로 5층 피라미드 만들기
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {   // 빈칸의 개수 정하는 반복문
                for (int j = 1; j <= 5 - i; j++) // 4 → 1 개수 줄어들기
                    Console.Write(" "); 
                // *의 개수 정하는 반복문
                for (int j = 1; j <= 2 * i - 1; j++)
                // *의 개수는 증가하는 홀수
                    Console.Write("*");
                Console.WriteLine();  //줄 띄어주기
            }
        }
    }
}
