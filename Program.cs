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

// string pangram = "The quick brown fox jumps over the lazy dog";

// string[] pangram2 = pangram.Split(' ');

// string[] newpangram = new string[pangram2.Length];

// for (int i = 0; i < pangram2.Length; i++)
// {
//     char[] c = pangram2[i].ToCharArray(); // the t,h,e

//     Array.Reverse(c);    //e h t

//     newpangram[i] = new string(c);
// }

// string result = String.Join(" ", newpangram);
// Console.WriteLine(result);


// string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

// string[] orderStream2 = orderStream.Split(',');

// Array.Sort(orderStream2);

// // string[] newmessage = new string[orderStream2.Length];

// for (int i = 0; i < orderStream2.Length; i++)
// {
//     char[] c = orderStream2[i].ToCharArray();

//     if (c.Length == 4)
//     {
//         string message = new string(c);
//         Console.WriteLine(message);
//     }
//     else
//     {
//         string message = new string(c);
//         Console.WriteLine($"{message}    -Error");
//     }
// }


// decimal price = 67.55m;
// decimal salePrice = 59.99m;

// string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

// yourDiscount += $"A discount of {((price - salePrice)/price):P2}!"; //inserted
// Console.WriteLine(yourDiscount);


// string paymentId = "7692wwC";
//  string payeeName = "Mr. Stephen Ortega";

//  var formattedLine = paymentId.PadRight(6);
//  formattedLine += payeeName.PadRight(24);

//  Console.WriteLine(formattedLine);
//  Console.WriteLine(formattedLine.Length);
// using System.Security.Cryptography;

// string customerName = "Ms. Barros";

// string currentProduct = "Magic Yield";
// int currentShares = 2975000;
// decimal currentReturn = 0.1275m;
// decimal currentProfit = 55000000.0m;

// string newProduct = "Glorious Future";
// decimal newReturn = 0.13125m;
// decimal newProfit = 63000000.0m;

// Console.WriteLine($"Dear {customerName},");
// Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
// Console.WriteLine($"Currently, you own {currentShares:N2} shares at a return of {currentReturn:P2}.\n");
// Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P2}.  Given your current volume, your potential profit would be {newProfit:c}.\n");

// Console.WriteLine("Here's a quick comparison:\n");

// string comparisonMessage = currentProduct.PadRight(20);
// comparisonMessage += String.Format("{0:P2}", currentReturn).PadRight(10);
// comparisonMessage += String.Format("{0:c}", currentProfit).PadRight(20);
// comparisonMessage += "\n";
// comparisonMessage += newProduct.PadRight(20);
// comparisonMessage += String.Format("{0:P2}", newReturn).PadRight(10);
// comparisonMessage += String.Format("{0:c}", newProfit).PadRight(20);
// // Your logic here

// Console.WriteLine(comparisonMessage);


// // Dear Ms. Barros,
// // As a customer of our Magic Yield offering we are excited to tell you about a new financial product that would dramatically increase your return.

// // Currently, you own 2,975,000.00 shares at a return of 12.75%.

// // Our new product, Glorious Future offers a return of 13.13%.  Given your current volume, your potential profit would be $63,000,000.00.

// // Here's a quick comparison:

// // Magic Yield         12.75%   $55,000,000.00      
// // Glorious Future     13.13%   $63,000,000.00  

// string message = "(What if) there are (more than) one (set of parentheses)?";

// while (true)
// {
//     int open = message.IndexOf('(');
//     if (open == -1) break;

//     open += 1;

//     int close = message.IndexOf(')');

//     int Length = close - open;

//     Console.WriteLine(message.Substring(open, Length));

//     message = message.Substring(close + 1);
// }


// string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

// // The IndexOfAny() helper method requires a char array of characters. 
// // You want to look for:

// char[] openSymbols = ['[', '{', '('];

// // You'll use a slightly different technique for iterating through 
// // the characters in the string. This time, use the closing 
// // position of the previous iteration as the starting index for the 
// //next open symbol. So, you need to initialize the closingPosition 
// // variable to zero:

// int closingPosition = 0;

// while (true)
// {
//     int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

//     if (openingPosition == -1) break;

//     string currentSymbol = message.Substring(openingPosition, 1);

