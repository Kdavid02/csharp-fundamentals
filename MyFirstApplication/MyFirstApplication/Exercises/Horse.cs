namespace MyFirstApplication;
// part of Lesson 10 Lab Exercise - Horse object.
internal class Horse
{
    /*
    Problem 1 - Create a class based on your Horse object. Include your attributes as auto 
    properties. Create 3 constructors. The first constructor should have 
    parameters equal to your properties. 
    
    Assign each parameter to your properties. The second constructor should have 2 parameters. 
    Using the ":this()" keyword, you will pass your information to the first constructor. This 
    includes the 2 parameters and default values. For the last constructor, you 
    will create the default constructor. Using the ":this()" keyword, you will pass 
    2 default values in that will pass to the 2nd constructor. Also include in the 
    class, your method for Horse.  
    */

    public string HairColor { get; init; }

    public string ShoeColor { get; init; }

    public int ShoeSize { get; init; }

    public Horse(string haircolor, string shoecolor, int shoesize)
    {
        HairColor = haircolor;

        ShoeColor = shoecolor;

        ShoeSize = shoesize;
    }

    public Horse(string haircolor, int shoesize)
        : this(haircolor, "red", shoesize) { }

    public Horse(string love)
        : this("Brown", 32) { }

    public virtual void KicksBackward()
    {
        Console.WriteLine("The horse kicks their hind legs back.");
    }

} // end class