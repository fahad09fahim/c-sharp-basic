// basic c# 
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
         Random ran = new Random();
        
      int ranNum = ran.Next(1,10);
      int num=0;
      while(num!=ranNum){
           num = int.Parse(Console.ReadLine());
          if(num<ranNum){
             Console.WriteLine("Take bigger");
          }else  if(num>ranNum){
                 Console.WriteLine("Take less");
          }else{
              Console.WriteLine("Matched Number is: "+ num);
          }
      }

    }
}
