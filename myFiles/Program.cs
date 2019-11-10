using System;
using System.IO;

namespace myFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a name for a new file");
            string myFileName = Console.ReadLine();
            myFileName = myFileName + ".txt";
            //myFileName = "C:\\Users\\mpenning\\Desktop\\" + myFileName;

            //! means NOT...if the file does not exist
            if(!System.IO.File.Exists(myFileName))
            {
                //Create a stream to create the file on the harddrive
                FileStream myFileStream = System.IO.File.Create(myFileName);
                //Close out the stream
                myFileStream.Dispose();
            }
            else
            {
                Console.WriteLine("File already exists. Do you want to overwrite it? [y/N]");
                string answer = Console.ReadLine();
                if (answer == "y"){
                    FileStream myFileStream = System.IO.File.Create(myFileName);
                    myFileStream.Dispose();
                }
            }

            
           
            //Write to file with StreamWriter...this overwrites all previous contents
            //StreamWriter myFileWriter = new StreamWriter(myFileName);
            //myFileWriter.WriteLine("this should be inside my file 2");
            //myFileWriter.Dispose();

            Console.WriteLine("Enter in the text you want appended to the file:");
            string myAppendingText = Console.ReadLine();
            File.AppendAllText(myFileName, myAppendingText + "\n");


            Console.WriteLine("Do you want to view the contents of the file? [y/N]");
            string displayFile = Console.ReadLine();

            if (displayFile == "y")
            {
                //Option #1
                string allTheTextAtOnce = System.IO.File.ReadAllText(myFileName);
                Console.WriteLine(allTheTextAtOnce);

                //Option #2
                string[] allTheTextLineByLine = System.IO.File.ReadAllLines(myFileName);
                int lineLength = allTheTextLineByLine.Length;
                for (int i = 0; i < lineLength; i++)
                {
                    string line = allTheTextLineByLine[i];
                    if(line.Substring(0,3) == "Nov")
                    {
                        Console.WriteLine(allTheTextLineByLine[i]);
                    }
                }

            }
            Console.WriteLine("Enter in a url");
            string url = Console.ReadLine();
            Console.WriteLine("Which browser would you like to use: Chrome, Firefox, or Edge?");
            string browser = Console.ReadLine();

            switch(browser)
            {
                case "chrome":
                System.Diagnostics.Process.Start("C:\\Program Files(x86)\\Google\\Chrome\\Application\\chrome.exe",url);
                break;
                case "edge":
                System.Diagnostics.Process.Start(url);
                break;

            } 

            
        
        


        }
    }
}
