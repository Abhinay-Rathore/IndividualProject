/******************************************************************************
 * Filename    = StandardMessages.cs
 *
 * Product     = SoftwareDesignPatterns
 * 
 * Project     = SingleResponsibilityPrinciple
 *
 *****************************************************************************/

namespace Messages
{
    public class StandardMessages
    {
        // Method to display a welcome message
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to my application");
        }

        // Method to prompt the user to end the application
        public static void EndApplication()
        {
            Console.WriteLine("Press enter to end the application...");
            Console.ReadLine(); // Waits for user input before continuing
        }

        // Method to display a validation error message
        // Takes a fieldName parameter to specify which field is invalid
        public static void DisplayValidationError(string fieldName)
        {
            Console.WriteLine($"You did not give us a valid {fieldName}!");
        }
    }
}
