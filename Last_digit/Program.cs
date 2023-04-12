//enter three-digit number. Programm should write the last digit

Console.WriteLine("Enter three-digit number");
int a;
if(int.TryParse(Console.ReadLine(), out a) && a < 1000 && a >= 100)
{
    int remainder = a % 10;
    Console.WriteLine(remainder);
}
else
{
    Console.WriteLine("Ooops");
}