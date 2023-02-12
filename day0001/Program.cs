// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello C#");

int num = 10;
var num1 = 20;

Console.WriteLine(num);
Console.WriteLine(num1);


const int num2 = 10;
Console.WriteLine(num2);

double myDouble = 9.78;
int myInt = (int)myDouble;    // Manual casting: double to int

Console.WriteLine(myDouble);   // Outputs 9.78
Console.WriteLine(myInt);      // Outputs 9

myInt = 10;
myDouble = 5.25;
bool myBool = true;

Console.WriteLine(Convert.ToString(myInt));    // convert int to string
Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
Console.WriteLine(Convert.ToString(myBool));   // convert bool to string

// Type your username and press enter
//Console.WriteLine("Enter username:");

//// Create a string variable and get user input from the keyboard and store it in the variable
//string userName = Console.ReadLine();

//// Print the value of the variable (userName), which will display the input value
//Console.WriteLine("Username is: " + userName);


//Console.WriteLine("Enter your age:");
//int age = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Your age is: " + age);

int x = 3;
int y = 3;
Console.WriteLine(x > y); // returns True because 5 is greater than 3

Console.WriteLine(Math.Max(5, 5));
Console.WriteLine(Math.Min(5, 5));
Console.WriteLine(Math.Sqrt(64));

// C# String class , you have tow learn

string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
Console.WriteLine("The length of the txt string is: " + txt.Length);

txt = "Hello World";
Console.WriteLine(txt.ToUpper());   // Outputs "HELLO WORLD"
Console.WriteLine(txt.ToLower());   // Outputs "hello world"

// String concatenation

string firstName = "John ";
string lastName = "Doe";
//string name = firstName + lastName;
string name = String.Concat(firstName, lastName);

Console.WriteLine(name);

// Adding Numbers and Strings
string xstr = "10";
string ystr = "20";
string zstr = xstr + ystr;  // z will be 1020 (a string)
Console.WriteLine(zstr);

/*
    String Interpolation 
    Another option of string concatenation, is string interpolation, 
    which substitutes values of variables into placeholders in a string. 
    Note that you do not have to worry about spaces, like with concatenation: 
*/

string fname = "Abiansh";
string sname = "Mishra";
string finalname = $"My full name is: {fname} {sname}";
Console.WriteLine(finalname);

/*
    Access Strings
    You can access the characters in a string by referring to its index number inside square brackets [].
*/

string myString = "Hello";
Console.WriteLine(myString[3]);  // Outputs "H"

/*
    You can also find the index position of a specific character in a string, 
    by using the IndexOf() method: 
*/

Console.WriteLine(myString.IndexOf("e"));  // Outputs "1"

// Full name
string myname = "Abinash Mishra";

// Location of the letter D
int charPos = myname.IndexOf("M");

// Get last name
string lastname = myname.Substring(charPos);

// Print the result
Console.WriteLine(lastname); // Mishra

// Learn the bool
bool isCSharpFun = true;
bool isFishTasty = false;

int n = 10;

Console.WriteLine(isCSharpFun);   // Outputs True
Console.WriteLine(isFishTasty);   // Outputs False
Console.WriteLine(n == 10);   // Outputs True

// An Example of boolean expresiion
x = 10;
y = 9;

Console.WriteLine(x > y); // returns True, because 10 is higher than 9

x = 9;
y = 10;

Console.WriteLine(x > y); // returns True, because 10 is higher than 9

int myAge = 25;
int votingAge = 18;

if (myAge >= votingAge) Console.WriteLine("Old enough to vote!");
else Console.WriteLine("Not old enough to vote.");

x = 20; y = 18;
if (x > y) Console.WriteLine("x is greater than y");

int day = 4;
switch (day)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    case 7:
        Console.WriteLine("Sunday");
        break;
}

// while loop
int i = 0;
while (i < 5)
{
    Console.WriteLine(i);
    i++;
}

// do while loop
i = 0;
do
{
    Console.WriteLine(i);
    i++;
}
while (i < 5);

// For loop
for (i = 0; i < 5; i++)
{
    Console.WriteLine(i);
}

// nested loop is also same as C++

// Outer loop
for (i = 1; i <= 2; ++i)
{
    Console.WriteLine("Outer: " + i);  // Executes 2 times

    // Inner loop
    for (int j = 1; j <= 3; j++)
    {
        Console.WriteLine(" Inner: " + j); // Executes 6 times (2 * 3)
    }
}

// foreach loop
string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
foreach (string s in cars)
{
    Console.WriteLine(s);
}

// one example for impl the break
for (i = 0; i < 10; i++)
{
    if (i == 4)
    {
        break;
    }
    Console.WriteLine(i);
}

// one ex for c# continue
for (i = 0; i < 10; i++)
{
    if (i == 4)
    {
        continue;
    }
    Console.WriteLine(i);
}

// ex of Break and Continue in While Loop
i = 0;
while (i < 10)
{
    Console.WriteLine(i);
    i++;
    if (i == 4)
    {
        break;
    }
}

i = 0;
while (i < 10)
{
    if (i == 4)
    {
        i++;
        continue;
    }
    Console.WriteLine(i);
    i++;
}







