// See https://aka.ms/new-console-template for more information

namespace Lagerrr
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.Write("첫번째 숫자 입력 : ");
            x = int.Parse(Console.ReadLine());
            Console.Write("두번째 숫자 입력 : ");
            y = int.Parse(Console.ReadLine());
            Console.Write("세번째 숫자 입력 : ");
            z = int.Parse(Console.ReadLine());

            Console.WriteLine(Lager(x, y));
        }

        private static bool Lager(int x, int y)
        {
            if (x > y)
                return x;
            else
                return y;
        }
    }
}
