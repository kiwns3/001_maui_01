// See https://aka.ms/new-console-template for more information

namespace Test_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] a = new int[10];

            for (int i =0; i < 10; i ++)
                a[i] = random.Next(100);

            foreach ( var x in a )
                Console.WriteLine(x);

            int sum = 0;    // 평균
            int min = a[0]; // 최소값
            int max = a[0]; // 최대값

            foreach ( var x in a)
            {
                sum += x;
                if (x < min)
                    min = x;
                if (x > max)
                    max = x;
            }

            Console.WriteLine("평균 = {0}", sum / 10.0);
            Console.WriteLine("최소값 = {0}", min);
            Console.WriteLine("최대값 = {0}", max);
        }
    }
}