//     // Now  find the matching closing symbol
//     char matchingSymbol = ' ';

//     switch (currentSymbol)
//     {
//         case "[":
//             matchingSymbol = ']';
//             break;
//         case "{":
//             matchingSymbol = '}';
//             break;
//         case "(":
//             matchingSymbol = ')';
//             break;
//     }

//     // To find the closingPosition, use an overload of the IndexOf method to specify 
//     // that the search for the matchingSymbol should start at the openingPosition in the string. 

//     openingPosition += 1;
//     closingPosition = message.IndexOf(matchingSymbol, openingPosition);

//     // Finally, use the techniques you've already learned to display the sub-string:

//     int length = closingPosition - openingPosition;
//     Console.WriteLine(message.Substring(openingPosition, length));
// }

// string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";
// char[] openSymbols = ['{', '(', '['];

// int closingPosition = 0;

// while (true)
// {
//     int openingPosition = message.IndexOfAny(openSymbols, closingPosition);
//     if (openingPosition == -1) break;

//     string currentSymbol = message.Substring(openingPosition, 1);//(openingPosition,(n-1))

//     string matchingSymbol = "";

//     switch (currentSymbol)
//     {
//         case "(":
//             matchingSymbol = ")";
//             break;
//         case "{":
//             matchingSymbol = "}";
//             break;
//         case "[":
//             matchingSymbol = "]";
//             break;
//     }

//     openingPosition += 1;

//     closingPosition = message.IndexOf(matchingSymbol, openingPosition);

//     int length = closingPosition - openingPosition;


//     Console.WriteLine(message.Substring(openingPosition, length));
// }

// string data = "12345John Smith12345678905000  3  ";
// string updatedData = data.Remove(5, 20);
// Console.WriteLine(updatedData);


// string message = "This--is--ex-amp-le--da-ta"; 
// message = message.Replace("--", " "); Console.WriteLine(message);// This is ex-amp-le da-ta 
// message = message.Replace("-", "");Console.WriteLine(message); //this is example data
// Console.WriteLine(message);

// const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

// string quantity = "";
// string output = "";

// // Your work here

// int span = input.IndexOf("<span>");
// int spanEnd = input.IndexOf("</span>");

// Console.WriteLine(span);
// Console.WriteLine(spanEnd);

// Console.WriteLine(quantity);
// Console.WriteLine(output);


///////////////////////////////////////////////////////////////////////////////////Project////////////////////////////////////////////////////

// Final

// ourAnimals array will store the following: 
// string animalSpecies = "";
// string animalID = "";
// string animalAge = "";
// string animalPhysicalDescription = "";
// string animalPersonalityDescription = "";
// string animalNickname = "";
// string suggestedDonation = "";

// // variables that support data entry
// int maxPets = 8;
// string? readResult;
// string menuSelection = "";
// decimal decimalDonation = 0.00m;

// // array used to store runtime data
// string[,] ourAnimals = new string[maxPets, 7];

// // sample data ourAnimals array entries
// for (int i = 0; i < maxPets; i++)
// {
//     switch (i)
//     {
//         case 0:
//             animalSpecies = "dog";
//             animalID = "d1";
//             animalAge = "2";
//             animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 45 pounds. housebroken.";
//             animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
//             animalNickname = "lola";
//             suggestedDonation = "85.00";
//             break;

//         case 1:
//             animalSpecies = "dog";
//             animalID = "d2";
//             animalAge = "9";
//             animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
//             animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
//             animalNickname = "gus";
//             suggestedDonation = "49.99";
//             break;

//         case 2:
//             animalSpecies = "cat";
//             animalID = "c3";
//             animalAge = "1";
//             animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
//             animalPersonalityDescription = "friendly";
//             animalNickname = "snow";
//             suggestedDonation = "40.00";
//             break;

//         case 3:
//             animalSpecies = "cat";
//             animalID = "c4";
//             animalAge = "";
//             animalPhysicalDescription = "";
//             animalPersonalityDescription = "";
//             animalNickname = "lion";
//             suggestedDonation = "";

//             break;

//         default:
//             animalSpecies = "";
//             animalID = "";
//             animalAge = "";
//             animalPhysicalDescription = "";
//             animalPersonalityDescription = "";
//             animalNickname = "";
//             suggestedDonation = "";
//             break;
//     }

