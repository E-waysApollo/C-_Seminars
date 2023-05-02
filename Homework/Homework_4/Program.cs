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
            case "25": task25(); break;
            case "27": task27(); break;
            case "29": task29(); break;
            case "ex": IsWoring = false; break;
            default: break;
        }
    }
}

void task25()
{
    int firstArg = ReadNum("argument A");
    int secondArg = ReadNum("argument B");
    Console.WriteLine($"{firstArg}^{secondArg} = {AinB(firstArg, secondArg)}");
}

void task27()
{
    int number = ReadNum("number");
    Console.WriteLine($"Sum of all numbers of {number} = {NumberSum(number)}");
}

void task29()
{
    int[] massive = randomas(8);
    for(int i = 0; i < 8; i++)
    {
        Console.Write($"{massive[i]} ");
    }
    Console.WriteLine();
}

int AinB(int A, int B) // принимает 2 числа А и В, отдает А^B
{
    int result = 1;
    if (A > 0 && B > 0)
    {
        for (int i = 0; i < B; i++)
        {
            result = result * A;
        }
        return result;
    }
    else return -1;
}

int NumberSum(int arg) // принимает число, выдает сумму цифр в числе
{
    int result = 0;
    for(int i = 0; i < arg; i++)
    {
        result = result + arg % 10;
        arg = arg / 10;
    }
    return result;
}

int[] randomas(int length) // принимает длину массива, заполняет массив значениями от 0 до 99
{
    int [] mas = new int[length];
    for (int i = 0; i < length; i++)
    {
        mas[i] = new Random().Next(0,100);
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