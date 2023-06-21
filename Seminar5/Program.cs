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
            case "31": task31(); break;
            case "32": task32(); break;
            case "33": task33(); break;
            case "ex": IsWoring = false; break;
            default: break;
        }
    }
}

void task31()
{
    int [] mas12 = random_massive(12, -9, 10);
    int mas12_possum = positive_sum(mas12);
    int mas12_negsum = negative_sum(mas12);

    Console.WriteLine("Random massive is");
    for(int i = 0; i < mas12.Length; i++)
    {
        Console.Write(mas12[i] + "; ");
    }
    Console.WriteLine();
    Console.WriteLine($"Positive sum is: {mas12_possum}");
    Console.WriteLine($"Negative sum is: {mas12_negsum}");
}

void task32()
{
    int[] or_mas = random_massive(4, -5, 5);
    int[] rev_mas = massive_reverse(or_mas);
    Console.WriteLine($"Origin massive is: ");
    for(int i = 0; i < or_mas.Length; i++)
    {
        Console.Write(or_mas[i] + "; ");
    }
    Console.WriteLine();
    Console.WriteLine($"Reverse massive is:");
    for(int i = 0; i < or_mas.Length; i++)
    {
        Console.Write(rev_mas[i] + "; ");
    }
    Console.WriteLine();
}

void task33()
{
    int[] massive33 = random_massive(5, 0, 5);
    bool exist33 = exist_in_massive(ReadNum("Input the number"), massive33);

    Console.WriteLine("Massive is:");
    for(int i = 0; i < massive33.Length; i++)
    {
        Console.Write(massive33[i] + "; ");
    }
    Console.WriteLine();
    
    if(exist33 == true)
    {
        Console.WriteLine("Yes");
    }
    else
    {
        Console.WriteLine("No");
    }
}

int[] random_massive(int length, int min_lim, int max_lim)//create massive with random numbers
{    
    int [] massive = new int[length];
    for (int i = 0; i < length; i++)
    {
        massive[i] = new Random().Next(min_lim, max_lim);
    }
    return massive;
}

int positive_sum(int[] mas)// count positive sum of massive numbers
{
    int positive_sum_result = 0;
    for(int i = 0; i < mas.Length; i++)
    {
        if(mas[i] >= 0)
        {
            positive_sum_result += mas[i];
        }
    }
    return positive_sum_result;
}

int negative_sum(int[] mas)// count negative sum of massive numbers
{
    int negative_sum_result = 0;
    for(int i = 0; i < mas.Length; i++)
    {
        if(mas[i] < 0)
        {
            negative_sum_result += mas[i];
        }        
    }
    return negative_sum_result;
}

int[] massive_reverse(int[] mas)// mutiply all massive numbers on -1
{
    int[] mas_rev = new int[mas.Length];
    for(int i = 0; i < mas.Length; i++)
    {
        mas_rev[i] = mas[i] * (-1);
    }
    return mas_rev;
}

bool exist_in_massive(int number, int[] massive)// check number in massive
{
    bool exist = false;
    for(int j = 0; j < massive.Length; j++)
    {
        if(massive[j] == number)
        {
            exist = true;
        }
    }
    return exist;
}

int ReadNum(string text)
{
    int num;
    Console.WriteLine(text);
    while(!int.TryParse(Console.ReadLine(), out num))
    {
        Console.WriteLine("It is not a number");
    }
    return num;
}