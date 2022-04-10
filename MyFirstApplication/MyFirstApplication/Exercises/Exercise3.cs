namespace MyFirstApplication;

/*
Lesson 3 Lab Exercise - Use different operators (like Compound Assignment operator, Boolean Logical operators etc.)
to calculate different values
 */
public class Exercise3
{

    /* 
    Problem 3  - Write a method that takes 1 int argument and an int return type. Use
    the modulus operator. Use the Console WriteLine statement on the first 4
    variables listed and calculate the modulus with the passed in
    argument parameter. Using 15, 456, 23, 89, 245 as the varibled. Using the last variable, calculate the modulus
    with the passed in argument parameter and return it. 
     */
    public static int Valuemodulus(int valarg)
    {
        int val_1 = 15;
        int val_2 = 456;
        int val_3 = 23;
        int val_4 = 89;
        int val_5 = 245;
        Console.WriteLine(val_1 % valarg);
        Console.WriteLine(val_2 % valarg);
        Console.WriteLine(val_3 % valarg);
        Console.WriteLine(val_4 % valarg);

        return (val_5 % valarg);
    }
    /*
     Problem 2 - Write a method that takes no arguments and a void return type. Utilizing 
     this math problem: (10 + 32 * 12 / 3), and fill in any missing pieces to get the output.
     Write a Console WriteLine to solve each output: 138, 168, 131
    */
    public static void Mathoutput()
    {
        // equals 138
        Console.WriteLine(10 + (32 * 12) / 3);
        // equals 168
        Console.WriteLine((10 + 32) * (12 / 3));
        // equals 131
        Console.WriteLine((10 + (32 * 12)) / 3);

    }

    /*
Problem 3 - Write a method that takes two short type arguments and a void return
type. Using the Compound Assignment operators these, +=, /=, *=, %= use the first
argument parameter as the left operand to get the result. Print each one
using the Console WriteLine statement.
    */
    public static void Shrtmethod(short shrtypearg_1, short shrtypearg_2) 
    {
        Console.WriteLine(shrtypearg_1 += shrtypearg_2);

        Console.WriteLine(shrtypearg_1 /= shrtypearg_2);

        Console.WriteLine(shrtypearg_1 *= shrtypearg_2);

        Console.WriteLine(shrtypearg_1 %= shrtypearg_2);
    }

    /*   
    Write a method that takes two bool type arguments and a void return
    type. Using Boolean Logical operators &, |, ^, and ||.
    Use a Console WriteLine statement to calculate each result using the
    operators. The second argument is the left operand. Use these value to test the method:
    Argument1 = true, Argument2 = false
    Argument1 = false, Argument2 = false Argument1 = true, Argument2 = true Argument1 = false, Argument2 = true values . Using comments, provide your output results
    */
    public static void Boolmethod(bool arg1, bool arg2)
    {
        Console.WriteLine(arg2 & arg1);
        Console.WriteLine(arg2 | arg1);

        Console.WriteLine(arg2 ^ arg1);
        Console.WriteLine(arg2 || arg1);
    }

} // end class

