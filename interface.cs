// Interface
using System;


interface IExample {
    void Display();
}

class MyClass : IExample {
    public void Display() {
        Console.WriteLine("Hello from MyClass!");
    }
}

class Program {
    static void Main(string[] args) {
        // Creating an instance of MyClass
        MyClass myObject = new MyClass();

        // Calling the Display method
        myObject.Display(); // Output: Hello from MyClass!
    }
}