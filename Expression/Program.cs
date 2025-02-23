
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
int[] numbers = { 4, 8, 15, 16, 23, 42 };
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
