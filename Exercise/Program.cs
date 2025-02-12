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
