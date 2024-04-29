//method overridding
using System;

class Animal {
    public virtual void Sound() {
        Console.WriteLine("Animal makes a sound");
    }
}

class Dog : Animal {
    public override void Sound() {
        Console.WriteLine("Dog barks");
    }
}
class Program {
    static void Main(string[] args) {
        Animal animal = new Animal();
        animal.Sound();  // Output: Animal makes a sound

        Dog dog = new Dog();
        dog.Sound();     // Output: Dog barks
    }
}
