// See https://aka.ms/new-console-template for more information

namespace Test_10  //10개의 숫자 랜덤 배열, 최소 최대값 구하기
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random(); //램덤함수 만들기
            int[] a = new int[10];  // 10개 정수 배열

            for (int i = 0; i < 10; i++)  // 10개 생길때까지 반복
                a[i] = random.Next(100); // 100까지 랜덤 만들기

            foreach (var x in a)
                Console.WriteLine(x);

            int sum = 0;  //평균값
            int min = a[0];  // 최소값
            int max = a[0];  // 최대값

            foreach (var x in a)
            {
                sum += x;
                if (x < min)  
                    min = x;
                if (x > max)
                    max = x;
            }

            Console.WriteLine("퍙균 = {0}", sum / 10.0);
            Console.WriteLine("최소값 = {0}", min);
            Console.WriteLine("최대값 = {0}", max);
        }
    }
}
