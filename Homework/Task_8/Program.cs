//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Enter the number");
int num;
if(int.TryParse(Console.ReadLine(), out num));

else
{
    Console.WriteLine("Ooops");
}

int i = 2;
while (i <= num)
{
    Console.WriteLine(i);
    i=i+2;
}