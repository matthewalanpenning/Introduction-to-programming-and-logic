using System;

namespace inputTest
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Enter you name:");
            string myString = Console.ReadLine();
            Console.WriteLine("Hello " + myString + ". Enter a number:");
            string myNumber;
            myNumber = Console.ReadLine();

            Console.WriteLine("Okay " + myString + ". Enter a second number:");
            string myNumber2;
            myNumber2 = Console.ReadLine();

            Console.WriteLine(myString + ", your first number was " + myNumber);
            Console.WriteLine("and your second number was " + myNumber2);

            int myInt; // Creates an interger container in memory
            myInt = Convert.ToInt32(myNumber); //Converts my string to a number
            int myInt2 = Convert.ToInt32(myNumber2);
            int myTotal = myInt + myInt2;

            Console.WriteLine("The sum of your numbers is " + myTotal); 
        }
    }
}
