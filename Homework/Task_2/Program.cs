//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

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

if(num1 >= num2)
{
    Console.WriteLine($"max number = {num1}");
    Console.WriteLine($"min numebr = {num2}");
}
else
{
    Console.WriteLine($"max number = {num2}");
    Console.WriteLine($"min number = {num1}");
}