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
            case "21": task21(); break;
            case "ex": IsWoring = false; break;
            default: break;
        }
    }
}

void task18()
{}

void task21()//программа принимает на вход координаты точек х и у и находит расстояние между ними корень((х1-х2)^2 + (y1-y2)^2)
{
    int X1 = ReadNum("X1 ccordinate");
    int Y1 = ReadNum("Y1 coordinate");
    int X2 = ReadNum("X2 coordinate");
    int Y2 = ReadNum("Y2 coordinate");
    double xyDist = distance(X1, Y1, X2, Y2);
    Console.WriteLine($"Diastance is {xyDist}");
}

double distance(int x1, int y1, int x2, int y2)
{
    double dist  = Math.Sqrt((x1-x2)*(x1-x2) + (y1-y2)*(y1-y2));
    return dist;
}
