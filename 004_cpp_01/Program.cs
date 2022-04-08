// See https://aka.ms/new-console-template for more information

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] a = new int[10];

            for (int i = 0; i < a.Length; i++)
                a[i] = r.Next(100);
            foreach (var x in a)
                Console.WriteLine(x);

            int sum = 0;
            int min = a[0];
            int max = a[0];

            foreach (var x in a)
            {
                sum += x;
                if (x < min)
                    min = x;
                if (x > max)
                    max = x;
            }
            Console.WriteLine("평균 : {0}", sum / 10.0);
            Console.WriteLine("최솟값 : {0}", min);
            Console.WriteLine("최대값 : {0}", max);
        }
    }
}
