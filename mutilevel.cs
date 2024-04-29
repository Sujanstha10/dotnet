//mutilevel
using System;

class A {
    public void MethodA() {
        Console.WriteLine("MethodA from class A");
    }
}

class B : A {
    public void MethodB() {
        Console.WriteLine("MethodB from class B");
    }
}

class C : B {
    public void MethodC() {
        Console.WriteLine("MethodC from class C");
    }
}

class Program {
    static void Main(string[] args) {
        C obj = new C();
        obj.MethodA(); // Output: MethodA from class A
        obj.MethodB(); // Output: MethodB from class B
        obj.MethodC(); // Output: MethodC from class C
    }
}
