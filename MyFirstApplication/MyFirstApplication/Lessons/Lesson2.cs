
namespace MyFirstApplication;

/*
 This class goes over Strings
 */
internal class Lesson2
{
    string myString = "Hello World";

    // String Method - Trim
    public void MyTrimExample()
    {
        string str = " Word ";
        // before trim
        Console.WriteLine(str);
        // trim
        string myTrim = str.Trim();
        // after trim
        Console.WriteLine(myTrim);
    }

    // String Method - Equals
    public void MyEqualsExample(string beta)
    {
        Console.WriteLine(beta.Equals("World"));
    }

    // String Methods ToUpper and ToLower
    public void MyUpperLowerExample()
    {
        Console.WriteLine(myString.ToUpper());
        Console.WriteLine(myString.ToLower());
    }

    // String Method - Length
    public int MyStringLength()
    {
        return myString.Length;
    }


    // Char - Uses single quotes
    public void MyExampleChar()
    {
        char myChar = 't';
        char copyright = '\u00A9';
        char something = '\x00A9';
        Console.WriteLine(myChar);
        Console.WriteLine(copyright);
        Console.WriteLine(something);
    }

    // Escape Sequences
    public string MyEscapeExample()
    {
        return "That\'s a cool car. \tCan I \ndrive it sometime?";
    }


    // Concatenation - with 2 string parameters
    public void MyJoinedStrings(string value1, string value2)
    {
        Console.WriteLine(value1 + " " + value2);
    }

    // String Interpolation
    public string MyInterpolationExample(string food, int amount)
    {
        return $"My favorite food is {food} and I ate {amount} servings of it.";
    }

    // ($"|{"Number", -10} | {"Order", 15}|")
    public void MyOtherInterpolation()
    {
        Console.WriteLine($"|{"Number", -10} | {"Order", 15}|");
    }

} // end class
