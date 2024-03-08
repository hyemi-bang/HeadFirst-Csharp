using System;
//C#코드의 지시문

namespace MyFirstConsoleApp
{ //코드를 쉽게 관리하는 용도로 네임스페이스> 클래스> 메서드가 있다.
    
    internal class Program
    {//클래스는 프로그램의 일부분, 메서드를 1개이상 포함
        static void Main(string[] args)
        {// 메서드는 클래스에 속해있으며 보통 Console.WriteLine 같은 명령문 여러개로 이루어짐
            Console.WriteLine("Hello, World!");
        }
    }
}