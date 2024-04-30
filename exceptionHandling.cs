using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5 };

        try
        {
            // Trying to access an index that is out of range
            int value = numbers[10]; // IndexOutOfRangeException will occur here
        }
        catch (IndexOutOfRangeException ex)
        {
            // Handling the exception
            Console.WriteLine("IndexOutOfRangeException caught: " + ex.Message);
        }
    }
}

using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Attempting to divide by zero
            int result = 10 / 0; // DivideByZeroException will occur here
        }
        catch (DivideByZeroException ex)
        {
            // Handling the exception
            Console.WriteLine("DivideByZeroException caught: " + ex.Message);
        }
    }
}

using System;

class Program
{
    static void Main(string[] args)
    {
        string text = null;

        try
        {
            // Passing a null argument to a method that does not accept null
            PrintText(text); // ArgumentNullException will occur here
        }
        catch (ArgumentNullException ex)
        {
            // Handling the exception
            Console.WriteLine("ArgumentNullException caught: " + ex.Message);
        }
    }

    Console.WriteLine(text);
    }

