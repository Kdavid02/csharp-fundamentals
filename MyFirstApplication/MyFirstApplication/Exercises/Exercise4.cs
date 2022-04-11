namespace MyFirstApplication;

/*
Lesson 4 Lab Exercise - Use different Control Flow statements like if-else statments, switch, etc to activate different statments 
*/
public class Exercise4
{

    /* 
    Problem 1  - Write a method that takes 2 string arguments and an boid return type. Use and if-else statment to 
    compare the 2 strings to one another. Use a console.writeline statement to show if they are equal.
     */
    public static void StringCompare(string stringarg_1, string stringarg_2)
    {
        if (stringarg_1 == stringarg_2) 
        {
            Console.WriteLine("They are equal");
        }
        else 
        {
            Console.WriteLine("They are not equal");
        }
        // stringarg_1 = cat, stringarg_2 = dog
        // 2nd test I used. stringarg_1 = cat, stringarg_2 = cat


    }
    /* 
   Problem 2  - Write a method that takes 1 char argument and a string return type. 
   Use a switch that determines the right grade.
   [E Excellent, V Very Good, G Good, A  Average, F Fail.]
     */

    public static string Gradecheck(char gradearg) 
    { 
        switch (gradearg)
        {
            case 'E':
                return ("Excellent");          
            case 'V':
                return ("Very Good");
            case 'G':
                return ("Good");
            case 'A':
                return ("Average");
            case 'F':
                return ("Fail");
            default:
                return ("Retry and input a valid character.");






        }

    }
    /*
     * Problem 3 - Write a method with no arugments and a void return type. Show all numbers divisable by 3 (0-30) 
     * use Console.WriteLine to show them.
     */ 
    public static void Dividethree()
    {
        for (int i = 0; i < 31; i++)
        {
            if (i % 3 == 0)
            {
                Console.WriteLine(i);
            }
        }
    
    }
        
}