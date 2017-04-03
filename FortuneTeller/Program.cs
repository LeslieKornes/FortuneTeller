using System;

namespace FortuneTeller
{
    public class Program
    {
        static void Main(string[] args)
        {

            //declare all variables.
            string userFirstName;
            string userLastName;
            int userAge;
            int userBirthMonth;
            string yearsUntilRetirement = "";
            string userFaveColor;
            int userSiblings;
            string vacationHome = "";
            string rideType = "";

            //Prompt user for first name.
            Console.WriteLine("Want a peek into the future? Please tell me your first name and we'll get this fortune ball rolling!");
            userFirstName = Console.ReadLine();

            //Prompt user for last name.
            Console.WriteLine("And I'll need your last name...");
            userLastName = Console.ReadLine();

            //Prompt user for age.
            Console.WriteLine("How many birthdays have you celebrated?");
            userAge = int.Parse(Console.ReadLine());
            yearsUntilRetirement = AgeToRetirement(userAge);  //tossed relational fortune calculation into a method

            //Prompt user for birth month.
            Console.WriteLine("What number month were you born in?");
            userBirthMonth = int.Parse(Console.ReadLine());
            int bankAccount = BirthMonthToBankAccount(userBirthMonth);     //fortune calculation in method below

            //Prompt user for favorite ROYGBIV color.
            Console.WriteLine("What is your favorite color in the rainbow? If you're not sure what colors are in the rainbow, type \"help\"");
            userFaveColor = Console.ReadLine();

            //Creating a string array for ROYGBIV colors
            string[] colors = { "Red", "Orange", "Yellow", "Green", "Blue", "Indigo", "Violet" };

            if (userFaveColor.ToLower() == "help")
            {
                Console.WriteLine("You can choose from:");
                foreach (string color in colors)
                {
                    Console.WriteLine(color);
                }
                Console.WriteLine("\nSo what is your favorite color?");
                userFaveColor = Console.ReadLine();
            }
            rideType = ColorToVehicle(userFaveColor); //method below

            //Ask user how many siblings they have.
            Console.WriteLine("Lastly, how many siblings do you have?");
            userSiblings = int.Parse(Console.ReadLine());
            vacationHome = SiblingsToVacation(userSiblings);

            //Print user's fortune accordingly.
            Console.WriteLine($"{userFirstName} {userLastName} will retire in {yearsUntilRetirement} with {bankAccount:C} in the bank, a vacation home in {vacationHome} and will drive a {rideType}!");
        }

        public static string SiblingsToVacation(int userSiblings)
        {
            //Prompt user for number of siblings and depending on answer, determine where their vacation home will be.
            string vacationDigs = "";
            if (userSiblings == 0)
                vacationDigs = "Paris, France";

            else if (userSiblings == 1)
                vacationDigs = "Amsterdam";

            else if (userSiblings == 2)
                vacationDigs = "Geneva, Ohio";

            else if (userSiblings == 3)
                vacationDigs = "Los Angeles, California";

            else if (userSiblings >= 4)
                vacationDigs = "Capena, Italy";

            else
                vacationDigs = "Idaho";

            return vacationDigs;
        }

        public static int BirthMonthToBankAccount(int userBirthMonth)
        {
            //Determine what block user's birth month falls into
            int balance;

            if (userBirthMonth >= 1 && userBirthMonth <= 4)
                balance = 254;

            else if (userBirthMonth >= 5 && userBirthMonth <= 8)
                balance = 1000;
            
            else if (userBirthMonth >= 9 && userBirthMonth <= 12)
                balance = 50000;

            else
                balance = 0;

            return balance;
        }

        public static string ColorToVehicle(string userFaveColor)
        {
            //Assign users mode of transportation based on favorite color choice. 
            string transportationMode = "";

            switch (userFaveColor.ToLower())
            {
                case "red":
                    transportationMode = "Jeep";
                    break;

                case "orange":
                    transportationMode = "Subaru Outback";
                    break;

                case "yellow":
                    transportationMode = "Ford Mustang";
                    break;

                case "green":
                    transportationMode = "bicycle";
                    break;

                case "blue":
                    transportationMode = "moped";
                    break;

                case "indigo":
                    transportationMode = "skateboard";
                    break;

                case "violet":
                    transportationMode = "Ford Focus";
                    break;
            }
            return transportationMode;
        }

        public static string AgeToRetirement(int userAge)
        {
            //establish if user age odd or even.
            string workingYears = userAge % 2 == 0 ? "45 long years " : "just 10 years ";
            return workingYears;
        }
    }
}
