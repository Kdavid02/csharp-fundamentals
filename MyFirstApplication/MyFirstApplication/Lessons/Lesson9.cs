namespace MyFirstApplication;

internal class Lesson9
{
    private int _value = 10;

    /*
     * Private access modifier can only be seen within the class, struct or nested type.
     */ 
    private void SamplePrivate()
    {
        Console.WriteLine("This method is private");
    }

    /*
     * Protect access modifers can only be seen within the type or a child(derived) class
     */ 
    protected void SampleProtected()
    {
        Console.WriteLine("This method is protected");
    }

    /*
     * Internal Access Modifier can be seen within the assembly, not other 
     */
    

    internal void SampleInternal()
    {
        Console.WriteLine("This method is internal");
    }

    /*
     * Protected internal can be seen within the assembly or child(derived)
     * class from another assembly.
     * 
     */
    protected internal void SampleProtectedInternal()
    {
        Console.WriteLine("This method is protected internal");
    }

    /*
     * Private Proteced can be seen only within the class and child dervied class 
     * from within the assembly
     */
    private protected void SamplePrivateProtected()
    {
        Console.WriteLine("This method is private protected");
    }
    public class Nested
    {

        public Nested(Lesson9 parent)
        {
            Console.WriteLine($"The value is {parent._value}");


        }

    } // end nested class
} // end class