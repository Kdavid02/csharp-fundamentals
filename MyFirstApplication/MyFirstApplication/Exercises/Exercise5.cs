using System;
namespace MyFirstApplication;

/*
Lesson 5 Lab Exercise -  Expressions and Pattern Matching 
*/


public class Exercise5
{

    /* 
   Problem 1  - Write a method that take 2 int parameters and a int return type.
    Use Ohm's law (V = C * R) to determine a voltage. The first 2 parameters will be current and resistance.
    use Func<int, int, int> then a lamda expression to determine the voltage and return the value.
     */
    public static int Ohmlaw(int current, int resistance)
    {
        Func <int, int, int>  voltage = (current, resistance) => current * resistance;
        int voltageresult = voltage(current, resistance);
        return voltageresult;
    }
    /* 
Problem 2  - Write a method that takes 1 char argument and a string return type. 
Use a switch and lambda that determines the right grade.
[E Excellent, V Very Good, G Good, A  Average, F Fail.]
 */
    public static string Gradecheck_2(char gradearg)
    {
        string gradereturn = gradearg switch
        {
            'E' => ("Excellent"),
            'V' => ("Very Good"),
            'G' => ("Good"),
            'A' => ("Average"),
            'F' => ("Fail"),
            _ => ("Retry and input a valid character.")
        };
        return gradereturn;

    }
    /*
    Problem 3 - Write a method that takes 1 argument and a void return type. Using a
    Relational Pattern and switch expression determine a size of popcorn
    and using a Console WriteLine, print the popcorn 
    size.  Size Values: 
    Less or equal 3 Microwave bag
    Less or equal 16 Movie sack
    Less or equal 32 Movie cup
    Less or equal 64 Movie tub
    Default should be We don’t have that size
     */
    public static void Moviesnack(int mvearg)
    {
        string mvevalue = mvearg switch
        {
            <= 3 => "Microwave bag",
            <= 16 => "Movie sack",
            <= 32 => "Movie cup",
            <= 64 => "Movie tub",
            _ => "We don't have that size"
        };
        Console.WriteLine(mvevalue);

    }

}



