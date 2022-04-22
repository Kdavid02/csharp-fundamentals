using System;
namespace MyFirstApplication;

/*
 Lab Exercise 13 - Abstract Class and Properties
*/

/*
Problem 1 - In your Exercise13.cs file, change your class to an Interface and name it 
IMovement. 
This interface will have 1 property. The property will an int 
and called Speed. It will have a get and init.
 */
internal interface IMovement
{
    int Speed { get; init; }

} 

/*
Problem 2 - Under the interface you will create an Abstract class called WaterBirds. 
This abstract class will implement the IMovement interface. The interface 
property should be implemented in the Abstract class as an abstract 
property. Create two abstract methods for the abstract class that is related 
to WaterBirds. Create a constructor that will take an int parameter and be 
assigned to the Speed property.
 */
internal abstract class WaterBirds : IMovement
{
    public abstract int Speed { get; init; }

    public abstract void Tweet();
    public abstract void FlapWings();

    public WaterBirds(int speed)
    {
        this.Speed = speed;
    }
}

/*
Problem 3 - Under the Abstract class Waterbirds, create a derived class that will extend 
the WaterBird class. 
Implement the abstract methods and property. Use 
Console Writeline statements in your methods that provide information 
related to the methods. One of them should use an Interpolation string and 
consume the Speed property. Create a constructor that will take an int 
parameter and use the :base() to pass that int value back to the base 
Abstract class
 */
internal class Pelican : WaterBirds
{
    public override int Speed { get; init; } = 3;

    public override void Tweet()
    {
        Console.WriteLine($"The Water Bird tweets it's simple but sweet song!");
    }

    public override void FlapWings()
    {
        Console.WriteLine($"The bird flies at the speed of {Speed} mph across the ocean");
    }
    // part of problem 3 
    
    public Pelican(int speed)
        : base(speed) { }

} // end class