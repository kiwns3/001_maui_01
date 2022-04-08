// See https://aka.ms/new-console-template for more information

namespace Test_6 // x의 y 제곱을 계산하기
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x를 입력하세요 : ");   //먼저 x값을 정수로 입력 받습니다.
            int x = int.Parse(Console.ReadLine());
            Console.Write("y를 입력하세요 : ");  //y값을 정수로 입력받습니다.
            int y = int.Parse(Console.ReadLine());

            int up = 1;  //up = x^y의 결과값
            for (int i = 0; i < y; i++) //y번 반복하는 반복문
                up *= x;

            Console.WriteLine("{0} ^ {1} = {2}", x, y, up);
        }
    }
}