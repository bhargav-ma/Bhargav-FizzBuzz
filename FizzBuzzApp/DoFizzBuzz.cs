using System;
using System.Configuration;

namespace FizzBuzzApp
{
    public class DoFizzBuzz
    {

        /// <summary>
        /// Method to validate the Input
        /// </summary>
        /// <param name="strInput"></param>
        /// <returns>double</returns>
        public static double ValidateInput(string strInput)
        {
            double number;
            try
            {
                while (!double.TryParse(strInput, out number) || (strInput == "0"))
                {
                    if (string.IsNullOrEmpty(strInput))
                    {
                        Console.WriteLine(ConfigurationManager.AppSettings["strEmpty"]);
                    }
                    else if (strInput == "0")
                    {
                        Console.WriteLine(ConfigurationManager.AppSettings["strZero"]);
                    }
                    else
                    {
                        Console.WriteLine(ConfigurationManager.AppSettings["strInvalid"], strInput);
                    }
                    strInput = Console.ReadLine();
                }
                return number;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// This Method will show the Output
        /// </summary>
        public void RunFizzBuzz()
        {
            try
            {
                string strContinue = string.Empty;
                do
                {
                    Console.WriteLine(ConfigurationManager.AppSettings["strInput"]);
                    double input = ValidateInput(Console.ReadLine());

                    Console.WriteLine("FizzBuzz Completed with the Result --> " + GetFizzBuzzValue(input));
                    Console.WriteLine("Do you want to continue. Enter Y or N ");
                    strContinue = Console.ReadLine();
                    Console.WriteLine("Thank you for using FizzBizz..");
                    Console.WriteLine();
                } while (strContinue.ToUpper() == "Y");
            }
            catch (Exception ex)
            {
                Console.WriteLine("FizzBuzz failed due to an exception : {0}", ex.Message);
            }
        }

        /// <summary>
        /// This Method will Get the Fizz or Buzz value for the input
        /// </summary>
        /// <param name="input"></param>
        /// <returns>string</returns>
        public static string GetFizzBuzzValue(double input)
        {
            try
            {
                int fizzValue = Convert.ToInt32(ConfigurationManager.AppSettings["fizzInput"]);
                int BuzzValue = Convert.ToInt32(ConfigurationManager.AppSettings["BuzzInput"]);

                if (input % fizzValue == 0 && input % BuzzValue == 0)
                {
                    return ConfigurationManager.AppSettings["fizzValue"] + ConfigurationManager.AppSettings["BuzzValue"];
                }
                else if (input % fizzValue == 0)
                {
                    return ConfigurationManager.AppSettings["fizzValue"];
                }
                else if (input % BuzzValue == 0)
                {
                    return ConfigurationManager.AppSettings["BuzzValue"];
                }
                else
                    return input.ToString();
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
