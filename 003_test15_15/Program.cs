// See https://aka.ms/new-console-template for more information

namespace Test_15  // 하노이탑
{
    class Program
    {
        static void Main(string[] args)
        {
            HanoiTower(4, 'A', 'B', 'C');  // 4개의 하노이탑
  
        }

        private static void HanoiTower(int n, char from, char via, char to)
        {
            if (n == 1)
                Console.WriteLine("{0}->{1}", from, to);
            else
            {
                HanoiTower(n - 1, from, to, via);
                Console.WriteLine("{0}->{1}", from, to);
                HanoiTower(n - 1, via, from, to);
            }
        }
    }
}