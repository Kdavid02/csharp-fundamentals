
namespace MyFirstApplication;

/*
 This lesson goes over Operators and Overflow Checking
 */

internal class Lesson3
{
    // Checked This keyword will produce an error if values exceed max or min capacity
    // 2147483647
    public void BasicCheckedOperator(int val)
    {
        int total = checked(2147483647 + val);
        Console.WriteLine(total);
    }

    public void BasicCheckedExample2()
    {
        int able = 10;
        checked
        {
            int total = 2147483647 + able;
            Console.WriteLine(total);
        }
    }

    // Unchecked will remove the Exception from constant values
    public void BasicUncheckedExample()
    {
        int total = unchecked(Int32.MaxValue + 10);
        Console.WriteLine(total);
    }

    // Arithmetic Operator
    public void BasicMath()
    {
        int able = 20, beta = 10;

        int addTotal = able + beta;
        int subtractTotal = able - beta;
        int multiplyTotal = able * beta;
        int divideTotal = able / beta;

        Console.WriteLine($"Addition = {addTotal}, Subtraction = {subtractTotal}");
        Console.WriteLine($"Multiplication = {multiplyTotal}, Division = {divideTotal}");
    }

    // Modulus Operator
    public void BasicModulus(int beta)
    {
        int total = 10 % beta;
        Console.WriteLine(total);

        Console.WriteLine(+24);
        Console.WriteLine(-345);
    }

    // Boolean Logical Operators
    public void BasicBooleanLogical(bool arg, bool arg2)
    {
        // And
        Console.WriteLine(arg & arg2);
        // Or
        Console.WriteLine(arg | arg2);
        // Exclusive Or
        Console.WriteLine(arg ^ arg2);
        // &&
        Console.WriteLine(23 > 10 && 10 < 5);
        // ||
        Console.WriteLine(23 > 10 || 10 < 7);
    }

    // Compound Assignment Operators
    public void BasicCompoundExample(int val1, int val2, int val3)
    {
        // val1 = 12, val2 = 35
        // same as val1 = val1 + val2 or val1 = 12 + 35
        val1 += val2;
        Console.WriteLine(val1);

        val2 *= (val3 + val1);
        Console.WriteLine(val2);
    }

    // Relational Operators
    public void BasicRelationalExample(string name, string beta)
    {
        Console.WriteLine(name == beta);
        Console.WriteLine(name != beta);
    }

    // This method will show increment and decrement
    public void MyIncDecrExample()
    {
        int alpha = 11, beta = 16;
        alpha++; // post increment
        Console.WriteLine(alpha);
        ++alpha; // pre increment
        Console.WriteLine(alpha);

        beta--; // post decrement
        Console.WriteLine(beta);
        --beta; // pre decrement
        Console.WriteLine(beta);
    }




} // end class
