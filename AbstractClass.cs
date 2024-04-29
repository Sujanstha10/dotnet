// Abstract class
using System;


abstract class Animal {
    // Abstract method
    public abstract void MakeSound();
}

// Concrete subclass
class Dog : Animal {
    // Implementation of abstract method
    public override void MakeSound() {
        Console.WriteLine("Woof!");
    }
}

class Program {
    static void Main(string[] args) {
        // Creating an instance of Dog
        Dog dog = new Dog();

        // Calling the MakeSound method
        dog.MakeSound(); // Output: Woof!
    }
}
