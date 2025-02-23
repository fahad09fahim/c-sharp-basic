
//Method thats returns a boolean value
string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("cow"));

// Use the Logical Negation operator

Console.WriteLine(!pangram.Contains("cow"));