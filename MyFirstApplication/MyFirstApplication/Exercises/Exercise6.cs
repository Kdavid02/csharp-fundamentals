namespace MyFirstApplication;

/*
 Lesson 6 Lab Exercie -  Constructors, Methods, & More
*/


public class Exercise6
{
    /* Problem 1 - Write a constructor for your exercise file that takes 2 parameters.The first
    parameter should have an int type and a variable name of showSize. The
    second parameter should have a string type and a variable name of
    shoeType. Create private class variables for these types and use and
    underscore when defining them. Inside the constructor associate the class
    variables with the constructor parameters.
    */
    private int _showSize;
    private string _shoeType;

    public Exercise6(int size, string type)
    {
        _shoeType = type;
        _showSize = size;
       
    }


    /*
     * Problem 2 - Using the class varibles defined in exercise 1 write the properties.
     * They are to be labeled as public and are capitlized.
     */
    public int ShowSize
    {
        get { return _showSize; }
        set { _showSize = value; }
    
    }

    public string ShoeType
    {
        get { return _shoeType; }
        set { _shoeType = value; }
    
    }
    /*
   Problem 3 - Write a delegate that takes a string parameter. This delegate should be 
    named TryOn. Write a method that takes a string argument and void 
    return type. In the method body include a Console.WriteLine statement 
    that will print the message. Test your delegate in Program.cs to ensure 
    everything works properly. Using a mult-line comment on your 
    Exercise6.cs file, provide the information you used to test the delegate
    */
    public delegate void TryOn(string type);

    public void ShoeTryOn(string msg)
    {
        Console.WriteLine(msg);
    }

    /*
     * Tested with this
     *             void Exercise6test()
            {
                Exercise6 Shoe_1 = new Exercise6(2, "Nike");

                Exercise6.TryOn tryshoes = Shoe_1.ShoeTryOn;

                tryshoes($"Try on {Shoe_1.ShoeType}'s with a size of {Shoe_1.ShowSize}");
            }
    Result was: "Try on Nike's with a size of 2"
     */




}
