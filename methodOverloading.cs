//method OverloadingExample
using System;

class OverloadingExample {
    // Method with two integer parameters
    public void Add(int a, int b) {
        Console.WriteLine($"Sum of {a} and {b} is {a + b}");
    }

    // Method with three integer parameters
    public void Add(int a, int b, int c) {
        Console.WriteLine($"Sum of {a}, {b}, and {c} is {a + b + c}");
    }

    public static void Main(string[] args) {
        OverloadingExample example = new OverloadingExample();
        example.Add(2, 3);
        example.Add(2, 3, 4);
    }
}
