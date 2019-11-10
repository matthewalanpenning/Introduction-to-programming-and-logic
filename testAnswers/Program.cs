using System;

namespace testAnswers
{
    class Program
    {
        static void Main(string[] args)
        {
            
string userResponse;
           
            Console.WriteLine("Hola, Write three things you love about fall:");
            userResponse = Console.ReadLine(); 
            Console.WriteLine(userResponse.Length);

            int spaces1 = 0;

            for ( int i= 0; i< userResponse.Length; i++)
            { 
                if (userResponse[i] == ' ')
                {
                    spaces1++;
                }   
                                   
            }
            Console.WriteLine(userResponse[3]);
               
            Console.WriteLine(spaces1);

        }
    }
}