//     ourAnimals[i, 0] = "ID #: " + animalID;
//     ourAnimals[i, 1] = "Species: " + animalSpecies;
//     ourAnimals[i, 2] = "Age: " + animalAge;
//     ourAnimals[i, 3] = "Nickname: " + animalNickname;
//     ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
//     ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;

//     if (!decimal.TryParse(suggestedDonation, out decimalDonation))
//     {
//         decimalDonation = 45.00m; // if suggestedDonation NOT a number, default to 45.00
//     }
//     ourAnimals[i, 6] = $"Suggested Donation: {decimalDonation:C2}";
// }

// // top-level menu options
// do
// {
//     // NOTE: the Console.Clear method is throwing an exception in debug sessions
//     Console.Clear();

//     Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
//     Console.WriteLine(" 1. List all of our current pet information");
//     Console.WriteLine(" 2. Display all dogs with a specified characteristic");
//     Console.WriteLine();
//     Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

//     readResult = Console.ReadLine();

//     if (readResult != null)
//     {
//         menuSelection = readResult.ToLower();
//     }

//     // switch-case to process the selected menu option
//     switch (menuSelection)
//     {
//         case "1":
//             // list all pet info
//             for (int i = 0; i < maxPets; i++)
//             {
//                 if (ourAnimals[i, 0] != "ID #: ")
//                 {
//                     Console.WriteLine();

//                     for (int j = 0; j < 7; j++)
//                     {
//                         Console.WriteLine(ourAnimals[i, j].ToString());
//                     }
//                 }
//             }

//             Console.WriteLine("\r\nPress the Enter key to continue");
//             readResult = Console.ReadLine();

//             break;

//         case "2":
//             // #1 Display all dogs with a multiple search characteristics

//             string dogCharacteristics = "";

//             while (dogCharacteristics == "")
//             {
//                 // #2 have user enter multiple comma separated characteristics to search for
//                 Console.WriteLine($"\nEnter dog characteristics to search for separated by commas");
//                 readResult = Console.ReadLine();

//                 if (readResult != null)
//                 {
//                     dogCharacteristics = readResult.ToLower();
//                     Console.WriteLine();
//                 }
//             }

//             string[] dogSearches = dogCharacteristics.Split(",");
//             // trim leading and trailing spaces from each search term
//             for (int i = 0; i < dogSearches.Length; i++)
//             {
//                 dogSearches[i] = dogSearches[i].Trim();
//             }

//             Array.Sort(dogSearches);
//             // #4 update to "rotating" animation with countdown
//             string[] searchingIcons = {" |", " /", "--", " \\", " *"};

//             bool matchesAnyDog = false;
//             string dogDescription = "";

//             // loops through the ourAnimals array to search for matching animals
//             for (int i = 0; i < maxPets; i++)
//             {
//                 if (ourAnimals[i, 1].Contains("dog"))
//                 {

//                     // Search combined descriptions and report results
//                     dogDescription = ourAnimals[i, 4] + "\n" + ourAnimals[i, 5];
//                     bool matchesCurrentDog = false;

//                     foreach (string term in dogSearches)
//                     {
//                         // only search if there is a term to search for
//                         if (term != null && term.Trim() != "")
//                         {
//                             for (int j = 2; j > -1 ; j--)
//                             {
//                                 // #5 update "searching" message to show countdown
//                                 foreach (string icon in searchingIcons)
//                                 {
//                                     Console.Write($"\rsearching our dog {ourAnimals[i, 3]} for {term.Trim()} {icon} {j.ToString()}");
//                                     Thread.Sleep(100);
//                                 }

//                                 Console.Write($"\r{new String(' ', Console.BufferWidth)}");
//                             }

//                             // #3a iterate submitted characteristic terms and search description for each term
//                             if (dogDescription.Contains(" " + term.Trim() + " "))
//                             {
//                                 // #3b update message to reflect current search term match 

//                                 Console.WriteLine($"\rOur dog {ourAnimals[i, 3]} matches your search for {term.Trim()}");

//                                 matchesCurrentDog = true;
//                                 matchesAnyDog = true;
//                             }
//                         }
//                     }

