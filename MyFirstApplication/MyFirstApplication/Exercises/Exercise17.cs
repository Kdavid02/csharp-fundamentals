using System;
namespace MyFirstApplication;
// Lesson 17 Exercise Lab – Exception Handling

internal class Exercise17
{
    /*
    Problem 1 - Write a method that has two int parameters and no return type. You will
    use a try/catch for this method. 
    Create a division problem in the try block.
    The catch block will utilize the DivideByZeroException. Provide a Console
    WriteLine message for both the try block and the catch block. The one in
    the try block should display the answer to the division problem. The one in
    the catch block should have a message using Interpolation along with a
    variable.Message syntax. 
    Test the method with different numbers,
    including 0 so you can ensure the catch executes. 
     */

    public void DividebyZero(int val1, int val2)
    {
        try
        {
            int result = val1 / val2;

            Console.WriteLine($"result = {result}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Divide by zero is not possible - {ex.Message}");
        }
    }


    /*
    Problem 2 - Write a method that has a horse parameter and no return type. Using an if
    statement, determine if your horse is null. If it is null, use the throw
    keyword and a message to indicate it is null. If the horse is not null, use a
    
    Console WriteLine statement to print out one of your horse properties.
     */
    public void Nulltest(Horse horse)
    {
        if (horse == null)

        {

            throw new NullReferenceException("Horse obj = null");
        }

        else

        {
            Console.WriteLine($"The horse =/ null and is parameter = {horse.HairColor}");
        }
    }

} // end class