//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Enter the number");
int num;
if(int.TryParse(Console.ReadLine(), out num));

else
{
    Console.WriteLine("Ooops");
}
int honest = num % 2;
if(honest == 0)
{
    Console.WriteLine("honest");
}
else
{
    Console.WriteLine("not honest");
}