using System;

namespace numberGuessing
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int secretNumber =  random.Next(1,11); //1 is inclusive, 11 is exclusive
            
            string userGuess;
            int userGuessNumber;
            bool runTheLoop = true;

            Console.WriteLine("Pick a number between 1 and 10");
            userGuess = Console.ReadLine();
            userGuessNumber = Convert.ToInt32(userGuess);

            while (runTheLoop == true) //will continue to run block until runTheLoop is false
            {   
                if (userGuessNumber == secretNumber)
                {
                    Console.WriteLine("You chose wisely");
                    runTheLoop = false; //this will now cause the loop to end
                }
                else
                {
                    Console.WriteLine("You chose poorly");
                    Console.WriteLine("Enter another guess");
                    userGuess = Console.ReadLine();
                    userGuessNumber = Convert.ToInt32(userGuess);
                }
            } //The loop will now run again and test for true
        }
    }
}
