//Generics
using System;

class Generics {
    public static void Swap<T>(T a, T b) {
                T temp = a;
        a = b;
        b = temp;
        Console.WriteLine($"{a} {b}");
    }

    public static void Main(String[] args) {
        int x = 10, y = 20;
        Swap(x, y);

        string str1 = "hello", str2 = "world";
        Swap(str1, str2);
    }
}
