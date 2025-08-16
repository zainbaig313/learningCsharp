// string message = "The quick brown fox jumps over the lazy dog.";

// // convert the message into a char array
// // char[] charMessage = message.ToCharArray();

// // // Reverse the char array
// // Array.Reverse(charMessage);

// // int x = 0;
// // // count the o's
// // foreach (char i in charMessage)
// // {
// //     if (i == 'o')
// //     {
// //         x++;
// //     }
// // }

// // // convert it back to a string
// // string new_message = new String(charMessage);

// // // print it out
// // Console.WriteLine(new_message);

// // Console.WriteLine($"'o' appears {x} times.");


// char[] charMessage = message.ToCharArray();

// Array.Reverse(charMessage);

// int x = 0;

// foreach (char c in charMessage)
// {
//     if (c == '0')
//     {
//         x++;
//     }
// }

// string new_message = new string(charMessage);



// string value1 = " a";
// string value2 = "A ";
// Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

// int saleAmount = 1001;
// // int discount = saleAmount > 1000 ? 100 : 50;

// Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

// Random coin = new Random();
// int flip = coin.Next(0, 2);
// string answer = flip == 0 ? "its head you win !" : "its tails you lose";
// Console.WriteLine(answer);

// string permission = "Admin|Manager";
// int level = 20;

// if (permission.Contains("Manager") && level < 20)
//     Console.WriteLine("You do not have sufficient privileges.");
// else if (permission.Contains("Manager") && level >= 20)
//     Console.WriteLine("Contact an Admin for access.");
// else if (permission.Contains("Admin") && level <= 55)
//     Console.WriteLine("Welcome, Admin user.");
// else if (permission.Contains("Admin") && (level > 55))
//     Console.WriteLine("Welcome, Super Admin user.");


// Code sample 2
// using System.Runtime.CompilerServices;

// int[] numbers = [4, 8, 15, 16, 23, 42];
// int total = 0;
// bool found = false;

// foreach (int number in numbers)
// {


//     total += number;

//     if (number == 42)
//         found = true;



// }

// if (found) 
//     Console.WriteLine("Set contains 42");



// Console.WriteLine($"Total: {total}");


// int x = 5;
// if (x > 0)
// {
//     int y = 6;
// }
// x = x + y;


// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
// string sku = "01-MN-L";

// string[] product = sku.Split('-');

// string type = "";
// string color = "";
// string size = "";

// switch (product[0])
// {
//     case "01":
//         type = "Sweat shirt";
//         break;
//     case "02":
//         type = "Sweat shirt";
//         break;
//     case "03":
//         type = "Sweat shirt";
//         break;
//     default:
//         type = "Other";
//         break;
// }

// switch (product[1])
// {
//     case "BL":
//        color = "Black";
//         break;
//     case "MN":
//        color = "Maroon";
//         break;
//     default:
//         color = "White";
//         break;
// }

// switch (product[2])
// {
//     case "S":
//        size = "Small";
//         break;
//     case "M":
//        size = "Medium";
//         break;
//     case "L":
//          size = "Large";

//         break;
//     default:
//          size = "One Size Fits All";
//         break;
// }


// Console.WriteLine($"Product: {size} {color} {type}");


// for (int i = 1; i <= 50; i++)
// {
//     Console.Write(i);
//     if ((i % 3 == 0) && (i % 5 == 0))
//         Console.Write(" -FizzBuzz");
//     else if (i % 3 == 0)
//         Console.Write("-fizz");
//     else if (i % 5 == 0)
//         Console.Write("-Buzz");

//     Console.Write("\n");
// 

// Random attack = new Random();
// int heroHealth = 10;
// int monsterHealth = 10;
// while (heroHealth >= 0 && monsterHealth >= 0)
// {
//     int heroAttack = attack.Next(1, 10);
//     monsterHealth -= heroAttack;

//     Console.WriteLine($"Monster was damaged and lost {heroAttack} health and now has {monsterHealth} health.");

//     int monsterAttack = attack.Next(1, 10);
//     heroHealth -= monsterAttack;
//     Console.WriteLine($"Hero was damaged and lost {monsterAttack} health and now has {heroHealth} health.");

//     if (monsterHealth < 0)
//     {
//         Console.WriteLine("Hero Wins");
//         break;
//     }
//     else if (heroHealth < 0)
//     {
//         Console.WriteLine("Monster Wins");
//         break;
//     }
// }

// capture user input in a string variable named readResult

// ---------------------Code project 1 - write code that validates integer input
// string? userInput;
// Console.WriteLine("Enter an integer value between 5 and 10");
// int user = 0;
// bool validNumber = false;
// do
// {
//     userInput = Console.ReadLine();

//     validNumber = int.TryParse(userInput, out user);
//     if (validNumber)
//     {

//         if (user > 5 && user < 10)
//         {

//             continue;
//         }
//         else
//         {
//             Console.WriteLine($"you enter {user}, please try again 5 and 10");
//         }
//     }
//     else
//     {
//         Console.WriteLine("Sorry, you entered an invalid number, please try again");
//     }

// } while (!(user > 5 && user < 10));

// Console.WriteLine($"your input value {7} has been accepted");

// ----------------------------------Code project 2 - write code that validates string input

// string? userRole;
// string? userInputRole;
// bool accepted = false;

// Console.WriteLine("Enter your role name (Administrator, Manager, or User)");

// do
// {
//     userRole = Console.ReadLine();

//     userInputRole = userRole.Trim().ToLower();

//     switch (userInputRole)
//     {
//         case "administrator":
//             accepted = true;
//             break;
//         case "Manager":
//             accepted = true;
//             break;
//         case "User":
//             accepted = true;
//             break;
//         default:
//             Console.WriteLine($"The role name that you entered, {userInputRole} is not valid. Enter your role name (Administrator, Manager, or User)");
//             break;


//     }

// } while (!accepted);
// Console.WriteLine($"Your input value ({userInputRole}) has been accepted.");



// ------------------------Code project 3 - Write code that processes the contents of a string array
// string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
// int stringsCount = myStrings.Length;

// string myString = "";
// int periodLocation = 0;

// for (int i = 0; i < stringsCount; i++)
// {
//     myString = myStrings[i];
//     periodLocation = myString.IndexOf(".");

//     string mySentence;

//     // extract sentences from each string and display them one at a time
//     while (periodLocation != -1)
//     {

//         // first sentence is the string value to the left of the period location
//         mySentence = myString.Remove(periodLocation);

//         // the remainder of myString is the string value to the right of the location
//         myString = myString.Substring(periodLocation + 1);

//         // remove any leading white-space from myString
//         myString = myString.TrimStart();

//         // update the comma location and increment the counter
//         periodLocation = myString.IndexOf(".");

//         Console.WriteLine(mySentence);
//     }

//     mySentence = myString.Trim();
//     Console.WriteLine(mySentence);
// }

string[] myStrings = ["I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices"];
int periodLocation = 0;
string myString = "";

for (int i = 0; i < myStrings.Length; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence = "";
    while (periodLocation != -1)
    {
        mySentence = myString.Remove(periodLocation);

        myString = myString.Substring(periodLocation + 1);

        myString = myString.TrimStart();

        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }
    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}