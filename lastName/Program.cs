using System;

namespace lastName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter both your first and last name:"); //greets the user, prints the line
            string theirName = Console.ReadLine(); //gets the user's input, stores in it in the variable
            int whereTheSpaceIs = theirName.IndexOf(" "); //gets the location of the space
            int whereTheSpaceIsPlusOne = whereTheSpaceIs + 1; //adds one to the space number

            int theirNameLength = theirName.Length; //stores the length of characters in variable
            Console.WriteLine(theirNameLength); //writes the variable

            int theLastNameLength = theirNameLength - whereTheSpaceIsPlusOne; //gives length of lastname
            Console.WriteLine(theLastNameLength);

            if (theLastNameLength >= 5)
            {
                //the next line will crash if lastname is less than 5 characters
                string firstFiveOfLastName = theirName.Substring(whereTheSpaceIsPlusOne,5);
                Console.WriteLine(firstFiveOfLastName); 
            }

            if (theLastNameLength < 5)
            {
                Console.WriteLine("Your name was too short for this program");
                string lastNameForThosePeople = theirName.Substring(whereTheSpaceIsPlusOne,theLastNameLength);
                Console.WriteLine(lastNameForThosePeople);
            }

            if (theLastNameLength == 7) //== reads "is equal to"
            {
                Console.WriteLine("Your lastname is the same length as Penning");
            }


        }
    }
}
