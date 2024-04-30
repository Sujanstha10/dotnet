using System;

class Program {
            // Lambda expression to square a number
    static int square(int x) => x*x;
    static void Main(string[] args) {
        // Using the lambda expression
        int result = square(5);
        Console.WriteLine("Square of 5: " + result); // Output: Square of 5: 25
    }
}
