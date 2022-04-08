// See https://aka.ms/new-console-template for more information

namespace Test_13  // 여러 층의 피라미드 생성 프로그램
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawPyramid(3);  // 3층 피라미드
            DrawPyramid(5);  // 5층 피라미드
            DrawPyramid(7);  // 7층 피라미드
        }

        private static void DrawPyramid(int n)  
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)  // 빈칸 생성
                    Console.Write(" ");
                for (int k = 1; k <= 2 * i - 1; k++)  // 피라미드 생성
                    Console.Write("*");
                Console.WriteLine();
            }
        }
    }
}
