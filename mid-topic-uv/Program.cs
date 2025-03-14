﻿
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
// using System;
// class A
// {
//     public virtual void display()
//     {
//         Console.WriteLine("Function of class A");
//     }
// }
// class B : A
// {
//     public override void display()
//     {
//         Console.WriteLine("Function of class B");
//     }
// }
// public class Program
// {
//     public static void Main(string[] args)
//     {
//         A obj = new B();
//         obj.display();

//     }
// }


// using System;

// public class TrafficLightController
// {
//     public static void Main(string[] args)
//     {
//         // Simulate traffic light inputs (replace with actual sensor data)
//         bool roadAIsGreen = true; // Example: Road A is green
//         bool roadBIsGreen = false; // Example: Road B is red

//         // Convert boolean to binary representation (1 for green, 0 for red)
//         int a = roadAIsGreen ? 1 : 0;
//         int b = roadBIsGreen ? 1 : 0;

//         // Apply the boolean logic
//         bool isSafe = (a == 1 && b == 0) || (a == 0 && b == 1);

//         // Output the result
//         Console.WriteLine("Road A is Green: " + roadAIsGreen);
//         Console.WriteLine("Road B is Green: " + roadBIsGreen);
//         Console.WriteLine("Is the traffic light configuration safe? " + isSafe);

//         // Additional: Control the traffic lights based on the logic
//         if (isSafe)
//         {
//             Console.WriteLine("Traffic lights are configured correctly.");
//             // Send signals to the traffic lights to maintain the current state.
//         }
//         else
//         {
//             Console.WriteLine("Traffic lights are in an unsafe state. Correcting...");
//             // Send signals to the traffic lights to change the states (e.g., make Road B green if Road A is red).
//         }
//     }
// }


// using System;
// class car
// {
//     public void info()
//     {
//         Console.WriteLine("This is a car");
//     }
//     public void info(int i)
//     {
//         Console.WriteLine("This is a car2");
//     }
//     public int information()
//     {
//         return 1;
//     }
// }
// public class myApp
// {
//     public static void Main(string[] args)
//     {
//         car obj = new car();
//         {
//             obj.info();
//             obj.info(1);
//             Console.WriteLine(obj.information());
//         }
//     }
// }

// MID Question output tracing 

using System;
public class Program
{
    public void func(int n)
    {
        int m = 0;
        if (n < 5)
        {
            Console.WriteLine("Do not execute the loop");

        }
        else
        {
            while (n <= 5)
            {
                m = n++ + ++n + --n + n--;
                n--;
            }
        }
        Console.WriteLine(m);
    }
    public static void Main(string[] args)
    {
        Program obj = new Program();
        obj.func(5);
    }
}

