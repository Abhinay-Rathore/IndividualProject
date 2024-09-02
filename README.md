# Simple C# Console Application with Unit Tests

## Overview
This project is a simple C# console application designed to demonstrate the Single Responsibility Principle (SRP), one of the key SOLID principles in object-oriented programming. The application is structured in a way that each class has a single responsibility, making the code more modular, maintainable, and easier to understand.

## Project Structure
The project is organized into the following namespaces and classes, each adhering to the Single Responsibility Principle:

### Accounts
> AccountGenerator.cs: Responsible for generating a username based on a user's first and last name. This class has no other responsibilities, ensuring that the logic related to account generation is encapsulated here.

### Messages
> StandardMessages.cs: Handles all console messaging for the application. It provides methods to display a welcome message, an application end prompt, and validation error messages. By isolating messaging responsibilities, the code remains clear and focused.

### Persons
> Person.cs: Represents a person with properties for FirstName and LastName. The Person class is solely responsible for holding data about a person.

> PersonValidator.cs: Validates the Person object to ensure that both FirstName and LastName are provided. This class is dedicated to the validation logic, adhering to SRP by not handling any other logic, like data capturing or messaging.

> PersonDataCapture.cs: Handles user input for capturing a person's first and last names. It focuses solely on data input, without any responsibility for validation or processing that data.

### Program
> Program.cs: Serves as the entry point of the application, orchestrating the flow by using the other classes. It follows SRP by not implementing the logic of account creation, validation, or messaging itself, but rather delegating these tasks to the appropriate classes.

### UnitTests
> AllTests.cs: Contains unit tests for PersonValidator, AccountGenerator, StandardMessages, and PersonDataCapture classes using MSTest. The test cases ensure that each class fulfills its single responsibility correctly.

## Single Responsibility Principle (SRP)
The Single Responsibility Principle states that a class should have only one reason to change, meaning it should only have one job or responsibility. This principle is evident throughout the project:
> Separation of Concerns: Each class in the project has a well-defined role, ensuring that changes in one part of the application do not affect others unnecessarily.
> Modularity: The code is modular, with each class focused on a specific aspect of the application, making it easier to understand, test, and maintain.
> Scalability: Adhering to SRP makes the codebase more scalable, as adding new features or modifying existing ones can be done by extending the relevant class without touching unrelated parts of the code.