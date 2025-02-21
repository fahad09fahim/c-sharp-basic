/*
string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
// fraudulentOrderIDs[3] = "D000";
*/

//declare array of string  and initialize with some values
string[] fraudulentOrderIDs = ["A123", "B456", "C789"];

// Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
// Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
// Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

// fraudulentOrderIDs[0] = "F000";

// Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");


//For each loop functionality
int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
int bin = 0;
// foreach (var item in inventory)
// {
//     sum += item;
//     bin++;
//     Console.WriteLine($"Bin {bin} = {item} items (Running total: {sum})");
// }

// Console.WriteLine($"We have {sum} items in inventory.");

//Code challenge - Report the Order IDs that need further investigation

string[] items = {"B123",
"C234",
"A345",
"C15",
"B177",
"G3003",
"C235",
"B179"};

foreach (string item in items)
{
    if (item.StartsWith("B"))
    {
        Console.WriteLine(item);
    }
}