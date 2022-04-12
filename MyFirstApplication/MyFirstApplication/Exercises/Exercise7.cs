namespace MyFirstApplication;
/*
 * Lab Exercise 7 - Records and Structs.
 */
public class Exercise7
{
	/*
	Problem 1 - Change the type from class to struct. Change the name of the struct from 
	Exercise7 to Employee. The filename should not be changed. Create 2 
	struct variables. The first one will be of type int and be named _id. The 
	second variable should be of type string and be named _name. Create a 
	constructor that takes 2 arguments, with the first being an int and the 
	second a string. The struct variables should be assigned to the constructor 
		Constants are immutable values and do not change for the duration of the program. “const” is the keyword modifier use for a constant. The static modifier is used to declare a static member which belongs to the type itself rather than a particular object. I can be used with fields, methods properties, operators, events and constructors. Static does not work for indexers and finalizers. Static Class is the same as a non-static class, except that it cannot be instantiated. Static fields and methods can be used in non-static classes. Static methods cannot access instance variables. Static modifier with lambda expression can be used to prevent accidental capture of local variables or an instance by a lambda. The static modifier is used before lambda expression.

	I think I understand this lesson well. This lesson made sense to me and was simple to learn. I can see the use cases of static and constants and with practices I think I’ll get used to using them as they are pretty simple compared to the other concepts like lambda.
	parameters. Create properties for these 2 variables.
		 */
	internal struct Employee
	{
		private int _id;
		private string _name;
		
		public int Id { 
			get { return _id; }
			set { _id = value; }

		}

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}
    public Employee(int id, string name)
        {
			_id = id;
			_name = name;
        }
	}
}

/*
Problem 2 - Create a Record based on your Boat object from the Object Oriented 
Programming lesson. In your record body, include the boat method that 
you defined. This record can be in the same file as exercise 1. Just put the 
code under it as seen in the lecture. Test your record to ensure it is working 
correctly
*/
internal record Boat(string spin)
{
	public void PropellerSpinClockwiseCounter()
	{
		Console.WriteLine(spin);
	
	}

}