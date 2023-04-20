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
            case "15": task15(); break;
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

void task15()//Программа принимает на вход номер дня недели и определяет выходной он или нет
{
    bool WeekDay = false;
    while(!WeekDay)
    {
        int day = ReadNum("the day of the week");
        if(day < 6 && day > 0)
        {
            Console.WriteLine("It is a work day");
            WeekDay = true;
        }
        else if(day <= 7 && day > 0)
        {
            Console.WriteLine("It's a holyday!!!");
            WeekDay = true;
        }     
    }    
}