//                     // #3d if the current dog is match, display the dog's info
//                     if (matchesCurrentDog)
//                     {
//                         Console.WriteLine($"\r{ourAnimals[i, 3]} ({ourAnimals[i, 0]})\n{dogDescription}\n");
//                     }
//                 }
//             }

//             if (!matchesAnyDog)
//             {
//                 Console.WriteLine("None of our dogs are a match found for: " + dogCharacteristics);
//             }

//             Console.WriteLine("\n\rPress the Enter key to continue");
//             readResult = Console.ReadLine();

//             break;

//         default:
//             break;
//     }
// } 
// while (menuSelection != "exit");

// string ipv4Input = "107.31.1.5";
// bool validLength = false;
// bool validZeroes = false;
// bool validRange = false;

// ValidateLength(); 
// ValidateZeroes(); 
// ValidateRange();

// if (validLength && validZeroes && validRange) 
// {
//     Console.WriteLine($"ip is a valid IPv4 address");
// } 
// else
// {
//     Console.WriteLine($"ip is an invalid IPv4 address");
// }

// void ValidateLength()
// {
//     string[] str = ipv4Input.Split(".");
//     if (str.Length == 4)
//     {
//         validLength = true;
//     }
// }

// void ValidateZeroes()
// {
//     string[] str = ipv4Input.Split(".");
//     foreach (string str2 in str)
//     {
//         if (str2.Length > 1 && str2.StartsWith("0"))
//         {
//             validZeroes = false;
//         }
//     }
//     validZeroes = true;

// }

// void ValidateRange()
// {
//     string[] str = ipv4Input.Split(".");
//     foreach (string str2 in str)
//     {
//         int num = int.Parse(str2);
//         if (num < 0 || num > 255)
//         {
//             validRange = false;
//         }
//     }
//     validRange = true;
// }


// Random random = new Random();
// int luck = random.Next(100);

// string[] text = {"You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to"};
// string[] good = {"look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!"};
// string[] bad = {"fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life."};
// string[] neutral = {"appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature."};

// Console.WriteLine("A fortune teller whispers the following words:");
// string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
// for (int i = 0; i < 4; i++) 
// {
//     Console.Write($"{text[i]} {fortune[i]} ");
// }
// string[,] corporate = 
// {
//     {"Robert", "Bavin"},
//     { "Simon", "Bright"},
//     {"Kim", "Sinclair"},
//     { "Aashrita", "Kamath"},
//     {"Sarah", "Delucchi"},
//     { "Sinan", "Ali"}
// };

// string[,] external = 
// {
//     {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
//     {"Shay", "Lawrence"}, {"Daren", "Valdes"}
// };

// string externalDomain = "hayworth.com";

// for (int i = 0; i < corporate.GetLength(0); i++)
// {
//     DisplayEmail(first: corporate[i, 0], secound: corporate[i, 1]);  
// }

// for (int i = 0; i < external.GetLength(0); i++)
// {
//    DisplayEmail(first: external[i, 0], secound: external[i, 1]);  
// }

// void DisplayEmail(string first, string secound)
// {
//     string message = first.Substring(0, 2) + secound;
//     message += $"@" + externalDomain;
//     Console.WriteLine(message);

// }

// string ReverseSentence(string input)
// {
//     string result = "";
//     string[] words = input.Split(" ");

//     foreach (string word in words)
//     {
//         result += ReverseWord(word) + " ";
//     }

//     return result.Trim();
// }
// string ReverseWord(string word) 
// {
//     string result = "";
//     for (int i = word.Length - 1; i >= 0; i--) 
//     {
//         result += word[i];
//     }
//     return result;
// }

// string input = "there are snakes at the zoo";

// Console.WriteLine(input);
// Console.WriteLine(ReverseSentence(input));

// int[,] TwoCoins(int[] coins, int target)
// {
//     int[,] result = { { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 } };
//     int count = 0;

//     for (int curr = 0; curr < coins.Length; curr++)
//     {
//         for (int next = curr + 1; next < coins.Length; next++)
//         {
//             if (coins[curr] + coins[next] == target)
//             {
//                 result[count, 0] = curr;
//                 result[count, 1] = next;
//                 count++;
//             }
//             if (count == result.GetLength(0))
//             {
//                 return result;
//                 }
//             }
//         }

