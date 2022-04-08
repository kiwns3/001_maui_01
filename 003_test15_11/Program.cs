// See https://aka.ms/new-console-template for more information

namespace Test_11 // 10개 숫자 랜덤 배열 및 크기 순서대로 출력
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];  //10개의 정수 배열
            Random r = new Random(); // 래덤함수 생성
            for (int i = 0; i < 10; i++)
                a[i] = r.Next(100);  //100이하의 수 생성

            foreach (var v in a)
                Console.Write("{0,5}", v);
            Console.WriteLine();

            for (int i = 9; i > 0; i--)  //배열을 크기 순서로 정렬하는 방법
                for (int j = 0; j < i; j++)
                    if (a[j] > a[j + 1])  // 
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
