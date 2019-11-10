using System;

namespace makingDecisions
{
    class Program
    {
        static void Main(string[] args)
        {
            string thePersonAge;
            string theMonth;
            


            string currentMonth = DateTime.Now.ToString("MMMM"); //MMM is Sep, MMMM is September
            

            Console.WriteLine("Please enter your age!");
            thePersonAge = Console.ReadLine();
            Console.WriteLine("What month were you born in?");
            theMonth = Console.ReadLine();

            /* 
            if (Convert.ToInt32(thePersonAge) > 21 && (theMonth == "September" || theMonth == "May")){
                    Console.WriteLine("You get a free pizza");
            }
            

        
            if (Convert.ToInt32(thePersonAge) > 21 && !(theMonth == "September" || theMonth == "May")){
                Console.WriteLine("You get a free pizza");
            }
            */


            if (Convert.ToInt32(thePersonAge) > 21 && theMonth == currentMonth){
                Console.WriteLine("You get a pizza!");
            }


        }
    }
}
