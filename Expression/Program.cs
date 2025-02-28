
//Method thats returns a boolean value
string pangram = "The quick brown fox jumps over the lazy dog.";
// Console.WriteLine(pangram.Contains("fox"));
// Console.WriteLine(pangram.Contains("cow"));

// Use the Logical Negation operator

// Console.WriteLine(!pangram.Contains("cow"));

//Coin flip using ternary operator
Random coin = new Random();
int coinFlip = coin.Next(0, 2);
// Console.WriteLine(coinFlip == 0 ? "Heads" : "Tails");


//Exercise - Complete a challenge activity using Boolean expressions

/*string permission = "Admin | Manager";
int level = 53;

if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else if (level > 50)
    {
        Console.WriteLine("Welcome, Admin user.");
    }
    else if (permission.Contains("Manager"))
    {
        if (level >= 20)
        {
            Console.WriteLine("Contact an Admin for access.");
        }
        else
        {
            Console.WriteLine("You do not have sufficient privileges.");
        }
    }
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}*/

// bool flag = true;
// if (flag)
// {
//     int value = 10;
//     Console.WriteLine($"Inside the code block: {value}");
// }


//---------  Code challenge: update problematic code in the code editor-----------///
/*int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0;


foreach (int number in numbers)
{

    total += number;

    if (number == 42)
    {
        Console.WriteLine("Set contains 42");
    }

}
Console.WriteLine($"Total: {total}");
*/

//-----------------------------Code challenge - implement the FizzBuzz challenge rules---------//


/*for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine(i + "-FizzBuzz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine(i + "-Buzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine(i + "-Fizz");
    }
    else
    {
        Console.WriteLine(i);
    }
}
*/

//------------Complete a challenge activity using do and while iteration statements-------------------//
// int hero = 10;
// int monster = 10;

// Random dice = new Random();

// do
// {
//     int roll = dice.Next(1, 11);
//     monster -= roll;
//     Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

//     if (monster <= 0) continue;

//     roll = dice.Next(1, 11);
//     hero -= roll;
//     Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

// } while (hero > 0 && monster > 0);

// Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");


//--------------------------Code project 1 - write code that validates integer input---------------------------------//

bool validEntry = false;
Console.WriteLine("Enter an integer value between 5 and 10");
do
{
    int readResult = int.Parse(Console.ReadLine());
    if (readResult >= 5 && readResult <= 10)
    {
        Console.WriteLine($"Your input value ({readResult}) has been accepted.");
        validEntry = true;
    }
    else if (readResult < 5 || readResult > 10)
    {
        Console.WriteLine($"You entered {readResult}. Please enter a number between 5 and 10.");
    }
    else
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }

} while (validEntry == false);