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
            case "ex": IsWoring = false; break;
            default: break;
        }
    }
}

void task18()// рограмма по заданной четверти возвращает диапазон координат X,Y
{
    bool writeQurter = true;
    int quarter;
    while(writeQurter)
    {
        quarter = ReadNum("quarter number"); 
        if(quarter == 1)
        {
            Console.WriteLine("X: (-inf; 0)");
            Console.WriteLine("Y: (0; +inf)");
            writeQurter = false;        
        }
        else if(quarter == 2)
        {
            Console.WriteLine("X: (0; +inf)");
            Console.WriteLine("Y: (0; +inf)");
            writeQurter = false;
        }
        else if(quarter == 3)
        {
            Console.WriteLine("X: (-inf; 0)");
            Console.WriteLine("Y: (-inf; 0)");
            writeQurter = false;
        }
        else if(quarter == 4)
        {
            Console.WriteLine("X: (0; +inf)");
            Console.WriteLine("Y: (-inf; 0)");
            writeQurter = false;
        }
    }
}
