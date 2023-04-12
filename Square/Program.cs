Console.WriteLine("Tap number");

int a;
if (int.TryParse(Console.ReadLine(), out a))
{}
else
{
    Console.WriteLine("OOOOps");
}

Console.WriteLine("Tap its sqare");
int b;
if (int.TryParse(Console.ReadLine(), out b))
{}
else
{
    Console.WriteLine("OOOOps");
}

if (a*a == b)
{
    Console.WriteLine("You are right");
}
else
{
    Console.WriteLine("Wrong");
}
