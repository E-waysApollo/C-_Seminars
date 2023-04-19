//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Enter first number");
int num1;
if(int.TryParse(Console.ReadLine(), out num1))
{}
else
{
    Console.WriteLine("Ooops");
}

Console.WriteLine("Enter second number");
int num2;
if(int.TryParse(Console.ReadLine(), out num2))
{}
else
{
    Console.WriteLine("OOOps");    
}

Console.WriteLine("Enter third number");
int num3;
if(int.TryParse(Console.ReadLine(), out num3));

else
{
    Console.WriteLine("Oooops");
}

int max;
if(num1 >= num2)    
max = num1;
else
{
    max = num2;
}


if(num3 > max)
max = num3;

Console.WriteLine($"max number is {max}");