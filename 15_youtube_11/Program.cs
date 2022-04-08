// See https://aka.ms/new-console-template for more information

namespace Test_11  // 10개 숫자 랜덤 배열 및 크기 순서대로 출력
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            Random r = new Random();
            for (int i = 0; i < 10; i++)
                a[i] = r.Next(100);

            foreach (var v in a)
                Console.Write("{0,5}", v);
            Console.WriteLine();

            for(int j = 9; j > 0; j ++)
                if(a[j] > a[j + 1])
                {
                    int t = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = t;
                }

            foreach (var v in a)
                Console.Write("{0,5}", v);
            Console.WriteLine();
        }
    }
}