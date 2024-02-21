// conditional operator
// <evaluate this condition> ? <if condition is true, return this value> : <if condition is false, return this value>

int saleAmount = 1001;
int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {discount}");


Random HeadOrTail = new Random();

for (int i = 0; i < 10; i++)
{
    int headOrTail = HeadOrTail.Next(0, 2);

    string coinFlip = headOrTail == 0 ? "Head" : "Tail";

    Console.WriteLine(coinFlip);

}
