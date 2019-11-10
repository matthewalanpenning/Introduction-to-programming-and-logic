using System;

namespace forLoop
{
    class Program
    {
        static void Main(string[] args)
        {

            


            int howHighToCount;
            int countBy;
            Console.WriteLine("How high would you like me to count?");
            howHighToCount = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("What would you like to count by?");
            countBy = Convert.ToInt32(Console.ReadLine());

            /*
            int currentNumber = 1;
            while(currentNumber <= howHighToCount)
            {
                Console.WriteLine(currentNumber);
                currentNumber = currentNumber + 1;
            }
            */

            /* 
            for(int currentNumber = 1;currentNumber <= howHighToCount;currentNumber++){
                Console.WriteLine(currentNumber);
            }
            */

            for (int i = countBy; i <= howHighToCount; i = i + countBy){
                Console.WriteLine(i);
            }


        }
    }
}
