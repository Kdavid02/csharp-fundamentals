using System;

namespace MyFirstApplication
{
    public class Program
    {
        public static void MyLocalFunction()
        {
            Console.WriteLine("This is my first sentence");
            Console.WriteLine("I am new to CSharp");
            Console.WriteLine("This CSharp course is cool");
            Console.WriteLine("I am learning stuff ever");
        }

        public static void Main()
        {
            // MyLocalFunction();
            // Exercise1.Systypeprint();
            // Exercise1.Convertbyte(5, 2, 4);
            // Exercise1.Digseperate();

            // Exercise2.Stringconcat("EXERCISE two Lab");
            // Exercise2.Unicrow();
            // Exercise2.JackandJill();
            // Exercise2.Favmovie();

            // Exercise3.Valuemodulus(392);
            // Exercise3.Mathoutput();
            // Exercise3.Shrtmethod(3, 5);
            // Exercise3.Boolmethod(false, true);

            // Exercise4.StringCompare("cat", "dog");
            // Exercise4.StringCompare("cat", "cat");
            // Console.WriteLine(Exercise4.Gradecheck('E'));
            // Exercise4.Dividethree();

            // Console.WriteLine(Exercise5.Ohmlaw(39, 38));
            // Console.WriteLine(Exercise5.Gradecheck_2('E'));
            // Exercise5.Moviesnack(3);

            void Exercise6test()
            {
                Exercise6 Shoe_1 = new Exercise6(2, "Nike");

                Exercise6.TryOn tryshoes = Shoe_1.ShoeTryOn;

                tryshoes($"Try on {Shoe_1.ShoeType}'s with a size of {Shoe_1.ShowSize}");
            }
            Exercise6test();






        }


    }
}


