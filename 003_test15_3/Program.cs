// See https://aka.ms/new-console-template for more information

namespace Test_3    //관계연산자 크기 비교 프로그램
{
    class Bigsmaㅣㅣ
    {
        static void Main(string[] args)
        {
            int x, y;   // 변수 2개 정수로 설정

            Console.WriteLine("x를 입력하세요 : ");  //첫번쨰 변수 받기
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("y를 입력하세요 : ");  //두번째 변수 받기
            y = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} > {1} = {2}", x, y, x > y);  // >
            Console.WriteLine("{0} >= {1} = {2}", x, y, x >= y);  // >=
            Console.WriteLine("{0} < {1} = {2}", x, y, x < y);   // <
            Console.WriteLine("{0} <= {1} = {2}", x, y, x <= y);  // <=
            Console.WriteLine("{0} == {1} = {2}", x, y, x == y);  // ==
            Console.WriteLine("{0} != {1} = {2}", x, y, x != y);  // !=

        }
    }
}
