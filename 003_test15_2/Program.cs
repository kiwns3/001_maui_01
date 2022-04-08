// See https://aka.ms/new-console-template for more information


namespace Test_2   //산술연산자, 사칙연산 계산하기
{
    class Ca   
    {
        static void Main(string[] args)
        {
            int x, y;     //정수 2개 설정

            Console.Write("첫번째 숫자를 입력하세요 : ");     //첫번째 정수 받기
            x = int.Parse(Console.ReadLine());               
            Console.Write("두번째 숫자를 입력하세요 : ");     //두번째 정수 받기
            y = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} + {1} = {2}", x, y, x + y);    //덧셈
            Console.WriteLine("{0} - {1} = {2}", x, y, x - y);    //뺄셈
            Console.WriteLine("{0} * {1} = {2}", x, y, x * y);    //곱셈
            Console.WriteLine("{0} / {1} = {2}", x, y, x / y);    //나눗셈
            Console.WriteLine("{0} % {1} = {2}", x, y, x % y);    //나머지

            Console.WriteLine("{0} % {1} = {2}", 3.14, 2.56, 3.14 % 2.56);
        }
    }
}