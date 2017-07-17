using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("**********************************************************");
                Console.WriteLine("------------------------- FizzBuzz------------------------");
                Console.WriteLine("**********************************************************");

                DoFizzBuzz fizzBuzz = new DoFizzBuzz();
                fizzBuzz.RunFizzBuzz();
            }
            catch (Exception ex)
            {
                Console.WriteLine("FizzBuzz failed due to exception : {0}", ex.Message);
            }
        }
    }
}
