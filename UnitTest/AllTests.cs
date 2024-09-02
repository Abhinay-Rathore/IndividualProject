/******************************************************************************
 * Filename    = AllTests.cs
 *
 * Product     = SoftwareDesignPatterns
 * 
 * Project     = SingleResponsibilityPrinciple
 *
 *****************************************************************************/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Accounts;
using Persons;
using Messages;

namespace UnitTests
{
    [TestClass]
    public class AllTests
    {
        // Tests for PersonValidator

        [TestMethod]
        public void ValidateValidPersonReturnsTrue()
        {
            // Arrange: Create a valid Person object
            Person person = new Person
            {
                FirstName = "Abhinay",
                LastName = "Rathore"
            };

            // Act: Validate the Person object
            bool result = PersonValidator.Validate(person);

            // Assert: Check if the validation result is true
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ValidateMissingFirstNameReturnsFalse()
        {
            // Arrange: Create a Person object with a missing first name
            Person person = new Person
            {
                FirstName = null,
                LastName = "Rathore"
            };

            // Act: Validate the Person object
            bool result = PersonValidator.Validate(person);

            // Assert: Check if the validation result is false
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidateMissingLastNameReturnsFalse()
        {
            // Arrange: Create a Person object with a missing last name
            Person person = new Person
            {
                FirstName = "Abhinay",
                LastName = null
            };

            // Act: Validate the Person object
            bool result = PersonValidator.Validate(person);

            // Assert: Check if the validation result is false
            Assert.IsFalse(result);
        }

        // Tests for AccountGenerator

        [TestMethod]
        public void CreateAccountValidPersonDisplaysCorrectUsername()
        {
            // Arrange: Create a valid Person object
            Person person = new Person
            {
                FirstName = "Abhinay",
                LastName = "Rathore"
            };

            // Capture Console output
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act: Generate an account for the Person object
                AccountGenerator.CreateAccount(person);

                // Assert: Check if the output matches the expected username format
                string expected = $"Your username is A{person.LastName}" + Environment.NewLine;
                Assert.AreEqual(expected, sw.ToString());
            }
        }

        [TestMethod]
        public void CreateAccountNullFirstNameDisplaysCorrectUsername()
        {
            // Arrange: Create a Person object with a null first name
            Person person = new Person
            {
                FirstName = null,
                LastName = "Rathore"
            };

            // Capture Console output
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act: Generate an account for the Person object
                AccountGenerator.CreateAccount(person);

                // Assert: Check if the output matches the expected username format
                string expected = $"Your username is {person.LastName}" + Environment.NewLine;
                Assert.AreEqual(expected, sw.ToString());
            }
        }

        // Tests for StandardMessages

        [TestMethod]
        public void WelcomeMessageDisplaysCorrectMessage()
        {
            // Arrange: Capture Console output
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act: Display the welcome message
                StandardMessages.WelcomeMessage();

                // Assert: Check if the output matches the expected message
                string expected = "Welcome to my application" + Environment.NewLine;
                Assert.AreEqual(expected, sw.ToString());
            }
        }

        [TestMethod]
        public void EndApplicationDisplaysCorrectMessage()
        {
            // Arrange: Capture Console output
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act: Display the end application message
                using (StringReader sr = new StringReader(string.Empty))
                {
                    Console.SetIn(sr);
                    StandardMessages.EndApplication();
                }

                // Assert: Check if the output matches the expected message
                string expected = "Press enter to end the application..." + Environment.NewLine;
                Assert.AreEqual(expected, sw.ToString());
            }
        }

        [TestMethod]
        public void DisplayValidationErrorDisplaysCorrectMessage()
        {
            // Arrange: Define the field name for the error message
            string fieldName = "first name";

            // Capture Console output
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act: Display the validation error message
                StandardMessages.DisplayValidationError(fieldName);

                // Assert: Check if the output matches the expected error message
                string expected = $"You did not give us a valid {fieldName}!" + Environment.NewLine;
                Assert.AreEqual(expected, sw.ToString());
            }
        }

        // Tests for PersonDataCapture

        [TestMethod]
        public void CaptureReturnsCorrectPerson()
        {
            // Arrange: Provide input for capturing Person data
            using (StringReader sr = new StringReader("Abhinay\nRathore\n"))
            {
                Console.SetIn(sr);

                // Act: Capture the Person data
                Person result = PersonDataCapture.Capture();

                // Assert: Check if the captured Person matches the expected values
                Assert.AreEqual("Abhinay", result.FirstName);
                Assert.AreEqual("Rathore", result.LastName);
            }
        }
    }
}
