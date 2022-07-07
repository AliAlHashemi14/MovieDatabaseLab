using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabaseLab
{
    internal class Validator
    {
        public static string GetUserResponse()
        {

            while (true)
            {
                Console.WriteLine("Please enter a movie category.\nDrama\nAnimated\nScifi\nHorror");
                string choice = Console.ReadLine().ToLower().Trim();

                if (choice.Equals("drama") || choice.Equals("animated") || choice.Equals("scifi") || choice.Equals("horror"))
                {
                    return choice;
 
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }
            }

 
        }

        public static bool GetContinue()
        {
            //default value
            bool result = true;
            //check if user wants to continue
            while (true)
            {
                Console.WriteLine("Would you like to continue? (y/n)");
                string choice = Console.ReadLine().ToLower().Trim();

                //Check user input
                if (choice == "y")
                {
                    result = true;
                    break;
                }
                else if (choice == "n")
                {
                    result = false;
                    break;
                }
                else
                {
                    Console.WriteLine("That was invalid. Try again.");
                }

            }
            return result;

        }
    }
}
