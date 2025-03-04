
//without overridding
/*using System;
class A
{
    public void display()
    {
        Console.WriteLine("Function of class A");
    }
}
class B : A
{
    public void display()
    {
        Console.WriteLine("Function of class B");
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        A obj = new B();
        obj.display();

    }
}*/
//with overridding
using System;
class A
{
    public virtual void display()
    {
        Console.WriteLine("Function of class A");
    }
}
class B : A
{
    public override void display()
    {
        Console.WriteLine("Function of class B");
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        A obj = new B();
        obj.display();

    }
}