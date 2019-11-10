using System;

namespace stringM
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "Epson Projector";
            int whereNIs = myString.IndexOf(" "); //starts counting at 0
            Console.WriteLine(whereNIs);
            string mySubString;
            int startingPoint = 0;
            mySubString = myString.Substring(startingPoint,5); //starts at 0, 5 character long
            Console.WriteLine(mySubString);
        }
    }
}
