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