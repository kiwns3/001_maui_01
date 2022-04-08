// See https://aka.ms/new-console-template for more information

namespace Test_4  // BMI 체중기 프로그램
{
    class Program
    {
        static void Main(string[] args)
        {
            double height, weight;  // 실수로 변수 받기

            Console.Write("키를 입력하세요 : ");  //키 입력받기
            height = double.Parse(Console.ReadLine()); 

            Console.Write("체중을 입력하세요 : ");  //체중 입력받기
            weight = double.Parse(Console.ReadLine());

            double bmi = weight / (height /100 * height / 100);
            //BMI 공식
            Console.WriteLine("BMI = {0}", bmi);

            if (bmi < 20)  // 만약 bmi가 20 이하이면
                Console.WriteLine("저체중");
            else if (bmi < 25) // bmi가 25 이하이면
                Console.WriteLine("정상체중");
            else if (bmi < 30) // bmi가 30 이하이면
                Console.WriteLine("경도비만");
            else if (bmi < 40) // bmi가 40 이하이면
                Console.WriteLine("비만");
            else  // bmi가 40 이상이면
                Console.WriteLine("고도비만");

        }
    }
}