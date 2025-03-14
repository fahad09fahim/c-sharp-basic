
// //signed integral types:
// Console.WriteLine("Signed integral types:");

// Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
// Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
// Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
// Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");
// /*
// Signed integral types:
// sbyte  : -128 to 127
// short  : -32768 to 32767
// int    : -2147483648 to 2147483647
// long   : -9223372036854775808 to 9223372036854775807

// Unsigned integral types:
// byte   : 0 to 255
// ushort : 0 to 65535
// uint   : 0 to 4294967295
// ulong  : 0 to 18446744073709551615
// */

// //unsigned integral types:
// Console.WriteLine("");
// Console.WriteLine("Unsigned integral types:");

// Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
// Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
// Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
// Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");


// // Floating point numbers
// Console.WriteLine("");
// Console.WriteLine("Floating point types:");
// Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
// Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
// Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");


// //ref type array 
// int[] ref_A = new int[1];
// ref_A[0] = 2;
// int[] ref_B = ref_A;
// ref_B[0] = 5;

// Console.WriteLine("--Reference Types--");
// Console.WriteLine($"ref_A[0]: {ref_A[0]}");
// Console.WriteLine($"ref_B[0]: {ref_B[0]}");


//tyrParse method
/*
The TryParse() method does several things simultaneously:

It attempts to parse a string into the given numeric data type.
If successful, it stores the converted value in an out parameter, explained in following section.
It returns a bool to indicate whether the action succeeded or failed.
*/

// string value = "102";
// int result = 0;
// if (int.TryParse(value, out result))
// {
//     Console.WriteLine($"Measurement: {result}");
// }
// else
// {
//     Console.WriteLine("Unable to report the measurement.");
// }


//challenge project
// int value1 = 11;
// decimal value2 = 6.2m;
// float value3 = 4.3f;

// // Your code here to set result1
// // Hint: You need to round the result to nearest integer (don't just truncate)
// int result1 = (int)Math.Round((decimal)value1 / value2);
// Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// // Your code here to set result2
// decimal result2 = value2 / (decimal)value3;
// Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// // Your code here to set result3
// float result3 = value3 / value1;
// Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");

// Array sorting 
string[] pallets = ["B14", "A11", "B12", "A13"];

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine(" ");

Console.WriteLine("Reversed");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

string value = "abc123";
char[] valueArray = value.ToCharArray();
// Array.Reverse(valueArray);
Array.Sort(valueArray);

// string result = String.Join(",", valueArray);
// Console.WriteLine(result);
// string[] items = result.Split(',');
// foreach (var item in items)
// {
//     Console.WriteLine(item);
// }


// string pangram = "The quick brown fox jumps over the lazy dog";

// // Step 1
// string[] message = pangram.Split(' ');

// //Step 2
// string[] newMessage = new string[message.Length];

// // Step 3
// for (int i = 0; i < message.Length; i++)
// {
//     char[] letters = message[i].ToCharArray();
//     Array.Reverse(letters);
//     newMessage[i] = new string(letters);
// }

// //Step 4
// string result = String.Join(" ", newMessage);
// Console.WriteLine(result);



decimal price = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

Console.WriteLine(yourDiscount);

/*
Format currency using a :C specifier.
Format numbers using a :N specifier. Control the precision (number of values after the decimal point) using a number after the :N like {myNumber:N3}.
Format percentages using the :P format specifier.
Formatting currency and numbers depend on the end user's culture, a five character code that includes the user's country/region and language (per the settings on their computer).*/