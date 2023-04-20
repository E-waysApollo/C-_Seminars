Main();

int ReadNum(string number)
{
    int num;
    Console.WriteLine($"Input {number}");
    while(!int.TryParse(Console.ReadLine(), out num))
    {
        Console.WriteLine("It's not a number");
    }
    return num;
}

void Main()
{
    bool IsWork = true;
    while (IsWork)
    {
        Console.WriteLine("Enter the task");
        string enter = Console.ReadLine();  
        switch(enter)
        {
            case "t9": task9(); break;
            case "t11": task11(); break;
            case "t12": task12(); break;
            case "exit": IsWork = false; break;
            default: Console.WriteLine("There is no task"); break;
        }

    }
}

void task9() //Написать программу, которая выводит случайное число от 10 до 99 и показывает набольшую цифру числа: 78 - 8; 41 - 4
{
    int rand = new Random().Next(10, 99);
    Console.WriteLine($"Random number: {rand}");
    int digit1 = rand / 10;
    int digit2 = rand % 10;
    int result;
    if(digit1 >= digit2)result = digit1;
    else result = digit2;
    Console.WriteLine($"Max digit: {result}");
}

void task11()// Написать программу, которая выводит случайное 3-хзначное число и удаляет вторую цифру: 456 - 46

{
    int rand = new Random().Next(100, 999);
    Console.WriteLine($"Random number: {rand}");
    int result = (rand / 100)*10 + rand % 10;
    Console.WriteLine($"New number: {result}");
}

void task12()// Программа принимает на вход 2 простых числа и проверяет кратно ли первое число второму. Если нет, то выводит остаток от деления

{
    int num1 = ReadNum("dividend");
    int num2 = ReadNum("divider");
    int rest = num1 % num2;
    if(rest > 0)
    Console.WriteLine($"The rest is {rest}");
    else
    Console.WriteLine("Goood");
}