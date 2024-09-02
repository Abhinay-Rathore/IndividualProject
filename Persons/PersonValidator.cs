using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/******************************************************************************
 * Filename    = PersonValidator.cs
 *
 * Product     = SoftwareDesignPatterns
 * 
 * Project     = SingleResponsibilityPrinciple
 *
 *****************************************************************************/

using Messages;

namespace Persons
{
    public class PersonValidator
    {
        // Method to validate a Person object
        public static bool Validate(Person person)
        {
            // Checks to be sure the first and last names are valid
            if (string.IsNullOrEmpty(person.FirstName))
            {
                // Display a validation error message for the first name
                StandardMessages.DisplayValidationError("first name");

                return false; // Return false indicating the validation failed
            }

            if (string.IsNullOrEmpty(person.LastName))
            {
                // Display a validation error message for the last name
                StandardMessages.DisplayValidationError("last name");
                //StandardMessages.EndApplication(); -----> Passing the responsability to the Main,
                //now PersonValidator doesn`t need to know where we are at the application

                return false;
            }

            return true;
        }
    }
}
