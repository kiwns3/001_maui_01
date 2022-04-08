// See https://aka.ms/new-console-template for more information

namespace Test_5  // 1~100의 합, 짝수의 합, 홀수의 합, 역수의 합을 반복문으로 구현
{
    class Loop
    {
        static void Main(string[] args)
        {
            int sum = 0;  // 1~100의 합 구하기
            for (int i = 1; i <= 100; i++)
                sum += i;
            Console.WriteLine("1~100의 합 : {0}", sum);

            int oddSum = 0;  // 1~100의 짝수의 합 구하기
            int evenSum = 0; // 1~100의 홀수의 합 구하기
            for (int i = 1; i <= 100; i++)  //for 반복문 사용
            {
                if (i % 2 == 0)  // 만약 i가 2로 나누어 떨어지면
                    evenSum += i;  // 짝수
                else  // i가 2로 나누어 떨어지지 않으면
                    oddSum += i; // 홀수
            }
            Console.WriteLine("1~100의 짝수의 합 = {0}", oddSum);
            Console.WriteLine("1~100의 홀수의 합 = {0}", evenSum);

            double rSum = 0;  // 1~100의 역수의 합 구하기
            for (int i = 1; i <= 100; i++)
                rSum += 1.0 / i;
            Console.WriteLine("1~100의 역수의 합 = {0}", rSum);
        }
    }
}