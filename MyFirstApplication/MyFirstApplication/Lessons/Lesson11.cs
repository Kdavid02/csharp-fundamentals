namespace MyFirstApplication;

public class Polygon
{



    //Properties
    protected int NumberOfSides { get; set; }

    /* Base Constructor. If a derived class does not implement
    a base class constructor explicitly, the base constructor
    is called implicitly
     */
    public Polygon()
    {
        NumberOfSides = 1;
    }

    /* 
    This constructor will be access from the child class
    using the base in its constructor.
    */
    public Polygon(int sides)
    {
        NumberOfSides = sides;
    }

    internal double CalculateInteriorAngle()
    {
        return (NumberOfSides - 2) * 180 / NumberOfSides;
    }

} // end class





//Square is the derived class of Polygon
public class Square : Polygon
{
    public Square()
        : base(4)
    {
        // NumberOfSides = 4;
    }
} // end class




//Triangle is the derived class of Polygon
public class Triangle : Polygon
{
    public Triangle()
        : base(3)
    {
        // NumberOfSides = 3;
    }
}