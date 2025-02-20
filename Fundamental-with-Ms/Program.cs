//Console.WriteLine("Hello, World!");

/*Console.Write("Congratulations!");
Console.Write(" ");
Console.Write("You wrote your first lines of code");
Console.WriteLine("Congratulations!");
Console.Write("You wrote your first lines of code");

Float Type    Precision
----------------------------
float         ~6-9 digits
double        ~15-17 digits
decimal        28-29 digits

*/
//----------------------------------module two--------------------/
//Console.WriteLine(0.25F);
/*string firstName;
firstName = "Bob";
Console.WriteLine(firstName);
*/
// useCase of data-types and var keyword
/*string name = "Bob";
int num = 3;
var temperature = 34.4;

Console.Write("Hello, "+name+"!");
Console.Write(" You have "+num+" messages in your inbox.");
Console.Write(" The temperature is "+temperature+" celsius.");
*/
//-------------Format output using unicode escape characters--------------//
// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
//Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// User command to run an application
// Console.WriteLine(@"c:\invoices\app.exe -j");


/*string projectName = "ACME";

string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

Console.WriteLine("View English Output: ");
Console.WriteLine($"c:\\Exercise\\{projectName}\\data.txt"); 
Console.WriteLine(russianMessage+":");
Console.WriteLine($"c:\\Exercise\\{projectName}\\ru-Ru\\data.txt"); 
*/

//Perform basic operations on numbers in C#

/*In math, PEMDAS is an acronym that helps students remember the order of operations. The order is:
1.Parentheses (whatever is inside the parenthesis is performed first)
2.Exponents
3.Multiplication and Division (from left to right)
4.Addition and Subtraction (from left to right)
*/

// initialize variables - graded assignments 
int currentAssignments = 5;

int sophia1 = 93;
int sophia2 = 87;
int sophia3 = 98;
int sophia4 = 95;
int sophia5 = 100;

int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;

int zahirah1 = 84;
int zahirah2 = 96;
int zahirah3 = 73;
int zahirah4 = 85;
int zahirah5 = 79;

int jeong1 = 90;
int jeong2 = 92;
int jeong3 = 98;
int jeong4 = 100;
int jeong5 = 97;

int sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
int nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
int zahirahSum = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
int jeongSum = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;

decimal sophiaScore = (decimal) sophiaSum / currentAssignments;
decimal nicolasScore = (decimal) nicolasSum / currentAssignments;
decimal zahirahScore = (decimal) zahirahSum / currentAssignments;
decimal jeongScore = (decimal) jeongSum / currentAssignments;

Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA");
Console.WriteLine("Nicolas:\t" + nicolasScore + "\tB");
Console.WriteLine("Zahirah:\t" + zahirahScore + "\tB");
Console.WriteLine("Jeong:\t\t" + jeongScore + "\tA");