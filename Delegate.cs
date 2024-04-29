//Delegate
using System;
class program{
    public delegate void add(int n);
    public delegate void sub(int n);
    public int number = 10;
    
    public void sum(int n){
        Console.WriteLine(number+n);
    }
    public void subtract(int n){
        Console.WriteLine(number-n);
    }
    
    public static void Main(string[] args){
        program p = new program();
        add a = new add(p.sum);
        sub s = new sub(p.subtract);
        a(10);
        s(20);
    }
}

