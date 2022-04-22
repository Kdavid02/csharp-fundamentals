using System;

namespace MyFirstApplication;

/*
Child class for Excerise 11-12 from Boat
 */
internal class Dinghy_Boat : Boat_Object
{
    /*
    Problem 2 - Create a child class based on your Boat object. 
    You will follow the same 
    instructions as Exercise 1 except for the following - 
    Include 1 child attribute
    as Expression Body Definition Properties
     */

    public int InnerPressure;

    public int innerpressure
    {
        get => innerpressure; 
        set => innerpressure = value; 
    }

    public Dinghy_Boat(string paintcolor, int sailsize, string sailShape, int innerpressure)
        : base(paintcolor, sailsize, sailShape)
    { 
        this.innerpressure = innerpressure;
    }

    public Dinghy_Boat(string paintcolor, int sailsize, int innerpressure)
        :this(paintcolor, sailsize, "Triangle" , innerpressure) { }

    public Dinghy_Boat()
        
        :this("White", 83, 229) { }

    public void Pressurize()
    {

        Console.WriteLine("The dinghy boat is increasing in pressure.");
    }

    /*
     
    Exercise 12 
    Problem 2 - In your child class of Boat, using the override keyword create a method 
    that has the same name as the virtual method from Boat. 
    Add a Console.WriteLine that provides a different message from the Boat
     */

    public override void RudderClockwise()
    {

        Console.WriteLine("The dinghy boat\'s Rudder turns clockwise.");
    }

} // end class