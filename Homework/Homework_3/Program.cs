Main();

void Main()
{
    bool IsWoring = true;
    while (IsWoring)
    {
        Console.WriteLine("Input task number");
        string taskNum = Console.ReadLine();
        switch (taskNum)
        {
            case "19": task19(); break;
            case "21": task21(); break;
            case "23": task23(); break;
            case "ex": IsWoring = false; break;
            default: break;
        }
    }
}

void task19()//прорамма принимает 5-значное число и определяет полиндром это или нет
{
    bool fiveDigit = false;
    int fiveDigitNumber;
    while (!fiveDigit)
    {
        fiveDigitNumber = ReadNum("five digit number");
        if (fiveDigitNumber / 10000 >= 1 && fiveDigitNumber / 100000 < 1)
        {
            if (fiveDigitNumber / 10000 == fiveDigitNumber % 10 && fiveDigitNumber / 1000 - fiveDigitNumber / 10000 * 10 == (fiveDigitNumber % 100 - fiveDigitNumber % 10) / 10)
                Console.WriteLine("It's a palindrom");
            else
                Console.WriteLine("It's not a palindrom");
            fiveDigit = true;
        }
    }
}

void task21()//программа принимает на вход координаты точек х и у и находит расстояние между ними корень((х1-х2)^2 + (y1-y2)^2)
{
    int X1 = ReadNum("X1 ccordinate");
    int Y1 = ReadNum("Y1 coordinate");
    int Z1 = ReadNum("Z1 coordinate");
    int X2 = ReadNum("X2 coordinate");
    int Y2 = ReadNum("Y2 coordinate");
    int Z2 = ReadNum("Z2 coordinate");
    double xyDist = distance3D(X1, Y1, Z1, X2, Y2, Z2);
    Console.WriteLine($"Diastance is {xyDist}");
}

void task23()//Программа принимает на вход число и выдает таблицу кубов чисел
{
    int kubeNum = ReadNum("length of quarter line");
    Console.WriteLine(KubeString(kubeNum));
}

int ReadNum(string argument)
{
    Console.WriteLine($"Input {argument}");
    int num;
    while (!int.TryParse(Console.ReadLine(), out num))
    {
        Console.WriteLine("It's not a number");
    }
    return num;
}

string KubeString(int num)
{
    string kubeLine = "";
    for (int i = 1; i <= num; i++)
        kubeLine = kubeLine + $"{i * i * i}, ";
    return kubeLine;
}

double distance3D(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double dist = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2));
    return dist;
}