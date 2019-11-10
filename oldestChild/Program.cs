using System;
using System.Linq;



namespace oldestChild
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfChildren;  
            double averageAge; 


            Console.WriteLine("How many children do you have?");
            numberOfChildren = Convert.ToInt32(Console.ReadLine());

            double[] childAge = new double[numberOfChildren]; //creates an array named childAge that holds doubles
            // childAge[2] = 5;  This would change the value of index 2 to the number 5

            string[] childName = new string[numberOfChildren];

            for (int i = 0;i < numberOfChildren;i++)
            {
                Console.WriteLine("What is the name of your number {0} child?",i+1);
                childName[i] = Console.ReadLine();

                Console.WriteLine("What is {0}'s age?",childName[i]); // {0} is a place holder for i+1
                childAge[i] = Convert.ToDouble(Console.ReadLine());
            }

            for (int i = 0; i < numberOfChildren; i++)
            {
            Console.WriteLine("Your child named {0} is {1} years old",childName[i],childAge[i]);
            }

            int howManyElements = childName.Length;
            int sumOfAges = 0;

            for (int i = 0; i < howManyElements; i++)
            {
                //sumOfAges = sumOfAges + Convert.ToInt32(childAge[i]);
                sumOfAges += Convert.ToInt32(childAge[i]);

            }
        
            averageAge = sumOfAges/howManyElements; 
            Console.WriteLine("The average age of your children is {0} years old",averageAge);
            


            double myOldestAge = 0;
            string myOldestName = "";
            string kidOrKids = "child is";
            for (int i = 0; i < howManyElements; i++)
            {
                if (childAge[i] >= myOldestAge)
                {
                    if(childAge[i] == myOldestAge)
                    {
                        myOldestName += ", " + childName[i]; 
                        kidOrKids = "children are";
                    }
                    else
                    {
                        myOldestName = childName[i];
                        kidOrKids = "child is";
                    }
                    
                    myOldestAge = childAge[i];
                    
                }
            }
            Console.WriteLine("The oldest age is {0}",myOldestAge);
            Console.WriteLine("The oldest {1} named {0}",myOldestName,kidOrKids);

            double easyAverageAge = childAge.Average();
            double easyMaxAge = childAge.Max();
            double easySumAge = childAge.Sum();
            double easyMinAge = childAge.Min();
            int indexOfMaxAge = Array.IndexOf(childAge,easyMaxAge);
            string easyOldestChildName = childName[indexOfMaxAge];

        }
    }
}