//         return (count == 0) ? new int[0, 0] : result;

//     }

//     int target = 80;
//     int[] coins = new int[] {5, 5, 50, 25, 25, 10, 5};
//     int[,] result = TwoCoins(coins, target);


//     if (result.Length == 0)
//     {
//         Console.WriteLine("No two coins make change");
//     }
//     else
//     {
//         Console.WriteLine("Change found at positions:");
//         for (int i = 0; i < result.GetLength(0); i++)
//         {
//             if (result[i, 0] == -1)
//             {
//                 break;
//             }
//             Console.WriteLine($"{result[i, 0]},{result[i, 1]}");
//         }
//     }

// ShouldPlay //method
// WinOrLose  //method

// target: The random target number between 1 and 5  //varib    les
// roll

// using Microsoft.CSharp.RuntimeBinder;

// Random random = new Random();

// Console.WriteLine("Would you like to play? (Y/N)");
// if (ShouldPlay()) 
// {
//     PlayGame();
// }

// void PlayGame()
// {
//     var play = true;

//     while (play)
//     {
//         var target = random.Next(1, 6);
//         var roll = random.Next(1, 6);

//         Console.WriteLine($"Roll a number greater than {target} to win!");
//         Console.WriteLine($"You rolled a {roll}");
//         Console.WriteLine(WinOrLose(target , roll));
//         Console.WriteLine("\nPlay again? (Y/N)");

//         play = ShouldPlay();
//     }
// }


// bool ShouldPlay()
// {
//     // Console.WriteLine("do you want to play  the game again ? (y/n)");
//     string result = Console.ReadLine();
//     if (result.ToLower() == "y" || result.ToLower() == "n")
//     {
//         return result.ToLower() == "y" ? true : false;
//     }

//     return false;
// }

// string WinOrLose(int target, int roll)
// {
//     if (target < roll)
//     {
//         return "You win!";
//     }
//     else
//     {
//         return "you lose!";
//     }

// using System;

// string[] pettingZoo = 
// {
//     "alpacas", "capybaras", "chickens", "ducks", "emus", "geese", 
//     "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws", 
//     "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
// };

// PlanSchoolVisit("School A");
// PlanSchoolVisit("School B", 3);
// PlanSchoolVisit("School C", 2);

// void PlanSchoolVisit(string schoolName, int groups = 6) 
// {
//     RandomizeAnimals(); 
//     string[,] group = AssignGroup(groups);
//     Console.WriteLine(schoolName);
//     PrintGroup(group);
// }

// void RandomizeAnimals() 
// {
//     Random random = new Random();

//     for (int i = 0; i < pettingZoo.Length; i++) 
//     {
//         int r = random.Next(i, pettingZoo.Length);

//         string temp = pettingZoo[r];
//         pettingZoo[r] = pettingZoo[i];
//         pettingZoo[i] = temp;
//     }
// }

// string[,] AssignGroup(int groups = 6) 
// {
//     string[,] result = new string[groups, pettingZoo.Length/groups];
//     int start = 0;

//     for (int i = 0; i < groups; i++) 
//     {
//         for (int j = 0; j < result.GetLength(1); j++) 
//         {
//             result[i,j] = pettingZoo[start++];
//         }
//     }

//     return result;
// }

// void PrintGroup(string[,] groups) 
// {
//     for (int i = 0; i < groups.GetLength(0); i++) 
//     {
//         Console.Write($"Group {i + 1}: ");
//         for (int j = 0; j < groups.GetLength(1); j++) 
//         {
//             Console.Write($"{groups[i,j]}  ");
//         }
//         Console.WriteLine();
//     }
// }



// --------------------------------------------------------------------project-----------------------------------------------------------------------------------------------------------------------------------------------------------------




// using System;

// Random random = new Random();
// Console.CursorVisible = false;
// int height = Console.WindowHeight - 1;
// int width = Console.WindowWidth - 5;
// bool shouldExit = false;

// // Console position of the player
// int playerX = 0;
// int playerY = 0;

// // Console position of the food
// int foodX = 0;
// int foodY = 0;

// // Available player and food strings
// string[] states = {"('-')", "(^-^)", "(X_X)"};
// string[] foods = {"@@@@@", "$$$$$", "#####"};

