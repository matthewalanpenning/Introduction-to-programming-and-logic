using System;

namespace howMany
{
    class Program
    {
        static void Main(string[] args)
        {
            string letterToLookFor;
            string stringToLookThrough;
            int howLongLetterToLookForIs;
            int howLongStringToLookThroughIs;
            bool shouldILoop = true;
            int startingValue = 0;
            int howManyTimesItOccurs = 0;

            Console.WriteLine("Enter in the letter to search for");
            letterToLookFor = Console.ReadLine();
            letterToLookFor = letterToLookFor.ToLower();
            howLongLetterToLookForIs = letterToLookFor.Length;

            Console.WriteLine("Enter the string to look through");
            stringToLookThrough = Console.ReadLine();
            stringToLookThrough = stringToLookThrough.ToLower();
            howLongStringToLookThroughIs = stringToLookThrough.Length;

            while (shouldILoop) 
            {
                if(letterToLookFor == stringToLookThrough.Substring(startingValue,howLongLetterToLookForIs))
                {
                    //howManyTimesItOccurs = howManyTimesItOccurs + 1;
                    howManyTimesItOccurs++; //increments by 1
                }

                startingValue = startingValue + 1;
                if(startingValue == howLongStringToLookThroughIs)
                {
                    shouldILoop = false;
                }

                if(startingValue == (howLongStringToLookThroughIs - howLongLetterToLookForIs))
                {
                    shouldILoop = false;
                }

            }
            
            Console.WriteLine(howManyTimesItOccurs);
    
        }
    }
}
