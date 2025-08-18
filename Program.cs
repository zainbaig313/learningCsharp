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

// string[] myStrings = ["I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices"];
// int periodLocation = 0;
// string myString = "";

// for (int i = 0; i < myStrings.Length; i++)
// {
//     myString = myStrings[i];
//     periodLocation = myString.IndexOf(".");

//     string mySentence = "";
//     while (periodLocation != -1)
//     {
//         mySentence = myString.Remove(periodLocation);

//         myString = myString.Substring(periodLocation + 1);

//         myString = myString.TrimStart();

//         periodLocation = myString.IndexOf(".");

//         Console.WriteLine(mySentence);
//     }
//     mySentence = myString.Trim();
//     Console.WriteLine(mySentence);
// }

// the ourAnimals array will store the following: 
// string animalSpecies = "";
// string animalID = "";
// string animalAge = "";
// string animalPhysicalDescription = "";
// string animalPersonalityDescription = "";
// string animalNickname = "";

// // variables that support data entry
// int maxPets = 8;
// string? readResult;
// string menuSelection = "";

// // array used to store runtime data, there is no persisted data
// string[,] ourAnimals = new string[maxPets, 6];

// // TODO: Convert the if-elseif-else construct to a switch statement

// // create some initial ourAnimals array entries
// for (int i = 0; i < maxPets; i++)
// {
//     switch (i)
//     {
//         case 0:
//             animalSpecies = "dog";
//             animalID = "d1";
//             animalAge = "2";
//             animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
//             animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
//             animalNickname = "lola";
//             break;

//         case 1:
//             animalSpecies = "dog";
//             animalID = "d2";
//             animalAge = "9";
//             animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
//             animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
//             animalNickname = "loki";
//             break;

//         case 2:
//             animalSpecies = "cat";
//             animalID = "c3";
//             animalAge = "1";
//             animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
//             animalPersonalityDescription = "friendly";
//             animalNickname = "Puss";
//             break;

//         case 3:
//             animalSpecies = "cat";
//             animalID = "c4";
//             animalAge = "?";
//             animalPhysicalDescription = "";
//             animalPersonalityDescription = "";
//             animalNickname = "";
//             break;

//         default:
//             animalSpecies = "";
//             animalID = "";
//             animalAge = "";
//             animalPhysicalDescription = "";
//             animalPersonalityDescription = "";
//             animalNickname = "";
//             break;
//     }


//     ourAnimals[i, 0] = "ID #: " + animalID;
//     ourAnimals[i, 1] = "Species: " + animalSpecies;
//     ourAnimals[i, 2] = "Age: " + animalAge;
//     ourAnimals[i, 3] = "Nickname: " + animalNickname;
//     ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
//     ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
// }


// do
// {
//     // display the top-level menu options

//     Console.Clear();

//     Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
//     Console.WriteLine(" 1. List all of our current pet information");
//     Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
//     Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
//     Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
//     Console.WriteLine(" 5. Edit an animal’s age");
//     Console.WriteLine(" 6. Edit an animal’s personality description");
//     Console.WriteLine(" 7. Display all cats with a specified characteristic");
//     Console.WriteLine(" 8. Display all dogs with a specified characteristic");
//     Console.WriteLine();
//     Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

//     readResult = Console.ReadLine();
//     if (readResult != null)
//     {
//         menuSelection = readResult.ToLower();
//     }

//     //Console.WriteLine($"You selected menu option {menuSelection}.");
//     //Console.WriteLine("Press the Enter key to continue");

//     // pause code execution
//     //readResult = Console.ReadLine();

//     switch (menuSelection)
//     {
//         case "1": // List all of our current pet information
//             for (int i = 0; i < maxPets; i++)
//             {
//                 if (ourAnimals[i, 0] != "ID #: ")
//                 {
//                     Console.WriteLine();
//                     for (int j = 0; j < 6; j++)
//                     {
//                         Console.WriteLine(ourAnimals[i, j]);
//                     }
//                 }
//             }
//             Console.WriteLine("Press the Enter key to continue.");
//             readResult = Console.ReadLine();
//             break;

//         case "2": // Add a new animal friend to the ourAnimals array
//             string anotherPet = "y";
//             int petCount = 0;


//             for (int i = 0; i < maxPets; i++)
//             {
//                 if (ourAnimals[i, 0] != "ID #: ")
//                 {
//                     petCount += 1;
//                 }
//             }

//             if (petCount < maxPets)
//             {
//                 Console.WriteLine($"We currently have {petCount} pets that need homes. We can manage {(maxPets - petCount)} more.");
//             }

//             bool validEntry = false;
//             // get species (cat or dog) - string animalSpecies is a required field 
//             do
//             {
//                 Console.WriteLine("\n\rEnter 'dog' or 'cat' to begin a new entry");
//                 readResult = Console.ReadLine();
//                 if (readResult != null)
//                 {
//                     animalSpecies = readResult.ToLower();
//                     if (animalSpecies != "dog" && animalSpecies != "cat")
//                     {
//                         validEntry = false;
//                     }
//                     else
//                     {
//                         validEntry = true;
//                     }

