namespace MyFirstApplication;



/*
 Static class must have static methods 
as you can not use instance methods.
 */
internal static class Lesson8Static
{
    public static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    public static double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }




} // end class
