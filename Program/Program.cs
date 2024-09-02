/******************************************************************************
 * Filename    = Program.cs
 *
 * Product     = SoftwareDesignPatterns
 * 
 * Project     = SingleResponsibilityPrinciple
 *
 *****************************************************************************/

using System;
using Messages;
using Persons;
using Accounts;

namespace Program
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Display a welcome message to the user
            StandardMessages.WelcomeMessage();

            // Capture user information and create a Person object
            Person user = PersonDataCapture.Capture();

            // Validate the captured user information
            bool isUserValid = PersonValidator.Validate(user);

            // If user information is invalid, display an error message and end the application
            if (isUserValid == false)
            {
                StandardMessages.EndApplication();
                return;
            }

            // If user information is valid, create an account for the user
            AccountGenerator.CreateAccount(user);

            // Prompt the user to press enter to end the application
            StandardMessages.EndApplication();
        }
    }
}
