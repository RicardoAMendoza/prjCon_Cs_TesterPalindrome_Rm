using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjCon_Cs_TesterPalindrome
{
    /*
     * This project uses the following licenses:
     *  MIT License
     *  Copyright (c) 2019 Ricardo Mendoza 
     *  Montréal Québec Canada
     *  Institut Teccart
     *  www.teccart.qc.ca
     *  Hiver 2019
     *  été 2020
     */
    class Program
    {
        static void Main(string[] args)
        {
            // --------- Palindrome ----------
            // variable
            int x = 5;
            string chaine = "rotatoro";
            Console.WriteLine("\nTESTER SI C'EST PALINDROME", Console.ForegroundColor=ConsoleColor.Green);
            chaine = "anona";
            Console.WriteLine("\nMot = {0} | Palindrome = {1}", chaine, fncEstPalindrome(chaine), Console.ForegroundColor=ConsoleColor.Yellow);
            chaine = "ressasser";
            Console.WriteLine("\nMot = {0} | Palindrome = {1}", chaine, fncEstPalindrome(chaine), Console.ForegroundColor=ConsoleColor.Yellow);
            chaine = "retâter";
            Console.WriteLine("\nMot = {0} | Palindrome = {1}", chaine, fncEstPalindrome(chaine), Console.ForegroundColor=ConsoleColor.Yellow);
            chaine = "rotator";
            Console.WriteLine("\nMot = {0} | Palindrome = {1}", chaine, fncEstPalindrome(chaine), Console.ForegroundColor=ConsoleColor.Yellow);
            chaine = "rotato";
            Console.WriteLine("\nMot = {0} | Palindrome = {1}", chaine, fncEstPalindrome(chaine), Console.ForegroundColor=ConsoleColor.Yellow);
            chaine = "nenorra";
            Console.WriteLine("\nMot = {0} | Palindrome = {1}", chaine, fncEstPalindrome(chaine), Console.ForegroundColor = ConsoleColor.Yellow);
            chaine = "ramiro";
            Console.WriteLine("\n\nMot = {0} | Palindrome = {1}", chaine, fncEstPalindrome(chaine), Console.ForegroundColor = ConsoleColor.Yellow);
 
            Console.WriteLine("\n\n\nLambda expression : " + getSquare(x), Console.ForegroundColor = ConsoleColor.Blue);
            Console.ReadKey();
            Console.WriteLine("\n\n LOOP  PROGRAM TESTER PALINDROME ");
            try
            {
                string palindrome;
                char end;
                //Console.WriteLine("\n WRITE AND TRY PALINDROME -> \n " , Console.ForegroundColor=ConsoleColor.Green);
                //palindrome = Convert.ToString(Console.ReadLine().ToUpper());
                //Console.WriteLine("\n\n palindrome -> " + palindrome);
                do
                {
                    Console.WriteLine("\n WRITE AND TRY PALINDROME -> \n ", Console.ForegroundColor = ConsoleColor.Green);
                    palindrome = Convert.ToString(Console.ReadLine().ToUpper());
                    Console.WriteLine("\n\n palindrome -> " + palindrome);
                    Console.WriteLine("\nMot = {0} | Palindrome = {1}", palindrome, fncEstPalindrome(palindrome), Console.ForegroundColor = ConsoleColor.Magenta);
                    Console.WriteLine("\n\n Lambada Expresion => " + getSquare(x), Console.ForegroundColor = ConsoleColor.Blue);

                    Console.WriteLine("\n Continue [Y/N]");
                    end = char.Parse(Console.ReadLine().ToUpper());
                }
                while (end == 'Y');
            }
            catch(Exception e)
            {
                Console.WriteLine("erroir in program : " + e.Message);
            }
            finally
            {
                /* A common usage of catch and finally together is to obtain and use resources in a try block */
                /* deal with exceptional circumstances in a catch block, and release the resources in the finally block. */

                // To run the program in Visual Studio, type CTRL+F5. Then
                // click Cancel in the error dialog.
                Console.WriteLine("\n\n LAMBADA EXPRESION => " + getSquare(x), Console.ForegroundColor = ConsoleColor.Blue);
                Console.WriteLine("\n\n Lambada expresion Function into finally block " , Console.ForegroundColor = ConsoleColor.Gray);
                
            }
            Console.ReadLine();
        }

        /* Try Lambada Expresion*/
        private static int getSquare(int x) => x * x;

        // Palindrome
        // staic -> methods are methods that are called on the class itself, not on specific object instance
        // private -> the method can be acceced only by code in the same class or struct
        private static Boolean fncEstPalindrome(string value)
        {
            // variable
            int startindex = 0;
            int endindex = value.Length-1;
            // Longueur pair -> ne peut pas etre palindrome
            if((value.Length%2)==0)
            {
                Console.WriteLine("\n\nLongueur paire -> NON un palindrome",Console.ForegroundColor=ConsoleColor.Gray);
               // Console.WriteLine("\nStart Index : " + Convert.ToString(startindex));
               // Console.WriteLine("\nEnd Index : " + Convert.ToString(endindex));
                return false;
            }
            // longueur impaire -> peut etre palindrome
            Console.WriteLine("\n\nLongueur impaire -> peut etre palindrome",Console.ForegroundColor=ConsoleColor.Cyan);
            // Console.WriteLine("\nStart Index : " + Convert.ToString(startindex));
            // Console.WriteLine("\nEnd Index : " + Convert.ToString(endindex));
            while (startindex < endindex)
            {
                /* Substring(Int32, Int32) -> Retrieves a substring from this instance. */
                /* To extract a substring that begins at a specified character position and ends before the end of the string, */
                /* call the Substring(Int32, Int32) method.This method does not modify the value of the current instance.*/
                /* Instead, it returns a new string that begins at the startIndex position in the current string. */
                // The substring starts at specified character position and has a specified length.
                if (value.Substring(startindex, 1) != value.Substring(endindex, 1))
                {
                    return false;
                }
                startindex += 1;
                endindex -= 1;
            }
            return true;
        }
    }
}
