int a = 0;

Console.WriteLine("Tap day of the week");
if(int.TryParse(Console.ReadLine(), out a))
{
    if(a > 7)
    {
        Console.WriteLine("Tap number less then 7");
    }
    else if(a == 1)
    {
        Console.WriteLine("Monday");
    }
    else if(a == 2)
    {
        Console.WriteLine("Tuesday");
    }
    else if(a == 3)
    {
        Console.WriteLine("Wensday");
    }
    else if(a == 4)
    {
        Console.WriteLine("Thursday");
    }
    else if(a == 5)
    {
        Console.WriteLine("Friday");
    }
    else if(a == 6)
    {
        Console.WriteLine("Saturday");
    }
    else if(a == 7)
    {
        Console.WriteLine("Sunday");
    }
}
else
{
    Console.WriteLine("Tap number less then 7");
}