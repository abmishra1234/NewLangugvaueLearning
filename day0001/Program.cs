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

