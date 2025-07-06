namespace lab_1;

using System;

class Program
{
    static void Main(string[] args)
    {
        // Step 1: Use Comments
        /*
            Dmytro Fedkiv
            IT-1050 - Lab 1
        */

        // Step 2: Basic Output
        Console.WriteLine(
            $"""
            Dmytro Fedkiv
            IT-1050 - Lab 1
            """
        );

        // Step 3: Declare and Use Variables
        int favoriteNumber = 2;
        string favoriteProgrammingLanguage = "Haskell";
        double numberOfWrittenPrograms = 27.5;
        bool hasProgrammingExperience = true;

        Console.WriteLine(
            $"""
            My favorite number is {favoriteNumber}
            My favorite programming language is {favoriteProgrammingLanguage}
            The number of programs I've written before this: {numberOfWrittenPrograms}
            Do I have programming experience: {(hasProgrammingExperience ? "Yes" : "No")}
            """
        );

        // Step 4: Use Constants
        const string schoolName = "Law Lyceum №2 Secondary School";

        Console.WriteLine($"My school is ${schoolName}");

        // Step 5: Type Casting
        double doubleValue = 9.78;
        int integerValue = (int)doubleValue;
        string convertedIntegerToStringValue = Convert.ToString(integerValue);
        string convertedBooleanToStringValue = Convert.ToString(false);

        Console.WriteLine(
            $"""
            Double value: {doubleValue}
            Integer value: {integerValue}
            Converted integer value: {convertedIntegerToStringValue}
            Converted boolean value: {convertedBooleanToStringValue}
            """
        );

        // Step 6: User Input and Type Conversion
        Console.Write("Enter your name: ");
        string username = Console.ReadLine();

        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Welcome, {username}. Your age is recorded as {age}");

        // Step 7: Arithmetic Operators
        int num1 = 5;
        int num2 = 8;

        Console.WriteLine(
            $"""
            Addition ({num1} + 10): {num1 + 10}"
            Subtraction ({num2} - 2): {num2 - 2}
            Multiplication ({num1} * 3): {num1 * 3}
            Division ({num2} / 2): {num2 / 2}
            Modulus ({num1} % 2): {num1 % 2}
            """
        );

        // Step 8: Floating Point Precision
        decimal originalValue = 1.123456789m;
        float convertedFloatValue = (float)originalValue;
        double convertedDoubleValue = (double)originalValue;

        Console.WriteLine(
            $"""
            Original value: {originalValue}
            Float value: {convertedFloatValue} <- rounds off after 7 digits
            Double value: {convertedDoubleValue} <- retains full precision
            """
        );

        // Step 9: Increment and Decrement
        int counter = 10;
        Console.WriteLine(
            $"""
            Initial state: {counter}
            After increment: {++counter}
            After decrement: {--counter}
            """
        );
    } 
}
