//// string permission = "Manager";
//string permission = "Admin";
//int level = 55;

//if (permission.Contains("Admin") && level > 55)
//{
//    Console.WriteLine("Welcome, Super Admin user.");
//}
//else if (permission.Contains("Admin") && level <= 55)
//{
//    Console.WriteLine("Welcome, Admin user.");
//}
//else if (permission.Contains("Manager") && level >= 20)
//{
//    Console.WriteLine("Contact an Admin for access.");
//}
//else if (permission.Contains("Manager") && level < 20)
//{
//    Console.WriteLine("You do not have sufficient privileges.");
//}
//else
//{
//    Console.WriteLine("You do not have sufficient privileges.");
//}



//bool flag = true;
//int value = 10;

//if (flag)
//{
//    Console.WriteLine($"Inside the code block: {value}");
//}
//Console.WriteLine($"Outside the code block: {value}");


//using System;

//int[] numbers = { 4, 8, 15, 16, 23, 42 };
//int total = 0;


//foreach (int number in numbers)
//{
//    total += number;

//    if (number == 42)
//    {
//        Console.WriteLine("Set contains 42");

//    }
//}


//Console.WriteLine($"Total: {total}");

// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
//string sku = "01-MN-L";

//string[] product = sku.Split('-');

//string type = "";
//string color = "";
//string size = "";

//switch (product[0])
//{
//    case "01":
//        type = "Sweat shirt";
//        break;
//    case "02":
//        type = "T-Shirt";
//        break;
//    case "03":
//        type = "Sweat pants";
//        break;
//    default:
//        type = "other";
//        break;
//}

//switch (product[1])
//{
//    case "BL":
//        color = "Black";
//        break;
//    case "MN":
//        color = "Maroon";
//        break;
//    default:
//        color = "White";
//        break;
//}

//switch (product[2])
//{
//    case "S":
//        size = "Small";
//        break;
//    case "M":
//        size = "Medium";
//        break;
//    case "L":
//        size = "Large";
//        break;
//    default:
//        size = "One Size Fits All";
//        break;
//}
//Console.WriteLine($"Product: {size} {color} {type}");


//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine(i);
//}

//for (int i = 10; i >= 0; i--)
//{
//    Console.WriteLine(i);
//}

//for (int i = 0; i < 10; i += 3)
//{
//    Console.WriteLine(i);
//}

//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine(i);
//    if (i == 7) break;
//}

//for (int i = 1; i < 101; i++)
//{
//    if((i % 3 == 0) && (i % 5 == 0))
//    {
//        Console.WriteLine($"{i} - FizzBuzz");
//    }
//    else if (i % 3 == 0)
//    {
//        Console.WriteLine($"{i} - Fizz");
//    }
//    else if (i % 5 == 0)
//    {
//        Console.WriteLine($"{i} - Buzz");
//    }
//    else
//    {
//        Console.WriteLine($"{i}");
//    }
//}

//Random random = new Random();
//int prut = 1;

//// Do gør at du bliver ved med at prutte indtil du har 7 slået 7 prutter som (Vores while loop fortæller os)
//do
//{
//    Console.WriteLine($"Prut: {prut}");
//    prut++;
//} while (prut != 7);
//Console.WriteLine($"Sidste prut: {prut}");


//do
//{
//    prut = random.Next(1, 11);

//    if (prut >= 8) continue;

//    Console.WriteLine($"Prut: {prut}");
//} while (prut != 7);

//while (prut >= 3)
//{
//    Console.WriteLine(prut);
//    prut = random.Next(1, 11);
//}
//Console.WriteLine($"Last number: {prut}");
//*/



//int heroHealth = 10;
//int monsterHealth = 10;

//do
//{
//    Random MonterRandomAttackDamage = new Random();
//    int monsterAttackDamage = MonterRandomAttackDamage.Next(1, 11);

//    monsterHealth = monsterHealth - monsterAttackDamage;
//    Console.WriteLine($"Monster was damaged and lost {monsterAttackDamage} health and now has {monsterHealth} health.\r\n");

//    Random heroRandomAttackDamage = new Random();
//    int heroAttackDamage = heroRandomAttackDamage.Next(1, 11);

//    heroHealth = heroHealth - heroAttackDamage;
//    Console.WriteLine($"Hero was damaged and lost {heroAttackDamage} health and now has {heroHealth} health.\r\n");

//}
//while (monsterHealth > 0 || heroHealth > 0);

//if (monsterHealth <= 0)
//{
//    Console.WriteLine("Monster won!");
//}
//else if (heroHealth <= 0)
//{
//    Console.WriteLine("Hero won!");
//}


//using System;

//int userInput;
//bool isValid = false;

//do
//{
//    Console.WriteLine("Indtast et heltal:");

//    string input = Console.ReadLine();
//    isValid = int.TryParse(input, out userInput);


//    if (!isValid)
//    {
//    Console.WriteLine("Ugyldigt input. Prøv igen.");
//    }

//} 
//while (!isValid);

//Console.WriteLine("Du har indtastet: " + userInput);


//using System;

//int userInput;
//bool isValid = false;

string userInput;
bool isValidInput = false;

Console.WriteLine("Indtast en rolle (Administrator, Manager eller User):");

do
{
    userInput = Console.ReadLine()?.Trim().ToLower();

    if (userInput == "administrator" || userInput == "manager" || userInput == "user")
    {
        isValidInput = true;
    }
    else
    {
        Console.WriteLine("Dit input er ikke en gyldig rolle. Prøv igen.");
    }

} while (!isValidInput);

Console.WriteLine($"Dit input ({userInput}) er blevet accepteret.");
