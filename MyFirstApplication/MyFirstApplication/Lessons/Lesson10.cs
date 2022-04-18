namespace MyFirstApplication;
/*
 * Encapsulaiton is the process of wrapping data and the code 
 * into a single unit
 */
internal class Lesson10
{
    private string _firstname;
    private string _address;
    protected int zipcode;
    public string Firstname
    { 
        get { return _firstname; }
        set { _firstname = value; }
    }

    // auto-implemented property with init keyword
    public string LastName { get; init; }
    
    // auto-implemented property with a default value
    public int Id { get; set; } = 1000;

    // property with private set
    public long Phone { get; private set; }

    // expression bodied member property
    public string Address
    {
        get => _address;
        set => _address = value;
    
    }
    public int Zipcode
    {
        get => zipcode;
        set => zipcode = value;
    }
    // default constuctor
    public Lesson10()
        :this("John", "Doe", 64082) { }

    // constructor using this with varibles
    public Lesson10(string firstName, string lastName, int zipcode)
        {
            _firstname = firstName;
            LastName = lastName;
            this.zipcode = zipcode;
            
        }
    
    
    /*
     * This method shows how you can change a private set property
     * but not a property with init
     */ 
    private void ShowLastAndPhone()
    {
        // Lastname = "Jon";
        Phone = 12345678;
    }


} // end class
