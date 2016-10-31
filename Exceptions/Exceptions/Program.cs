using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Divide(4, 0));

            Console.ReadLine();
        }

        static double Divide(int x, int y)
        {
            double returnVal = 0.0;

            try
            {
                try
                {
                    returnVal = x / y;
                    Console.WriteLine("Made it here!!!!!");
                }
                catch (DivideByZeroException ex1)
                {
                    Console.WriteLine(ex1.Message);
                    throw new Exception("Hey it's broken", ex1);
                }
                catch (ArithmeticException)
                {
                    Console.WriteLine("Some sort of math problem");

                }
                catch (SystemException)
                {
                    Console.WriteLine("Ack! System Problem");
                }
                catch (Exception)
                {
                    Console.WriteLine("Ack!");
                }
            }
            catch(Exception ex2)
            {
                Console.WriteLine("This exception message {0}", ex2.Message);
                Console.WriteLine("this is the inner ex message {0}",
                    ex2.InnerException.Message);
            }

            return returnVal;
        }
    }
}
