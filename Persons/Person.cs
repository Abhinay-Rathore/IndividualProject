/******************************************************************************
 * Filename    = Person.cs
 *
 * Product     = SoftwareDesignPatterns
 * 
 * Project     = SingleResponsibilityPrinciple
 *
 *****************************************************************************/

namespace Persons
{
    public class Person
    {
        // The '?' indicates that this property is nullable
        public string? FirstName { get; set; } // Property to get or set the person's first name
        public string? LastName { get; set; } // Property to get or set the person's last name
    }
}
