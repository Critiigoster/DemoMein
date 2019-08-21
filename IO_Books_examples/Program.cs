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
        
            
            //Here we are second version for Reading or Writing a file; Using StreamReader.ReadLine


            /* 
              // if we use using, there is no need for try-catch block 
              const Int32 BufferSize = 128;
            using (var fileStream = File.OpenRead(path)) // Open an excisting file // using helps us not ti close file at the end!
            using (var streamReader = new StreamReader(fileStream, System.Text.Encoding.Default, true, BufferSize)) // Increasing this(BufferSize) will in general increase performance
            {
                String line;
                while ((line = streamReader.ReadLine()) != null)
                    Console.WriteLine(line);
                
            }
             */

            //Instead of While
            /*
           foreach (string line in File.ReadLines("English.txt", System.Text.Encoding.Default)) // Also possible variant for Read-to-Write
        {
            Console.WriteLine(line);
        }
         */


        }




        //while ( (str = streamReader.ReadLine())!=null)
        //{
        //    Console.WriteLine(str);
        //}



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