using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1___The_Basics
{
    internal class Program //Maxym F.
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string favMovie = "THE Matrix", firstName = "Maxym", favQuote = "Roads? Where we're going, we don't need roads.", picture = @">o)     __
(_<    ( o>
       ///\
       \V_/_";       
            

            Console.WriteLine($"hi! i am {firstName.ToLower()}, and my favourite movie of all time is {favMovie.ToLower()}!");
            favMovie = favMovie.ToUpper();
            Console.WriteLine(favMovie);
            Console.WriteLine(favMovie.Contains("THE")); //Want capitals bc beneath we had upper case E and A (it wont find it if we dont have capitals)
            //couldda done capital and lowercase A and E, but that wouldda taken longer

            favMovie = favMovie.Replace("E", "3");
            favMovie = favMovie.Replace("A", "@"); //These 3 lnes of code print the NEW favMovie with the changed letters.
            Console.WriteLine(favMovie);

            favQuote = favQuote.ToUpper(); //A, E, I, O, U, Y
            Console.WriteLine(favQuote);
            

            favQuote = favQuote.Replace("A", "");
            favQuote = favQuote.Replace("E", "");
            favQuote = favQuote.Replace("I", "");
            favQuote = favQuote.Replace("O", "");
            favQuote = favQuote.Replace("U", "");
            favQuote = favQuote.Replace("Y", "");
            Console.WriteLine(favQuote);
            
            Console.WriteLine(" ");
            

            Console.WriteLine(picture);



        }
    }
}
