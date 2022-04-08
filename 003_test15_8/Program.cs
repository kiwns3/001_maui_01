// See https://aka.ms/new-console-template for more information


namespace Test_8  // 1000까지의 소수 및 소수의 갯수 출력 프로그램
{
    class Program 
    {
        static void Main(string[] args)
        {
            int primeNumber = 0; // 소수의 갯수를 출력하는 변수
            for (int x = 2; x <= 1000; x++) // 소수의 정의(2이상 1000이하)
            {
                int i;
                for (i=2; i < x; i++)  // 나누는 숫자의 정의(2 또는 자신까지)
                {
                    if (x % i == 0)  // x가 0으로 나누어 떨어지면
                        break;       // 반복을 멈춤
                }
                if (i == x)          // i == x 이면
                {
                    Console.Write("{0}\t", x);  // 소수로 출력
                    primeNumber++;  // 소수의 갯수 추가
                }
            }
            Console.WriteLine();
            Console.WriteLine("소수의 갯수 = {0}", primeNumber);
        }
    }
}