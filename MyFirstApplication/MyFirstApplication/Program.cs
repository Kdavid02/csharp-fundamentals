using System;

namespace MyFirstApplication
{
    public class Program
    {
        static void MyLocalFunction()
        {
            Console.WriteLine("This is my first sentence");
            Console.WriteLine("I am new to CSharp");
            Console.WriteLine("This CSharp course is cool");
            Console.WriteLine("I am learning stuff ever");
        }
        static void Main()
        {
            MyLocalFunction();
            Exercise1.Systypeprint();
            Exercise1.Convertbyte(5, 2, 4);
            Exercise1.Digseperate();
        }


    }
}


