/******************************************************************************
 * Filename    = PersonDataCapture.cs
 *
 * Product     = SoftwareDesignPatterns
 * 
 * Project     = SingleResponsibilityPrinciple
 *
 *****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Persons
{
    public class PersonDataCapture
    {
       // Method to capture user input and create a Person object
        public static Person Capture()
        {
            // Create a new Person object to store user input
            Person output = new Person();

            // Ask for user information
            Console.Write("What is your first name? ");
            output.FirstName = Console.ReadLine();

            Console.Write("What is your last name? ");
            output.LastName = Console.ReadLine();

            return output;
        }
    }
}
