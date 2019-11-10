using System;
//using System.Diagnostics;
using System.IO;

namespace switcharoo
{
    class Program
    {
        static void Main(string[] args)
        {
            string favColor;

            Console.WriteLine("Enter your favorite color");
            favColor = Console.ReadLine();
            favColor = favColor.ToLower();


            switch (favColor)
            {
                case "red":
                    Console.WriteLine("You are either angry or love fast sports cars");
                    break;
                case "orange":
                    Console.WriteLine("You must like citrus things");
                    break;
                case "yellow":
                    Console.WriteLine("You like sunshine");
                    break;
                case "green":
                    Console.WriteLine("Are you Irish or redheaded?");
                    break;
                case "blue":
                    Console.WriteLine("I'm blue abee dee abeedab");
                    break;
                case "indigo":
                    Console.WriteLine("You must be sophisticated");
                    break;
                case "violet":
                    Console.WriteLine("Violet, you are turning violet");
                    break;
                default:
                    //Process.Start("nano");
                    StreamWriter myWriter = new StreamWriter("myfile.txt");
                    myWriter.WriteLine("Hey this is a test");
                    myWriter.Dispose();

                    StreamWriter myWriterTwo = System.IO.File.AppendText("myfile.txt");
                    myWriterTwo.WriteLine("yes it is");
                    myWriterTwo.Dispose();
                    string[] lines = System.IO.File.ReadAllLines("myfile.txt");
                    foreach(string line in lines){
                        Console.WriteLine(line);
                    }
                    System.IO.File.Create("tempfile.txt");
                    if (System.IO.File.Exists("tempfile.txt")){
                        Console.WriteLine("the file exists");
                        System.IO.File.Delete("tempfile.txt");
                        if(!System.IO.File.Exists("tempfile.txt")){
                            Console.WriteLine("File deleted");
                        }
                    }
                    
                    break;

            }

        }
    }
}
