//enter the number and console write all range from negative number to positive/ ex: enter 2; write: -2, -1, 0, 1, 2

Console.WriteLine("Enter the number");
int a;
if(int.TryParse(Console.ReadLine(), out a))
{}
else
{
  Console.WriteLine("Oooops");  
}

int n = a * -1;
Console.Write(n);
while( n < a)
{
    n++;
    Console.Write($", {n}");
}