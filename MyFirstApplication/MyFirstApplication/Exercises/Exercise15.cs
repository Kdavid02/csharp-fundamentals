namespace MyFirstApplication;

/*
Lesson 15 Lab Exercise - Enums and Tuples 
 */

/*
Problem 1 - Above the class, write an enum called Favorite Movies. Add your own
favorite movies to the enum. Write a method that has a string return type
and an enum parameter. This enum parameter will be your favorite movie
enum. Write a switch expression that takes the enum and prints out a
string return. Use string interpolation in your return message that includes
the name of the movie chosen.
 */

public enum FavoriteMovies 
  { 
    Akira, 
    Her, 
    Evangelion 
  }
internal class Exercise15
{
    public string Mves(FavoriteMovies mveNme)
    {
        string movie = mveNme switch
        {

            FavoriteMovies.Akira => $"Favorite movie is {FavoriteMovies.Akira}",
            
            FavoriteMovies.Her => $"Favorite movie is {FavoriteMovies.Her}",

            _ => $"Favorite movie is {FavoriteMovies.Evangelion}"
        };
        return movie;
     }

    /*
    Problem 2 - Write a method that takes an enum parameter. This enum will be your
    favorite movie enum. The method will have a tuple return type (int num,
    string movie). 
    Using an explicit int cast on one of your enum, assign the
    value to an int variable. 
    Create second variable of type string. Assign the
    same enum value you used and use the ToString() at the end of it. Return
    both variables as a tuple. See example below for clarity.
    a. Int value = (int)Enum.Value;
    b. string something = Enum.Value.ToString();
     */
    public (int num, string movie) BestMves(FavoriteMovies movie)
    {
        int value = (int)movie;
        string name = movie.ToString();
        return (value, name);
    }

}