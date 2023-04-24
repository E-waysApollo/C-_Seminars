Main();

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
            case "ex": IsWoring = false; break;
            default: break;
        }
    }
}

void task18()
{}