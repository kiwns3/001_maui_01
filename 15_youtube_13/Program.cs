// See https://aka.ms/new-console-template for more information

namespace Test_13  // 여러 층의 피라미드 생성
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawPyramid(3);
            DrawPyramid(5);
            DrawPyramid(7);
        }

        private static void DrawPyramid(int n)
        {
            for(int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                    Console.Write(" ");
                for (int k = 1; k <= 2 * i - 1; k++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
    }
}