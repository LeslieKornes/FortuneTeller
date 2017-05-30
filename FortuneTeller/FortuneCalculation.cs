namespace FortuneTeller
{
    public class FortuneCalculation
    {
        public static string AgeToRetirement(int userAge)
        {
            string workingYears = userAge % 2 == 0 ? "45 long years " : "just 10 years ";
            return workingYears;
        }
        public static int BirthMonthToBankAccount(int userBirthMonth)
        {
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
        public static string NumberOfSiblingsToVacationHomeLocation(int userSiblings)
        {
            string vacationDigs;
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
    }
    
}
