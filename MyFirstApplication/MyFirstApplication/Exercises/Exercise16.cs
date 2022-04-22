using System;

namespace MyFirstApplication;

/*
 Lesson 16 Lab Exercise
 */
internal class Exercise16
{
    /*
    Problem 1 - Write a method that has no parameters and a no return type. Create a
    List<T> of your Horse objects. 
    When creating your list, utilize all the
    constructors you created with your Horse class. Using a foreach loop, print
    out the results of your collection using a Console WriteLine statement.
     */
    public static void HorseList()
    {
        List<Horse> horseList = new List<Horse>();
        horseList.Add(new Horse("Red", "Black", 29));
        horseList.Add(new Horse("Black", "Red", 38));

        foreach (Horse horse in horseList)
        {
            Console.WriteLine(horse.HairColor);
            
            Console.WriteLine(horse.ShoeColor);

            Console.WriteLine(horse.ShoeSize);
        }
    }

    /*
    Problem 2 - Write a method that has no parameters and no return type. Using only the
    data you used when building your favorite movies from exercise 15, create
    a Dictionary collection that takes an int key and string value.
    When adding Dictionary elements, 
    pick an int value as the key and use the favorite
    movies data as the string. 
    Using a foreach loop, print out the results of your
    collection using a Console WriteLine statement.
     */
    public void MveDict()
    {
        Dictionary<int, string> dictionary = new Dictionary<int, string>();
        dictionary.Add(1, "Akira");
        dictionary.Add(2, "Her");
        dictionary.Add(3, "Evangelion");

        foreach (KeyValuePair<int, string> movie in dictionary)
        {
            Console.WriteLine($"Movie key num - {movie.Key}, Movie Title - {movie.Value}");
        }
    }

}