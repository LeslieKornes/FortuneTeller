using System;

namespace FortuneTeller
{
    class FortuneGame
    {
        public static void GetFortune(FortuneRecipient fortuneRecipient)
        {
            fortuneRecipient.FirstName = UserInteraction.PromptUserForFirstName();
            fortuneRecipient.LastName = UserInteraction.PromptUserForLastName();
            fortuneRecipient.Age = UserInteraction.PromptUserForAge();
            fortuneRecipient.BirthMonth = UserInteraction.PromptUserForBirthMonth();
            fortuneRecipient.FavoriteColor = UserInteraction.PromptUserForFavoriteColor();
            fortuneRecipient.NumberOfSiblings = UserInteraction.PromptUserForNumberOfSiblings();
            fortuneRecipient.YearsToRetirement = FortuneCalculation.AgeToRetirement(fortuneRecipient.Age);
            fortuneRecipient.BankAccount = FortuneCalculation.BirthMonthToBankAccount(fortuneRecipient.BirthMonth);
            fortuneRecipient.VehicleType = FortuneCalculation.ColorToVehicle(fortuneRecipient.FavoriteColor);
            fortuneRecipient.VacationHome = FortuneCalculation.NumberOfSiblingsToVacationHomeLocation(fortuneRecipient.NumberOfSiblings);
            Console.WriteLine($"{fortuneRecipient.FirstName} {fortuneRecipient.LastName} will retire in {fortuneRecipient.YearsToRetirement} " +
                             $"with {fortuneRecipient.BankAccount:C} in the bank, a vacation home in {fortuneRecipient.VacationHome} " +
                              $"and will drive a {fortuneRecipient.VehicleType}!");
        }
    }
}
