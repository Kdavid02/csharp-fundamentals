using System;

namespace MyFirstApplication;
/*
 * Class for exercise 1 problems.
 */
public class Exercise1
{

    /*
    Exercise 1 method; 
    
    Problem  1 - Asign the value 35 to a varible in several data types,
    using decimal, binary, and hexadecimal and then print them.
     */
    public static void Systypeprint()
    {
        decimal decinum = 35;
        int binarynum = 0b100011;
        int hexanum = 0x_23;
        Console.WriteLine(decinum);
        Console.WriteLine(binarynum);
        Console.WriteLine(hexanum);
    }
    /*
     * Problem 2 - Use 3 args doub flt long and covert From double to long. From float to int. From long to short. And print
     */
    public static void Convertbyte(double doub, float flt, long lng) {
        long converted = (long)doub;
        Console.WriteLine(converted);
        converted = (int)flt;
        Console.WriteLine(converted);
        converted = (short)lng;
        Console.WriteLine(converted);



    }
    public static void Digseperate() {
        double doubnum_1 = 123_456.987;
        int intnum_1 = -9_516_248;
        int intnum_2 = 3_500;
        long lngnum = 988_562_486;
        double doubnum_2 = -19_733.14895;
        Console.WriteLine(doubnum_1);
        Console.WriteLine(intnum_1);
        Console.WriteLine(intnum_2);
        Console.WriteLine(lngnum);
        Console.WriteLine(doubnum_2);






    }


}
// end class

