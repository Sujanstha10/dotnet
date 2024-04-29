//multiple inheritance
using System;

interface IFirst {
    void Method1();
}

interface ISecond {
    void Method2();
}

class MyClass : IFirst, ISecond {
    public void Method1() {
        Console.WriteLine("Method1 from IFirst");
    }

    public void Method2() {
        Console.WriteLine("Method2 from ISecond");
    }
}

class Program {
    static void Main(string[] args) {
        MyClass obj = new MyClass();
        obj.Method1(); // Output: Method1 from IFirst
        obj.Method2(); // Output: Method2 from ISecond
    }
}
