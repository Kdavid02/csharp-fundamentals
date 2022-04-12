using System;
namespace MyFirstApplication;
/*
 * Lesson 8 Exercise Lab – Constants & Static.
 */
public class Exercise8
{
    /*
    Problem 1 - Write a const with a value of 12 named foot. Write a method that takes 1 int parameter and a void return type.
    This method will convert feet to inches. 
    The formula that you would use will be the parameter * Foot. 
    Your parameter will represent the number of feet to convert to inches. 
    Using a Console WriteLine statement, print the results. 
    */
    const int Foot = 12;
    public static void footinches(int footinput)
    {
        int inches = footinput * Foot;
        Console.WriteLine(inches);
    }

    /*
    Problem 2 - Write a static method that take 2 int parameters and a void return type.
    This method will be used to calculate the length and width of a 
    rectangle/square. This formula is length x width. The first parameter should represent the length and
    the second parameter should be the width. 
    Using a Console WriteLine statement, print the results. 
    Test your method and add what you used to test as a comment either before the 
    method or after.
     */
    public void LengthWidth(int length, int width) 
    {
        int area = length * width;
        Console.WriteLine(area);
    
    
    }
    /*
     * Tested using this
     *      public void Exercise8testLength() 
        {
            Exercise8.LengthWidth(3, 5);
        }
    OUTPUT: 15
     * 
     */

}

