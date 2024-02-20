using System.Runtime.CompilerServices;

Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");
if(total > 10)
{
    Console.WriteLine("Great job, you got a lollipop");
}
else
{
    Console.WriteLine("You lost, you owe me a lollipop");
}