// See https://aka.ms/new-console-template for more information

namespace Test_12  // Larger함수를 이용하여 세개의 숫자중 가장 큰수를 반환하는 프로그램
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.Write("첫번째 수를 입력하시오 : ");
            x = int.Parse(Console.ReadLine());
            Console.Write("두번째 수를 입력하시오 : ");
            y = int.Parse(Console.ReadLine());
            Console.Write("세번째 수를 입력하시오 : ");
            z = int.Parse(Console.ReadLine());

            Console.WriteLine("최대값은 {0}", Larger(Larger(x, y), z));
        }

        private static int Larger(int x, int y)
        {
            return (x > y) ? x : y;
        }
    }
}