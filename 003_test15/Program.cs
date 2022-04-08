// See https://aka.ms/new-console-template for more information

namespace Test_1 //자신의 학번과 이름을 입력으로 받아서 화면애 출력
{
    class Id
    {
        static void Main(string[] args)
        {
            int id;         //학번을 입력하는 변수 설정
            string name;    //이름을 입력하는 변수 설정(string = 문자열)

            Console.Write("학번을 입력하세요 : "); //학번을 입력하는 입력장치
            id = int .Parse(Console.ReadLine());  //입력값을 정수로 전환

            Console.Write("이름을 입력하세요 : ");  //이름을 입력하는 입력장치
            name =  Console.ReadLine();             

            Console.WriteLine("학번 : {0}", id);
            Console.WriteLine("이름 : {0}", name);
        }
    }
}
