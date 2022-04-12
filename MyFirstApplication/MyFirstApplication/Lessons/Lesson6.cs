namespace MyFirstApplication;

/*
 Lesson 6 -  Constructors, Methods, & More
 */
internal class Lesson6
{
    //      Delegates
    public delegate void TryOn(string type);
    public delegate void TryOnAnotherHat(string type);
    
    
    // private class variables
    private string _hatType;
    private int _hatSize;

    // properties
    public string HatType
    {
        get { return _hatType; }
        set { _hatType = value; }
    }

    public int HatSize
    {
        get { return _hatSize; }
        set { _hatSize = value; }

    }

    /* Default Constructor */
    public Lesson6()
    {
        // Console.WriteLine("Hello Lesson 6");
        TryOnAnotherHat tryHat = TryOnHat;
        TryALargerHat("Fedora", 7, tryHat);
    }

    /* Constructor with 1 parameter */ 
    public Lesson6(int value)
    {
        Console.WriteLine($"Constructor = {value}");
    }

    /* Constructor with 2 parameters */
    public Lesson6(string type, int size)
    {
        _hatType = type;
        _hatSize = size;
    }

    /*
    The in parameter modifier is passed by reference. The argument can
    not be modified as it is readonly
     */
    public void InExample(in int value)
    {
        // value = 23; // can't change the value
        int total = value + 5;
        Console.WriteLine($"in value + 5 = {total}");
    }

    /*
     The ref parameter modifier is passed by reference. The value changed
    in the method affects the called variable.
     */
    public void RefExample(ref int value)
    {
        value += 5;
        Console.WriteLine($"RefExample = {value}");
    }

    /*
     The out parameter modifier is passed by reference. The out variable passed
    in does not have to be initialized.
     */
    public void OutExample(out int value)
    {
        value = 42;
    }

    // Method for Delegates
    public void TryOnHat(string message)
    {
        Console.WriteLine($"TryOnHat = {message}");
    }

    public void TryALargerHat(string type, int oldSize, TryOnAnotherHat anotherHat)
    {
        anotherHat($"I tried on a {type} hat at size {++oldSize}");
    }

    public void HangUpHat(string message)
    {
        Console.WriteLine($"HangUpHag = {message}");
    }



} // end class 
