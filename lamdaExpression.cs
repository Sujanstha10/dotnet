using System;

class Program {
    static void Main(string[] args) {
        // Lambda expression to square a number
        Func<int, int> square = x => x * x;

        // Using the lambda expression
        int result = square(5);
        Console.WriteLine("Square of 5: " + result); // Output: Square of 5: 25
    }
}