// // Current player string displayed in the Console
// string player = states[0];

// // Index of the current food
// int food = 0;

// InitializeGame();
// while (!shouldExit) 
// {
//     Move();
// }

// // Returns true if the Terminal was resized 
// bool TerminalResized() 
// {
//     return height != Console.WindowHeight - 1 || width != Console.WindowWidth - 5;
// }

// // Displays random food at a random location
// void ShowFood() 
// {
//     // Update food to a random index
//     food = random.Next(0, foods.Length);

//     // Update food position to a random location
//     foodX = random.Next(0, width - player.Length);
//     foodY = random.Next(0, height - 1);

//     // Display the food at the location
//     Console.SetCursorPosition(foodX, foodY);
//     Console.Write(foods[food]);
// }

// // Changes the player to match the food consumed
// void ChangePlayer() 
// {
//     player = states[food];
//     Console.SetCursorPosition(playerX, playerY);
//     Console.Write(player);
// }

// // Temporarily stops the player from moving
// void FreezePlayer() 
// {
//     System.Threading.Thread.Sleep(1000);
//     player = states[0];
// }

// // Reads directional input from the Console and moves the player
// void Move() 
// {
//     int lastX = playerX;
//     int lastY = playerY;

//     switch (Console.ReadKey(true).Key) 
//     {
//         case ConsoleKey.UpArrow:
//             playerY--; 
//             break;
// 		case ConsoleKey.DownArrow: 
//             playerY++; 
//             break;
// 		case ConsoleKey.LeftArrow:  
//             playerX--; 
//             break;
// 		case ConsoleKey.RightArrow: 
//             playerX++; 
//             break;
// 		case ConsoleKey.Escape:     
//             shouldExit = true; 
//             break;
//     }

//     // Clear the characters at the previous position
//     Console.SetCursorPosition(lastX, lastY);
//     for (int i = 0; i < player.Length; i++) 
//     {
//         Console.Write(" ");
//     }

//     // Keep player position within the bounds of the Terminal window
//     playerX = (playerX < 0) ? 0 : (playerX >= width ? width : playerX);
//     playerY = (playerY < 0) ? 0 : (playerY >= height ? height : playerY);

//     // Draw the player at the new location
//     Console.SetCursorPosition(playerX, playerY);
//     Console.Write(player);
// }

// // Clears the console, displays the food and player
// void InitializeGame() 
// {
//     Console.Clear();
//     ShowFood();
//     Console.SetCursorPosition(0, 0);
//     Console.Write(player);
// }



// -------------------------------------------------------------------debugging-----------------------------------------------------------------------------------------------------------------------------------------------------------------
/* 
This code uses a names array and corresponding methods to display
greeting messages
*/
/*  
// This code instantiates a value and then calls the ChangeValue method
// to update the value. The code then prints the updated value to the console.
// */
// try
// {
//     // Step 1: code execution begins
//     try
//     {
//         // Step 2: an exception occurs here
//     }
//     finally
//     {
//         // Step 4: the system executes the finally code block associated with the try statement where the exception occurred
//     }

// }
// catch // Step 3: the system finds a catch clause that can handle the exception
// {   
//    // Step 5: the system transfers control to the first line of the catch code block
// }

// inputValues is used to store numeric values entered by a user
checked
{
    try
    {
        int num1 = int.MaxValue;
        int num2 = int.MaxValue;
        int result = num1 + num2;
        Console.WriteLine("Result: " + result);
    }
    catch (OverflowException ex)
    {
        Console.WriteLine("Error: The number is too large to be represented as an integer." + ex.Message);
    }
}
try
{
    string str = null;
    int length = str.Length;
    Console.WriteLine("String Length: " + length);
}
catch (NullReferenceException ex)
{
    Console.WriteLine("Error: The reference is null." + ex.Message);
}
try
{
    int[] numbers = new int[5];
    numbers[5] = 10;
    Console.WriteLine("Number at index 5: " + numbers[5]);
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine("Error: Index out of range." + ex.Message);
}
try
{
    int num3 = 10;
    int num4 = 0;
    int result2 = num3 / num4;
    Console.WriteLine("Result: " + result2);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Error: Cannot divide by zero." + ex.Message);
}





Console.WriteLine("Exiting program.");