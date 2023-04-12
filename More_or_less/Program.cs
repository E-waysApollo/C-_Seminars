//вводим два числа, находим меньшее, к меньшему прибавляем разницу между большим и меньшим столько раз, сколько равняется меньшее 
int a;
int b;
int big_number;
int small_number; 
int result;

Console.WriteLine("Enter the first number");
if(int.TryParse(Console.ReadLine(), out a))
{}
else
{
    Console.WriteLine("You should enter the number");
}

Console.WriteLine("Enter the second number");
if(int.TryParse(Console.ReadLine(), out b))
{}
else
{
    Console.WriteLine("You should enter the number");
}

if(a >= b)
{
    big_number = a;
    small_number = b;
}
else
{
    big_number = b;
    small_number = a;
}

int dif = big_number - small_number;
int i = 0;
result = small_number;
while( i < small_number)
{
    result = result + dif;
    i++;
}
Console.WriteLine(result);