//                 }
//             } while (validEntry == false);

//             // build the animal the ID number - for example C1, C2, D3 (for Cat 1, Cat 2, Dog 3)
//             animalID = animalSpecies.Substring(0, 1) + (petCount + 1).ToString();

//             // get the pet's age. can be ? at initial entry. 
//             do
//             {
//                 int petAge;
//                 Console.WriteLine("Enter the pet's age or enter ? if unknown");
//                 readResult = Console.ReadLine();
//                 if (readResult != null)
//                 {
//                     animalAge = readResult;
//                     if (animalAge != "?")
//                     {
//                         validEntry = int.TryParse(animalAge, out petAge);
//                     }
//                     else
//                     {
//                         validEntry = true;
//                     }

//                 }

//             } while (validEntry == false);

//             // get a description of the pet's physical appearance/condition - animalPhysicalDescription can be blank.
//             // get a description of the pet's physical appearance/condition - animalPhysicalDescription can be blank.
//             do
//             {
//                 Console.WriteLine("Enter a physical description of the pet (size, color, gender, weight, housebroken)");
//                 readResult = Console.ReadLine();
//                 if (readResult != null)
//                 {
//                     animalPhysicalDescription = readResult.ToLower();
//                     if (animalPhysicalDescription == "")
//                     {
//                         animalPhysicalDescription = "tbd";
//                     }
//                 }
//             } while (animalPhysicalDescription == "");

//             // get a description of the pet's personality - animalPersonalityDescription can be blank.
//             // get a description of the pet's personality - animalPersonalityDescription can be blank.
//             do
//             {
//                 Console.WriteLine("Enter a description of the pet's personality (likes or dislikes, tricks, energy level)");
//                 readResult = Console.ReadLine();
//                 if (readResult != null)
//                 {
//                     animalPersonalityDescription = readResult.ToLower();
//                     if (animalPersonalityDescription == "")
//                     {
//                         animalPersonalityDescription = "tbd";
//                     }
//                 }
//             } while (animalPersonalityDescription == "");

//             // get the pet's nickname. animalNickname can be blank.
//             do
//             {
//                 Console.WriteLine("Enter a nickname for the pet");
//                 readResult = Console.ReadLine();
//                 if (readResult != null)
//                 {
//                     animalNickname = readResult.ToLower();
//                     if (animalNickname == "")
//                     {
//                         animalNickname = "tbd";
//                     }
//                 }
//             } while (animalNickname == "");

//             // store the pet information in the ourAnimals array (zero based)
//             ourAnimals[petCount, 0] = "ID #: " + animalID;
//             ourAnimals[petCount, 1] = "Species: " + animalSpecies;
//             ourAnimals[petCount, 2] = "Age: " + animalAge;
//             ourAnimals[petCount, 3] = "Nickname: " + animalNickname;
//             ourAnimals[petCount, 4] = "Physical description: " + animalPhysicalDescription;
//             ourAnimals[petCount, 5] = "Personality: " + animalPersonalityDescription;

//             while (anotherPet == "y" && petCount < maxPets)
//             {
//                 // increment petCount (the array is zero-based, so we increment the counter after adding to the array)
//                 petCount = petCount + 1;
//                 // check maxPet limit
//                 if (petCount < maxPets)
//                 {
//                     // another pet?
//                     Console.WriteLine("Do you want to enter info for another pet (y/n)");
//                     do
//                     {
//                         readResult = Console.ReadLine();
//                         if (readResult != null)
//                         {
//                             anotherPet = readResult.ToLower();
//                         }

//                     } while (anotherPet != "y" && anotherPet != "n");
//                 }

//             }
//             if (petCount >= maxPets)
//             {
//                 Console.WriteLine("We have reached our limit on the number of pets that we can manage.");
//                 Console.WriteLine("Press the Enter key to continue.");
//                 readResult = Console.ReadLine();
//             }

//             break;


//         case "3": // Ensure animal ages are complete
//             for (int i = 0; i < maxPets; i++)
//             {
//                 // Check if this slot actually has an animal (ID not empty)
//                 if (ourAnimals[i, 0] != "ID #: ")
//                 {
//                     // Check if the Age field is empty or unknown
//                     if (ourAnimals[i, 2] == "Age: " || ourAnimals[i, 2] == "Age: ?")
//                     {
//                         bool validEntry = false;
//                         int petAge = 0;

//                         do
//                         {
//                             Console.WriteLine($"Enter an age for {ourAnimals[i, 0]}");
//                             readResult = Console.ReadLine();

//                             if (!string.IsNullOrWhiteSpace(readResult))
//                             {
//                                 // try parse user input
//                                 validEntry = int.TryParse(readResult, out petAge);

//                                 if (validEntry && petAge > 0) // must be a positive number
//                                 {
//                                     // ✅ store with "Age: " prefix
//                                     ourAnimals[i, 2] = "Age: " + petAge.ToString();
//                                 }
//                                 else
//                                 {
//                                     Console.WriteLine("Invalid age. Please enter a valid number greater than 0.");
//                                     validEntry = false;
//                                 }
//                             }
//                             else
//                             {
//                                 Console.WriteLine("Input cannot be empty. Please enter a number.");
//                                 validEntry = false;
//                             }

