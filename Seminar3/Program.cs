Main();

int ReadNum(string argument)
{
    Console.WriteLine($"Input {argument}");
    int num;
    while(!int.TryParse(Console.ReadLine(), out num))
    {
        Console.WriteLine("It's not a number");   
    }
    return num;
}

void Main()
{
    bool IsWoring = true;
    while(IsWoring)
    {
        Console.WriteLine("Input task number");
        string taskNum = Console.ReadLine();
        switch (taskNum)
        {
            case "18": task18(); break;
            case "22": task22(); break;
            case "ex": IsWoring = false; break;
            default: break;
        }
    }
}

void task18()
{}

void task22()//Программа принимает на вход число и выдает таблицу квадратов чисел
{
    int quarterNum = ReadNum("length of quarter line");
    Console.WriteLine(QuarterString(quarterNum)); 
}

string QuarterString(int num)
{
    string qurterLine = "";
    for(int i = 1; i <= num; i++)
        qurterLine = qurterLine + $"{i*i}, ";
    return qurterLine;
}