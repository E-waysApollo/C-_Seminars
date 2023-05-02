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
            case "24": task24(); break;
            case "26": task26(); break;
            case "28": task28(); break;
            case "30": task30(); break;
            case "ex": IsWoring = false; break;
            default: break;
        }
    }
}

void task24()
{
    Console.WriteLine(stringSum(ReadNum("number")));
}

void task26()
{
    Console.WriteLine(countNumber(ReadNum("number")));
}

void task28()
{
    Console.WriteLine(stringMult(ReadNum("number")));
}

void task30()
{
    int[] massive = randomas(8);
    for(int i = 0; i < 8; i++)
    {
        Console.Write(massive[i]);
    }
    Console.WriteLine();
}

int stringSum(int A) // принимает число А и выдает сумму чисел от 1 до А
{
    if (A > 0)
    {
        int sum = 0;
        for (int i = 1; i <= A; i++)
        {
            sum = sum + i;
        }
        return sum;
    }
    else return -1;
}

int countNumber(int num) // принимает число, возвращает кол-во цифр в числе
{
    int result = 1;
    while(num > 1)
    {
        num = num / 10;
        result++;
    }
    return result;
}

int stringMult(int A) // принимает число А и выдает произведение чисел от 1 до А
{
    if (A > 0)
    {
        int mul = 1;
        for (int i = 1; i <= A; i++)
        {
            mul = mul * i;
        }
        return mul;
    }
    else return -1;
}

int[] randomas(int length) // принимает длину массива, заполняет массив значениями от 0 до 1
{
    int [] mas = new int[length];
    for (int i = 0; i < length; i++)
    {
        mas[i] = new Random().Next(0,2);
    }
    return mas;
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