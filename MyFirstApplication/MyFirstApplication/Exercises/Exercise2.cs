using System;
namespace MyFirstApplication;

/*
Lesson 2 Lab Exercise - Strings and more. 
Use code to manpulate strings in several ways. And print them. 
 */
public class Exercise2
{

    /*
    Problem 1 - Use a method that will take a string of text as a parameter and concato
    Use Trim, Tolower, Contains, Length, IndexOf
     */
    public static void Stringconcat(string text)
    {
        Console.WriteLine("Trim - "  + text.Trim());
        Console.WriteLine("Tolower - " + text.ToLower());
        Console.WriteLine("Contains - " + text.Contains("tow"));
        Console.WriteLine("Length is " + text.Length);
        Console.WriteLine("Index - " + text.IndexOf('C'));

    }
    /*
      Problem 2 - Write a method that takes no arguments and a void return type. Assign the Unicode value of the Pilcrow Signto a variable. Use the Console WriteLine to print that variable. This variable utilizes the type that takes 1 character.
    
     */
    public static void Unicrow() 
    {
       char unicde = '\u0086';
       Console.WriteLine(unicde);
    }
    /*
       Use 1 string variable and 1 Console Write Line to complete this task.
       Use escape sequences. 
     
       Output should be:
       Jack and Jill
       went up the hill
       to fetch a pail of water.
       Jack fell down and broke his crown
       and Jill came tumbling after.
     */
    public static void JackandJill()
    {
        string jandj = "Jack and Jill \nwent up the hill \nto fetch a pail of water.\n" +
            "Jack fell down and boke his crown \nand Jill came tumbling after.";
        Console.WriteLine(jandj);
    }
    /* 
      Problem 4 - write a method that has no arguments. 
      It has a string return type. 
      Utilzing Interpolation create a sentence that uses Name, favorite Movie, favorite movie snack, favorite movie drink.   
     */
    public static string Favmovie()
    {
        string name = "Kostner David";
        string favmovie = "Akira";
        string favdrink = "Sprite";
        string favsnack = "Popcorn";

        return $"My name is {name}, my favorite movie is {favmovie}, /nalso my favorite snack and drink are {favsnack} and {favdrink}";


}

} // end class
