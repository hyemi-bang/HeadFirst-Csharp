using System;

class Program
{
    static void Main(string[] args)
    {
        // https://aka.ms/new-console-template에서 자세한 정보를 확인하세요.
        // Console.WriteLine("Hello, World!");

        TryAnIf();
        TryAnIfElse();
        TrySomeLoops();
        TryFor1(); // 디버깅 용도
        TryFor2();
        TryFor3();
        TryFor4();
        TryFor5();
    }

    private static void TryAnIf()
    {
        int someValue = 4;
        string name = "Bobbo Jr.";
        if((someValue == 3) && (name == "Joe")) 
        {
            Console.WriteLine("x is 3 and the name is Joe");
        }
        Console.WriteLine("this line runs no matter what");
    }

    private static void TryAnIfElse() { 
        int x = 5;
        if (x == 10)
        {
            Console.WriteLine("x must be 10");
        }
        else
        {
            Console.WriteLine("x isn't 10");    
        }
    }

    private static void TrySomeLoops()
    {
        int count = 0;
        while (count < 10)
        {
            count = count + 1;
        }
        for (int i = 0; i < 4; i++)
        {
            count = count - 1;      
        }
        Console.WriteLine("The answer is " + count);
    }

    private static void TryFor1()
    {
        int count = 5;
        while (count > 0)
        {
            count = count * 3;
            count = count * -1;
        }
    }

    private static void TryFor2()
    {
        int j = 2;
        for (int i = 1; i < 100; i = i *2)
        {
            j = j - 1;
            while ( j<25)
            {
                j = j + 5; 
            }
        }
    }

    private static void TryFor3()
    {
        int p = 2;
        for (int q = 2;  q < 32 ; q = q * 2) {
            while ( p < q)
            {
                p = p * 2;
            }
        q = p - q;
        }
    }

    private static void TryFor4()
    {
        int i = 0;
        int count = 2;
        while (i == 0)
        {
            count = count * 3;
            count = count* -1;
            // 무한루프
        }
    }

    private static void TryFor5()
    {
        while (true) 
        {
            int i = 1;
            // 무한루프
        }
    }
}
