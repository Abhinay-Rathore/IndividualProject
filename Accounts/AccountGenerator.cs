/******************************************************************************
 * Filename    = AccountGenerator.cs
 *
 * Product     = SoftwareDesignPatterns
 * 
 * Project     = SingleResponsibilityPrinciple
 *
 *****************************************************************************/

using System;
using Persons;

namespace Accounts
{
    public class AccountGenerator
    {
        public static void CreateAccount(Person user)
        {
            // Create a username for the person using their first name and last name
            Console.WriteLine($"Your username is {user.FirstName?.Substring(0, 1)}{user.LastName}");

        }
    }
}
