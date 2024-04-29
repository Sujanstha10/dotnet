
Lab 1 
Objective: Program to display "hello world" in c#

using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Hello World");
    }
}

Output: "Hello World"

Lab 2 
Objective:Types of variable 
    A variable in programming is a named storage location for data, declared with a specific data type, and can be initialized with a value.

using System;

class Program
{
    static void Main()
    {
        int population = 800000000;
        float pi = 3.14f;
        char grade = 'A';
        bool isStudent = true;
        string greeting = "Hello, World!";

        Console.WriteLine($"Population: {population}");
        Console.WriteLine($"Pi: {pi}");
        Console.WriteLine($"Grade: {grade}");
        Console.WriteLine($"Is Student: {isStudent}");
        Console.WriteLine($"Greeting: {greeting}");

        Console.ReadLine();
    }
}
Output:
Population: 800000000
Pi: 3.14
Grade: A
Is Student: True
Greeting: Hello, World!



Lab 3
Objective:Types of operators

using System;

class Program
{
    static void Main()
    {
        // Arithmetic Operators
        int a = 10;
        int b = 3;

        // Addition
        int sum = a + b; // 13
        Console.WriteLine($"Sum: {sum}");

        // Subtraction
        int difference = a - b; // 7
        Console.WriteLine($"Difference: {difference}");

        // Multiplication
        int product = a * b; // 30
        Console.WriteLine($"Product: {product}");

        // Division
        int quotient = a / b; // 3
        Console.WriteLine($"Quotient: {quotient}");

        // Modulus
        int remainder = a % b; // 1
        Console.WriteLine($"Remainder: {remainder}");

        // Relational Operators
        int x = 5;
        int y = 8;

        // Logical Operators
        bool condition1 = true;
        bool condition2 = false;

        // Logical AND
        bool resultAND = condition1 && condition2; // False
        Console.WriteLine($"Result AND: {resultAND}");

        // Logical OR
        bool resultOR = condition1 || condition2; // True
        Console.WriteLine($"Result OR: {resultOR}");

        // Logical NOT
        bool resultNOT = !condition1; // False
        Console.WriteLine($"Result NOT: {resultNOT}");

        // Assignment Operators
        int num = 10;

        // Add and assign
        num += 5; // num is now 15
        Console.WriteLine($"Num after addition: {num}");

        // Increment and Decrement Operators
        int counter = 5;

        // Increment by 1
        counter++; // counter is now 6
        Console.WriteLine($"Counter after increment: {counter}");

        // Conditional Operator (Ternary Operator)
        int number = 7;

        // Ternary operator: If number is even, result is "Even", otherwise "Odd"
        string result = (number % 2 == 0) ? "Even" : "Odd";
        Console.WriteLine($"Result: {result}");
    }
}

Output:
Sum: 13
Difference: 7
Product: 30
Quotient: 3
Remainder: 1
Result AND: False
Result OR: True
Result NOT: False
Num after addition: 15
Counter after increment: 6
Result: Odd


Lab 4
Objective: Conditional Statement
    Conditional statements in programming, such as if, else if, and else, control program flow based on conditions, enabling decision-making in code execution.

using System;
using System;

class Program
{
    static void Main()
    {
        // Example: Checking the value of a variable
        int number = 10;
        if (number > 0)
        {
            Console.WriteLine("The number is positive.");
        }
        else if (number < 0)
        {
            Console.WriteLine("The number is negative.");
        }
        else
        {
            Console.WriteLine("The number is zero.");
        }
        Console.ReadLine();
    }
}

Output: The number is positive.


Lab 5
Objective: Looping Statement
    Looping statements in programming allow you to repeatedly execute a block of code as long as a certain condition is true. 
    for,
    while,
    do-while,
    foreach
using System;
class Program
{
    static void Main()
    {
        // Using a for loop 
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine(i); //1,2,3,4,5
        }

        // Using a while loop 
        int j = 1;
        while (j <= 5)
        {
            Console.WriteLine(j); //1,2,3,4,5
            j++;
        }

        // Using a do-while loop
        int k = 1;
        do
        {
            Console.WriteLine(k); //1,2,3,4,5
            k++;
        } while (k <= 5);

        //Using a foreach loop
        int[] numbers = { 1, 2, 3, 4, 5 };
        foreach (var num in numbers)
        {
            Console.WriteLine(num);  //1,2,3,4,5
        }

        Console.ReadLine();
    }
}
Output: Using a for loop:
1
2
3
4
5


Using a while loop:
1
2
3
4
5

Using a do-while loop:
1
2
3
4
5

Using a foreach loop:
1
2
3
4
5


Lab 6 
Objective: Array and type of multidimensional array
    an array is a data structure that allows you to store a fixed-size sequential collection of elements of the same type.
    int[] array = { 1, 2, 3, 4, 5 };

Two types of multidimensional arrays: rectangular arrays and jagged arrays.

    Rectangular Array:
     array where each row has the same number of elements, and each column has the same number of elements. Rectangular arrays are declared using a comma-separated list of sizes within square brackets.


    Jagged Array:
        a jagged array allows each row to have a different length.

using System;

class Program
{
    static void Main()
    {
        // Rectangular Array
        int[,] rectangularArray = new int[3, 4]
        {
            {1, 2, 3, 4},
            {5, 6, 7, 8},
            {9, 10, 11, 12}
        };

        Console.WriteLine("Rectangular Array:");
        PrintArray(rectangularArray);

        // Jagged Array
        int[][] jaggedArray = new int[3][];
        jaggedArray[0] = new int[] { 1, 2, 3 };
        jaggedArray[1] = new int[] { 4, 5 };
        jaggedArray[2] = new int[] { 6, 7, 8, 9 };

        Console.WriteLine("\nJagged Array:");
        PrintArray(jaggedArray);

        int elementRectangular = rectangularArray[1, 2];
        int elementJagged = jaggedArray[1][0];          

        Console.ReadLine();
    }

    static void PrintArray(int[][] array)
    {
        foreach (var row in array)
        {
            foreach (var element in row)
            {
                Console.Write($"{element} ");
            }
            Console.WriteLine();
        }
    }
}
Output:
Rectangular Array:
1 2 3 4
5 6 7 8
9 10 11 12

Jagged Array:
1 2 3
4 5
6 7 8 9















