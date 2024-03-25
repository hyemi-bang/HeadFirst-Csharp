using System;
//C#코드의 지시문

namespace MyFirstConsoleApp
{ //코드를 쉽게 관리하는 용도로 네임스페이스> 클래스> 메서드가 있다.
    
    internal class Program
    {//클래스는 프로그램의 일부분, 메서드를 1개이상 포함
        static void Main(string[] args)
        {// 메서드는 클래스에 속해있으며 보통 Console.WriteLine 같은 명령문 여러개로 이루어짐
            //Console.WriteLine("Hello, World!");
            OperatorExamples();// Compiler Error CS0103
        }

        private static void OperatorExamples()
        {
            //throw new NotImplementedException(); 
            //vs에서 자동으로 메서드 생성할때 자리표시자(placeholder)에 throw 명령어 생성

            int width = 3;
            width++;

            int height = 2 + 4;
            int area = width * height;
            Console.WriteLine(area);

            string result = "The area ";
            result = result + "is " + area;
            Console.WriteLine(result);

            bool truthValue = true;
            Console.WriteLine(truthValue);
        }
    }
}