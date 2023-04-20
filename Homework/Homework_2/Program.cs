Main();

int ReadNum(string argument)
{
    Console.WriteLine($"Input {argument}");
    int num;
    while (!int.TryParse(Console.ReadLine(), out num))
        Console.WriteLine("It's not a number");
    return num;
}

void Main()
{
    bool IsWorking = true;
    while (IsWorking)
    {
        Console.WriteLine("Input task number");
        string task = Console.ReadLine();
        switch (task)
        {
            case "10": task10(); break;
            case "13": task13(); break;
            case "ex": IsWorking = false; break;
            default: break;
        }
    }
}

void task10()//Приграмма принимает на вход 3-х значное число и показывает 2-ю цифру числа
{
    bool ThreeDigit = false;
    while (!ThreeDigit)
    {
        int num = ReadNum("three digit number");
        if (num / 100 > 0 && num / 100 < 10)
        {
        num = (num - (num / 100 * 100) - (num % 10))/10;
        Console.WriteLine($"Number is {num}");
        ThreeDigit = true;
        }
    }
}

void task13()//Программа должна выводить 3-ю цифру числа. Если ее нет, писать, что нет
{
    int num = ReadNum("the number");
    if(num - 100 >= 0)
    {
        while(num >= 1000)
        {
            num = num / 10;
        }
        num = num % 10;
        Console.WriteLine($"Third number is {num}");
    }
    else
    Console.WriteLine("There is no third number");
}