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


using System;

int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0;


foreach (int number in numbers)
{
    total += number;

    if (number == 42)
    {
        Console.WriteLine("Set contains 42");

    }
}


Console.WriteLine($"Total: {total}");