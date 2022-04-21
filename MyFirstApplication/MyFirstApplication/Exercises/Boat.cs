namespace MyFirstApplication;

/* This class contains part of the Exercise 10 Lab */
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


} // end class