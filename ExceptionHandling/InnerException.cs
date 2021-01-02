using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExceptionHandling
{
    public class InnerException
    {
        public static void Divide()
        {
            try
            {
                try
                {
                    Console.WriteLine("Enter First No");
                    int FN = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Second No");
                    int SN = Convert.ToInt32(Console.ReadLine());

                    int result = FN / SN;

                    Console.WriteLine("Result is {0}", result);
                }
                catch (Exception ex)
                {
                    string LogPath = @"C:\Users\Ankit\Source\Repos\NewRepo\cSharpTutorials\Logs1.txt";
                    if (File.Exists(LogPath))
                    {
                        StreamWriter sw = new StreamWriter(LogPath);
                        sw.Write(ex.GetType().Name);
                        sw.Write("\n" + ex.StackTrace);
                        sw.Close();
                        Console.WriteLine(ex.GetType().Name);
                    }
                    else
                    {
                        throw new FileNotFoundException(LogPath + " not found", ex);
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.InnerException);
            }
        }
    }
}
