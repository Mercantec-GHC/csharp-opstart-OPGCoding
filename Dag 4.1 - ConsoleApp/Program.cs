//Console.WriteLine("Signed integral types:");

//Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
//Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
//Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
//Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

//Console.WriteLine("");
//Console.WriteLine("Unsigned integral types:");

//Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
//Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
//Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
//Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");


//Console.WriteLine("");
//Console.WriteLine("Floating point types:");
//Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
//Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
//Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");




//int first = 2;
//string second = "4";
//int result = first + second;
//Console.WriteLine(result);



//string value = "102";
//int result = 0;
//if (int.TryParse(value, out result))
//{
//    Console.WriteLine($"Measurement: {result}");
//}
//else
//{
//    Console.WriteLine("Unable to report the measurement.");

//}
//if (result > 0)
//{
//    Console.WriteLine($"Measurement (w/ offset): {50 + result}");

//}


//string[] values = { "12.3", "45", "ABC", "11", "DEF" };

//decimal total = 0m;
//string message = "";

//foreach (var value in values)
//{
//    decimal number; // stores the TryParse "out" value
//    if (decimal.TryParse(value, out number))
//    {
//        total += number;
//    }
//    else
//    {
//        message += value;
//    }
//}

//Console.WriteLine($"Message: {message}");
//Console.WriteLine($"Total: {total}");

//int value1 = 12;
//decimal value2 = 6.2m;
//float value3 = 4.3f;

//int result1 = Convert.ToInt32((decimal)value1 / value2);
//decimal result2 = value2 / (decimal)value3;
//float result3 = value3 / value1;

//// Your code here to set result1
//// Hint: You need to round the result to nearest integer (don't just truncate)
//Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

//// Your code here to set result2
//Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

//// Your code here to set result3
//Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");


//string[] pallets = { "B14", "A11", "B12", "A13" };

//Console.WriteLine("Sorted...");
//Array.Sort(pallets);
//foreach (var pallet in pallets)
//{
//    Console.WriteLine($"-- {pallet}");
//}

//Console.WriteLine("");
//Console.WriteLine("Reversed...");
//Array.Reverse(pallets);
//foreach (var pallet in pallets)
//{
//    Console.WriteLine($"-- {pallet}");
//}


//string[] pallets = { "B14", "A11", "B12", "A13" };
//Console.WriteLine("");

//Console.WriteLine($"Before: {pallets[0].ToLower()}");
//Array.Clear(pallets, 0, 2);
//Console.WriteLine($"After: {pallets[0].ToLower()}");

//Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");

//foreach (var pallet in pallets)
//{
//    Console.WriteLine($"-- {pallet}");

//}



//string[] pallets = { "B14", "A11", "B12", "A13" };
//Console.WriteLine("");

//Array.Clear(pallets, 0, 2);
//Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
//foreach (var pallet in pallets)
//{
//    Console.WriteLine($"-- {pallet}");
//}

//Console.WriteLine("");
//Array.Resize(ref pallets, 6);
//Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

//pallets[4] = "C01";
//pallets[5] = "C02";

//foreach (var pallet in pallets)
//{
//    Console.WriteLine($"-- {pallet}");

//}

//Console.WriteLine("");
//Array.Resize(ref pallets, 3);
//Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

//foreach (var pallet in pallets)
//{
//    Console.WriteLine($"-- {pallet}");

//}


//string value = "abc123";
//char[] valueArray = value.ToCharArray();
//Array.Reverse(valueArray);
//// string result = new string(valueArray);
//string result = String.Join(",", valueArray);
//Console.WriteLine(result);

//string[] items = result.Split(',');
//foreach (string item in items)
//{
//    Console.WriteLine(item);
//}



//string pangram = "The quick brown fox jumps over the lazy dog";
//String[] pangramStringArray = pangram.Split(' ');

//for (int i = 0; i < pangramStringArray.Length; i++)
//{
//    char[] pangramLetter = pangramStringArray[i].ToCharArray();
//    Array.Reverse(pangramLetter);
//    pangramStringArray[i] = new string(pangramLetter);
//}

//string result = string.Join(" ", pangramStringArray);
//Console.WriteLine(result);


//string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
//string[] orderStreamArray = orderStream.Split(',');
//Array.Sort(orderStreamArray);


//foreach (string word in orderStreamArray)
//{
//    int charCount = word.Length;
//    if (charCount == 4)
//    {
//        Console.WriteLine($"{word}");
//    }
//    else
//    {
//        Console.WriteLine($"{word} -- error");
//    }

//}


//string first = "Hello";
//string second = "World";
//string result = string.Format("{0} {1}!", first, second);
//Console.WriteLine(result);

//string first = "Hello";
//string second = "World";
//Console.WriteLine("{1} {0}!", first, second);
//Console.WriteLine("{0} {1} {0}!", first, second);

//decimal price = 123.35m;
//int discount = 50;
//Console.WriteLine($"Price: {price:C} (Save {discount:C})");

//decimal measurement = 123456.78912345345324m;
//Console.WriteLine($"Measurement: {measurement:N9} units");


//decimal tax = .36785m;
//Console.WriteLine($"Tax rate: {tax:P2}");


//decimal price = 67.55m;
//decimal salePrice = 59.99m;

//string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

//yourDiscount += $"A discount of {((price - salePrice) / price):P2}!"; //inserted
//Console.WriteLine(yourDiscount);


//int invoiceNumber = 1201;
//decimal productShares = 25.4568m;
//decimal subtotal = 2750.00m;
//decimal taxPercentage = .15825m;
//decimal total = 3185.19m;

//Console.WriteLine($"Invoice Number: {invoiceNumber}");
//Console.WriteLine($"\tShares: {productShares:N3} Product");
//Console.WriteLine($"\t\tSub Total: {subtotal:C}");
//Console.WriteLine($"\t\t\tTax: {taxPercentage:P2}");
//Console.WriteLine($"\t\tTotal Billed: {total:C}");

string input = "Pad this";
Console.WriteLine(input.PadLeft(10, '-'));
Console.WriteLine(input.PadLeft(24, '-'));
Console.WriteLine(input.PadRight(12, '.'));

string paymentId = "769C";
string payeeName = "Mr. Stephen Ortega";
string paymentAmount = "$5,000.00";

var formattedLine = paymentId.PadRight(6);
formattedLine += payeeName.PadRight(24);
formattedLine += paymentAmount.PadLeft(10);

Console.WriteLine(formattedLine);





