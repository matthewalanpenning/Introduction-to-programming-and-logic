using System;
using System.Collections;
using System.Linq;

namespace arrayList
{
    class Program
    {
        static void Main(string[] args)
        {


            int test = Convert.ToInt32(Math.PI);
            Console.WriteLine(test);
            double test2 = Math.PI;
            Console.WriteLine(test2);
            float test3 = (float)Math.PI;
            Console.WriteLine(test3);

            
            ArrayList poptart = new ArrayList();
            int killLoop = 0;
            while(killLoop == 0)
            {
                Console.WriteLine("Enter in your poptart flavor");
                poptart.Add(Console.ReadLine());
                
                Console.WriteLine("Do you have any more poptarts?");
                string answer = Console.ReadLine();
                if (answer == "no"){
                    killLoop = 1;
                }
            }

            int howManyPoptarts = poptart.Count;
            poptart.Sort();
            Console.WriteLine(poptart[0]);



            ArrayList myNumbers = new ArrayList();
            int killTheLoop = 0;
            int counter = 0;
            while (killTheLoop == 0){
                Console.WriteLine("Enter in your number");
                myNumbers.Add(Console.ReadLine());

                if (Convert.ToString(myNumbers[counter]) == "end"){
                    killTheLoop = 1;
                }

                counter++;

                if (myNumbers.Contains("end")){
                    killTheLoop = 1;
                }
            }
            
            double sumOfMyNumbers = 0;

            for(int i = 0; i < myNumbers.Count - 1; i++)
            {
                sumOfMyNumbers = sumOfMyNumbers + Convert.ToDouble(myNumbers[i]);
            }
            
            int totalElementsMinusOne = myNumbers.Count - 1;
            Console.WriteLine(sumOfMyNumbers/totalElementsMinusOne);

           
        }
    }
}
