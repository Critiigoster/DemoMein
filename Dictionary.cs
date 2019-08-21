using System;
using System.IO;

/*
 ЗАвадання: 
 Розробити файл зі словами англійськими
 Зчитати по полю
 */
class AvgNums
{
    static void Main()
    {
        //StreamReader streamReader = null; // Об'являємо покищо як null
        string path = "English.txt"; // Створюємо окрему стрінгову змінну для того, щоб потім передати шлях
        StreamReader streamReader = null;





        try
        {
            // That is gonna be first bersion of reading or writing file 
            var filestream = new System.IO.FileStream(path, // Now we're crating File's Stream for reading(access)
                                    System.IO.FileMode.Open,
                                    System.IO.FileAccess.Read,
                                     System.IO.FileShare.ReadWrite);
            //If you require special sharing options (for example you use FileShare.ReadWrite), you can use your own code but you should increase the buffer size.

            streamReader = new System.IO.StreamReader(filestream, System.Text.Encoding.Default); // Default more suitable for my DESK
            string str = null;
            Console.WriteLine("Which the word are you looking for? Put the word down here\nIf you want all words to be shown just write \"All\"" +
                    "\nIn order to stop write \"Stop\" ");
            for (; ;)
            {
                
            string Put = Console.ReadLine();

               
                if (Put == "Stop")
                {
                    Put = null;
                    str = null;
                    break;
                }
                
                    while ((str = streamReader.ReadLine()) != null)
                    {
                        if (str.Contains(Put)) // that's pretty obvious
                        {
                            Console.WriteLine(str); // output only word which we have inputed before
                            break;
                        }
                    
                    }
                
                


            }
           

                Console.WriteLine();
        
            
          


        }




        catch (IOException Excep)
        {

            Console.WriteLine("FileNotFoundException Occured");
            Console.WriteLine(Excep.Message);

        }
        catch (Exception Excep1)
        {
            Console.WriteLine("Other Exception Occured");
            Console.WriteLine(Excep1.Message);

        }
        finally
        {
            if (streamReader != null)
                streamReader.Close();

        }


    }
}