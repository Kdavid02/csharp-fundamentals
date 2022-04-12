namespace MyFirstApplication;


/*
 A Record is a reference type that provides built-in functionality
for encapsulating data
 */
internal record Person(string firstName, string lastName);

/*
 A Record struct is a value type with similar functionality as a record class
 */
public record struct Resolution(int width, int height)
{
    public void CalculateRes()
    {
        Console.WriteLine(width * height);
    }
} // end record