//                         } while (validEntry == false);
//                     }
//                 }
//             }

//             Console.WriteLine("Press the Enter key to continue.");
//             readResult = Console.ReadLine();
//             break;
//         case "4":
//             Console.WriteLine("this app feature is coming soon - please check back to see progress.");
//             Console.WriteLine("Press the Enter key to continue.");
//             readResult = Console.ReadLine();
//             break;

//         case "5":
//             Console.WriteLine("this app feature is coming soon - please check back to see progress.");
//             Console.WriteLine("Press the Enter key to continue.");
//             readResult = Console.ReadLine();
//             break;

//         case "6":
//             Console.WriteLine("this app feature is coming soon - please check back to see progress.");
//             Console.WriteLine("Press the Enter key to continue.");
//             readResult = Console.ReadLine();
//             break;


//         case "7":
//             Console.WriteLine("this app feature is coming soon - please check back to see progress.");
//             Console.WriteLine("Press the Enter key to continue.");
//             readResult = Console.ReadLine();
//             break;

//         case "8":
//             Console.WriteLine("this app feature is coming soon - please check back to see progress.");
//             Console.WriteLine("Press the Enter key to continue.");
//             readResult = Console.ReadLine();
//             break;
//         default:
//             break;
//     }

// } while (menuSelection != "exit");


// Console.WriteLine("Signed integral types:");

// Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
// Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
// Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
// Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

// Console.WriteLine("");
// Console.WriteLine("Unsigned integral types:");

// Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
// Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
// Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
// Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

// Console.WriteLine("");
// Console.WriteLine("Floating point types:");
// Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
// Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
// Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");


// int first = 2;
// string second = "4";
// string result = first + second;
// Console.WriteLine(result);
// int myInt = 3;
// Console.WriteLine($"int: {myInt}");

// decimal myDecimal = myInt;
// Console.WriteLine($"decimal: {myDecimal}");


// decimal myDecimal = 3.14m;
// Console.WriteLine($"decimal: {myDecimal}");

// int myInt = (int)myDecimal;
// Console.WriteLine($"int: {myInt}");

// string first = "hello";
// string second = "7";
// int sum = int.Parse(first) + int.Parse(second);
// Console.WriteLine(sum);
// string value1 = "kk";
// string value2 = "7";
// int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
// Console.WriteLine(result);

// int value = (int)1.5m; // casting truncates
// Console.WriteLine(value);

// int value2 = Convert.ToInt32(1.5m); // converting rounds up
// Console.WriteLine(value2);

// string[] values = ["12.3", "45", "ABC", "11", "DEF"];
// float Total = 0;
// string Message = "";
// for (int i = 0; i < values.Length; i++)
// {
//     if (float.TryParse(values[i], out float result))
//     {
//         Total += result;
//     }
//     else
//     {
//         Message += values[i];
//     }
// }

// Console.WriteLine($"Message : {Message}");
// Console.WriteLine($"Total  : {Total}");

// int value1 = 11;
// decimal value2 = 6.2m;
// float value3 = 4.3f;


// int result1  = Convert.ToInt32(value1/value2);
// Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");


// decimal result2 = Convert.ToDecimal(value2 / (decimal)value3);
// Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// float result3 = Convert.ToSingle(value3/value1);
// Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
// string[] pallets = [ "B14", "A11", "B12", "A13" ];

// Console.WriteLine("Sorted...");
// Array.Sort(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("Reversed...");
// Array.Reverse(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }


// string[] pallets = [ "B14", "A11", "B12", "A13" ];
// Console.WriteLine("");

// Array.Clear(pallets, 0, 2);
// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }
// using System.Collections.ObjectModel;

// string[] pallets =  ["B14", "A11", "B12", "A13" ];
// Console.WriteLine("");

// Array.Clear(pallets, 0, 2);
// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Array.Resize(ref pallets, 6);
// Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

// pallets[4] = "C01";
// pallets[5] = "C02";

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Array.Resize(ref pallets, 3);
// Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {

//     Console.WriteLine($"--{pallet}");
// }
// -----------------------------------------------------------
// string value = "abc123";
// char[] valueArray = value.ToCharArray();// a,b,c,1,2,3
// Array.Reverse(valueArray);//3,2,1,c,b,a
// string str = new string(valueArray);
// Console.WriteLine(str);//321cba

// string result = String.Join(",", valueArray);
// Console.WriteLine(result);

// string[] items = result.Split(',');

// foreach (string item  in items)
// {
//     Console.WriteLine(item);
// }

string pangram = "The quick brown fox jumps over the lazy dog";

string[] pangram2 = pangram.Split(' ');

string[] newpangram = new string[pangram2.Length];

for (int i = 0; i < pangram2.Length; i++)
{
    char[] c = pangram2[i].ToCharArray(); // the t,h,e

    Array.Reverse(c);    //e h t

    newpangram[i] = new string(c);
}

string result = String.Join(" ", newpangram);
Console.WriteLine(result);