namespace MyFirstApplication;

/*
Child class from horse object for Exercise 11-12
 */
internal class Pony : Horse
{
    /*
     Problem 1 - Create a child class based on your Horse object. Include one child attribute
    as an auto property. Create 3 constructors. 
    The first constructor should have 5 parameters with 4 of them from Horse and your child property. 
    Using the keyword ":base()".
    you will put the four horse parameters in the
    parenthesis. In the body of the constructor you will assign your child
    parameter to your property. 
    The second constructor should have 3 parameters, 2 based on the horse 
    and 1 from your child. 
    Using the :this() keyword , you will pass 2 of the 
    parent attributes and your child attribute information to the first 
    constructor. 
    Include default values to represent the 2 remaining horse parameters.

    For the last constructor, you will create the default constructor. Using the 
    :this() keyword, you will pass 3 default values in that will pass to the 2nd
    constructor. Also include in the class, your method for your child class
     */
    public int CrestLength { get; set; }

    public Pony(string haircolor, string shoecolor, int shoesize, int crestlength)
        : base(haircolor, shoecolor, shoesize)
    {

        CrestLength = crestlength;
    
    }

    public Pony(string haircolor, string shoecolor, int crestlength)
        : this(haircolor, shoecolor, 3, crestlength) { }

    public Pony()
        : this("Pale", "yellow", 43) { }

    public void RunForward()
    {
        Console.WriteLine("The pony runs quickly in a forward direction");
    }

    /*
    Lesson 12 Lab Exercise
   Problem 2 - In your child class of Horse, using the override keyword create a method 
    that has the same name as the virtual method from Horse. Add a Console 
    WriteLine that provides a different message from the Horse.
     */
    public override void KicksBackward()
    {
        Console.WriteLine("The pony kicks backward swiftly.");
    }

} // end class