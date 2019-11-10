using System;

namespace whatsForLunch
{
    class Program
    {
        static void Main(string[] args)
        {
            string lunchAnswer;
            string lowerCaseLunchAnswer;
            string onlyFirstCharacterOfLowerCaseLunchAnswer;

            Console.WriteLine("Have you had lunch yet? [y,n]");
            lunchAnswer = Console.ReadLine();
            lowerCaseLunchAnswer = lunchAnswer.ToLower(); //converts the string to lowercase letters
            onlyFirstCharacterOfLowerCaseLunchAnswer = lowerCaseLunchAnswer.Substring(0,1);


            if (onlyFirstCharacterOfLowerCaseLunchAnswer == "y")
            {
                Console.WriteLine("Congratulations!");
            }
            else
            {
                Console.WriteLine("Do you want pizza?");
                string allInOne = Console.ReadLine().ToLower().Substring(0,1);
                if (allInOne == "y")
                {
                    Console.WriteLine("Wait for me, I am coming with you");
                }
                else
                {
                    Console.WriteLine("You are missing out");
                }
            }

        }
    }
}
