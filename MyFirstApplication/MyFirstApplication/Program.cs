using System;

namespace MyFirstApplication
{
    public class Program
    {

         public void MyLocalFunction()
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


            /*
             * void Exercise6test()
            {
                Exercise6 Shoe_1 = new Exercise6(2, "Nike");

                Exercise6.TryOn tryshoes = Shoe_1.ShoeTryOn;

                tryshoes($"Try on {Shoe_1.ShoeType}'s with a size of {Shoe_1.ShowSize}");
            }
            */
            // Exercise6test();

            Exercise8.footinches(3);

            void Exercise8testLength()
            {
            }
            // Exercise8testLength();




            static void Lesson9Example()
            {
                Lesson9 myLesson9 = new Lesson9();
                Lesson9.Nested nested = new Lesson9.Nested(myLesson9);

                // Access Modifiers
                myLesson9.SampleInternal();
                myLesson9.SampleProtectedInternal();
            }
           // Lesson9Example();


            static void Lesson10Example()
            {
                Lesson10 myLesson10 = new Lesson10();

                // Using "this" to call another constructor
                Console.WriteLine(myLesson10.Firstname);
                // Normal property
                myLesson10.Firstname = "Paul";
                Console.WriteLine(myLesson10.Firstname);

                // Calling Auto Property
                //  myLesson10.LastName = "Smith"; // only works in Lesson10 constructor
                Console.WriteLine(myLesson10.Id); // default value
                myLesson10.Id = 1500;
                Console.WriteLine(myLesson10.Id); // get 1500


                // Expression Body Property
                myLesson10.Address = "123 Main St.";
                Console.WriteLine(myLesson10.Address);


                // Second constructor
                Lesson10 myOther10 = new Lesson10("Ben", "Franklin", 64119);
                Console.WriteLine(myOther10.Zipcode);
            }   
            static void Lesson11Example() {
                Square square = new Square();
                double total = square.CalculateInteriorAngle();
                Console.WriteLine(total);
            
                Triangle triangle = new Triangle();
                double total2 = triangle.CalculateInteriorAngle();
            
            
            
            
            }
            Lesson11Example();


           // Lesson10Example();

            static void HouseUpdated()
            {
                // Calling Default
                House myHouse = new House();
                Console.WriteLine(myHouse.RoofType);
                myHouse.DoorOpenClose();

                // Calling Constructor with 2 parameters
                House mySecond = new House("straw", "bamboo");
                Console.WriteLine(mySecond.WindowSize);
                mySecond.DoorOpenClose();


                // Calling Constructor with 4 parameters
                House myThird = new House("dirt", "plastic", "green", 40);
                Console.WriteLine(myThird.Foundation);
                myThird.DoorOpenClose();
                
            }

            
           // HouseUpdated();
        }
        




    }

}



