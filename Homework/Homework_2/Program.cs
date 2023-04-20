int ReadNum(string argument)
{
    Console.WriteLine($"Input the {argument}");
    int num;
    while(!int.TryParse(Console.ReadLine(), out num))
    Console.WriteLine("It's not a number");
    return num;
}

void Main()
{
    bool IsWorking = true;
    while(IsWorking)
    {
        Console.WriteLine("Input task number");
        string task = Console.ReadLine;
        switch(task)
        {
            case "10": task10(); break;
            case "ex": IsWorking = false; break;
            default: break;
        }
    }
}