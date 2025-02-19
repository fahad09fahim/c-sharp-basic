/*
using System;

public class App{
    public void newApp(){
        Console.WriteLine("New App Created");
    }
    public void newApp(string n){
         Console.WriteLine("New App Created. App of the name: "+ n);
    }
    public void newApp(string n, int m){
         Console.WriteLine("New App Created. App of the name: "+ n +" User of this app now "+ m);
    }
     
}

public class HelloWorld
{
    public void sum(){
        Console.WriteLine("This is function 1");
    }
    public void sum(int n){
        Console.WriteLine("This is function 2");
    }
    public void sum(int n,char m ){
        Console.WriteLine("This is function 3");
    }
    public void sum(char m, int n ){
        Console.WriteLine("This is function 4");
    }
      public static void Main(string[] args){
     HelloWorld hw = new HelloWorld();
     hw.sum('5',6);
     App ap = new App();
     ap.newApp("Fintrackr");
     Console.WriteLine("Give user number");
     int n = int.Parse(Console.ReadLine());
     ap.newApp("Fintrackr",n);
    }
}
*/

// polymorphism and inheritance
/*
using System;

public class SubClass{
    public void show(){
        Console.WriteLine("This is subclass show");
    }
}
public class HelloWorld : SubClass{
    public void show(){
        Console.WriteLine("This is HelloWorld show");
    }
    public void show(int n){
        Console.WriteLine("This is Another Show "+n);
    }
}
public class MainApp{
    public static void Main(string[]args){
        // Console.WriteLine("Hello World!");
        SubClass sc = new SubClass();
        sc.show();
        HelloWorld hw = new HelloWorld();
        hw.show(6);
    }
}
*/

// using System;

// public class Animal{
//     public virtual void Sound(){
//         Console.WriteLine("Animal makes sound");
//     }
//     public static void Main(string[] args){
//         Animal a = new Animal();
//         a.Sound();
//     }
// }

// Classwork 2 (Class, Object, Inheritance, Function Overloading and Overriding Concept):
public class Myapp{
   
    public class Human{
     
        public void nameFunc(string name){
            Console.WriteLine("Calculator Owner's name is: "+ name);
        }
    }
    public class Calculator:Human{
        public virtual int sum(){
            int x = 5;
            int y = 10;
            return x+y;
        }
    }
    public class SciCalculator:Calculator{
        public override int sum(){
            int x = 10;
            int y = 5;
            return x-y;
        }
         public int sum(int x, int y){
            return x+y;
        }
    }
    public static void Main(string[]args){
    //    Console.WriteLine("Hello world");
    Human hw = new Human();
   
    // only string don't need to use Parse
    Console.Write("Enter name: ");
    string name = Console.ReadLine();
    hw.nameFunc(name);
   
    Calculator cal = new Calculator();
    cal.nameFunc(name);
    Console.WriteLine("sum result from calculator: "+cal.sum());
   
    SciCalculator sciCal = new SciCalculator();
    sciCal.nameFunc(name);
    Console.Write("Enter a number: ");
    int x = int.Parse(Console.ReadLine());
    Console.Write("Enter another number: ");
    int y = int.Parse(Console.ReadLine());
    Console.WriteLine("Result from user input: "+sciCal.sum(x,y));
    Console.WriteLine("sum result from sciCalculator: "+sciCal.sum());


}
}
