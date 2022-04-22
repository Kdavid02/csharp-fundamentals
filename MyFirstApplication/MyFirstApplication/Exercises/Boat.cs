namespace MyFirstApplication;

internal class Boat_Object // boat was used already in the namespace
{
    /*
    Problem 2. Create a class based on your Boat_Object object. You will follow the same
    
    instructions as exercise 1 except for the following.
    
    Include your attributes as Expression Body Definition Properties
    */

    public string paintcolor;

    public int sailsize;

    public string sailShape;

    public string PaintColor
    {
        get => paintcolor;
        set => paintcolor = value;
    }
    public int SailSize
    {
        get => sailsize;
        set => sailsize = value;
    }
    public string SailColor
    {
        get => sailShape;

        set => sailShape = value;
    }

    public Boat_Object(string paintcolor, int sailsize, string sailShape)
    {
        this.paintcolor = paintcolor;

        this.sailsize = sailsize;

        this.sailShape = sailShape;
    }



    public Boat_Object(string paintcolor, int sailsize)
        : this(paintcolor, sailsize, "Quadrilateral") { }



    public Boat_Object()
        : this("Orange", 20) { }


    /*
    Exercise Lab 12
    Problem 3 - In your Boat class, add the virtual keyword to your method created in 
    Lesson 10. Create a second version of the same method and add a 
    parameter. 
    Include a Console WriteLine method in the new method that 
    uses the parameter. 
    This parameter needs to be based on one of your 
    properties.
     */
    public virtual void RudderClockwise()
    {
        Console.WriteLine("The properller spins clockwise.");
    }

    public void RudderClockwise(string paintcolor)
    {
        Console.WriteLine($"The {paintcolor} boat rudder is spinning! ");
    }

} // end class