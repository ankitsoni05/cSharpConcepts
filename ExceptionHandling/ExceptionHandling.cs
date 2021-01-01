using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExceptionHandling
{
    /// <summary>
    /// we must put that line in try block which we think can throw exception.
    /// A try block may have multiple catch blocks.
    /// A sequence of catch must follow most specific to generic fashion see example below.
    /// Finally block will always be executed independently of exception thrown or not.
    /// It is good practice to release resources in finally block.
    /// </summary>
    public class ExceptionHandling
    {
        public static void printFileContents()
        {
            StreamReader reader = null;
            try
            {
                reader = new StreamReader(@"C:\Users\Ankit\Source\Repos\cSharpTutorials\Data.txt");
                string fileContents;
                fileContents = reader.ReadToEnd();
                Console.WriteLine(fileContents);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("File with name {0} not found ",ex.FileName);
                Console.WriteLine("\n");
                Console.WriteLine("Inside file not found exception");
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("inside directory not found exception");
                Console.WriteLine("\n");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //Console.WriteLine(ex.StackTrace);
                //Console.WriteLine(ex.Message);
            }
            finally //Finally block will be executed irrespective of exception is thrown or not.
            {
                if (reader != null)
                    reader.Close();
                Console.WriteLine("Finally block executed");
            }
        }
    }
}
