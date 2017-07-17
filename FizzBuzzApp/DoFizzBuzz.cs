using System;
using System.Collections.Generic;

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
                        Console.WriteLine("Empty Input is Invalid.Please enter a valid number: ");
                    }
                    else if (strInput == "0")
                    {
                        Console.WriteLine("Zero Input is Invalid. Please enter a valid number :");
                    }
                    else
                    {
                        Console.WriteLine("Entered Input {0} is Invalid. Please enter a valid number :",strInput);
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
                    Console.WriteLine("Please enter a valid non-zero number to start the FizzBuzz :");
                    double input = ValidateInput(Console.ReadLine());

                    Console.WriteLine("FizzBuzz Completed with the Result --> " + GetFizzBuzzValue(input));
                    Console.WriteLine("Do you want to continue. Enter Y or N ");
                    strContinue = Console.ReadLine();

                    //This will execute only when the input is neither "Y" or "N"
                    while (strContinue.ToUpper() != "Y" && strContinue.ToUpper() != "N")
                    {
                        Console.WriteLine("Please enter either Y or N : ");
                        strContinue = Console.ReadLine();
                    }
                    Console.WriteLine("-------------------------------------");
                } while (strContinue.ToUpper() == "Y");
                Console.WriteLine("Thank you for using FizzBizz App..");
            }
            catch (Exception ex)
            {
                Console.WriteLine("FizzBuzz failed due to an exception : {0}", ex.Message);
            }
        }

        /// <summary>
        /// This Method will Get the Fizz or Buzz value for the validated input
        /// </summary>
        /// <param name="input"></param>
        /// <returns>string</returns>
        public static string GetFizzBuzzValue(double input)
        {
            int fizzInput = 3;
            int BuzzInput = 5;
            Dictionary<int, string> Dict = new Dictionary<int, string>();

            Dict.Add(fizzInput, "Fizz");
            Dict.Add(BuzzInput, "Buzz");
            try
            {
                if (input % fizzInput == 0 && input % BuzzInput == 0)
                {
                    return Dict[fizzInput] + Dict[BuzzInput];
                }
                else if (input % fizzInput == 0)
                {
                    return Dict[fizzInput];
                }
                else if (input % BuzzInput == 0)
                {
                    return Dict[BuzzInput];
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
