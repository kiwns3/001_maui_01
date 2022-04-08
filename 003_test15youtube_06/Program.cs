// See https://aka.ms/new-console-template for more information

namespace Test_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x를 입력하세요 : ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("y를 입력하세요 : ");
            int y = int.Parse(Console.ReadLine());

            int up = 1;
            for (int i = 0; i < y; i++)
                up *= x;

            Console.WriteLine("{0} ^ {1} = {2}", x, y, up);
        }
    }
}
