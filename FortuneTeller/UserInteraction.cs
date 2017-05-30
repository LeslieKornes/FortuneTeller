using System;
namespace FortuneTeller
{
    static class UserInteraction
    {
        public static string PromptUserForFirstName()
        {
            Console.WriteLine("Want a peek into the future? Please tell me your first name and we'll get this fortune ball rolling!");
            return Console.ReadLine();
        }
        public static string PromptUserForLastName()
        {
            Console.WriteLine("And I'll need your last name...");
            return Console.ReadLine();
        }
        public static int PromptUserForAge()
        {
            Console.WriteLine("How many birthdays have you celebrated?");
            return int.Parse(Console.ReadLine());
        }
        public static int PromptUserForBirthMonth()
        {
            Console.WriteLine("What number month were you born in?");
            return int.Parse(Console.ReadLine());
        }
        public static string PromptUserForFavoriteColor()
        {
            string[] colors = { "Red", "Orange", "Yellow", "Green", "Blue", "Indigo", "Violet" };
            Console.WriteLine("What is your favorite color in the rainbow? If you're not sure what colors are in the rainbow, type \"help\"");
            if (Console.ReadLine().ToLower() == "help")
            {
                Console.WriteLine("You can choose from:");
                foreach (string color in colors)
                {
                    Console.WriteLine(color);
                }
                Console.WriteLine("\nSo what is your favorite color?");
            }
            return Console.ReadLine();
        }
        public static int PromptUserForNumberOfSiblings()
        {
            Console.WriteLine("Lastly, how many siblings do you have?");
            return int.Parse(Console.ReadLine());
        }
    }
}
