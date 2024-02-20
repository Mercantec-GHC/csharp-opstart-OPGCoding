using System.Runtime.CompilerServices;

Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples! +6 bonus to total!");
        total += 6;
    }

    Console.WriteLine("You rolled doubles! +2 bonus to total!");
    total += 2;
}

if (total >= 16)
{
    Console.WriteLine("You won a lollipop");
}
else if (total >= 13)
{
    Console.WriteLine("You won a peace of cake");
}
else if (total == 10)
{
    Console.WriteLine("You just won a 1.000.000 air particles");
}
else
{
    Console.WriteLine("You won something borring\n");
}



Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

Console.WriteLine("\n");

if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration <= 1)
{
    discountPercentage = 20;
    Console.WriteLine($@"Your subscription expires within a day!
Renew now and save {discountPercentage}%!");
}
else if (daysUntilExpiration <= 5)
{
    discountPercentage = 10;
    Console.WriteLine(@$"Your subscription expires in {daysUntilExpiration}.
Renew now and save {discountPercentage}%!");
}

else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}

