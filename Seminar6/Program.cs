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
            case "39": task39(); break;
            case "ex": IsWoring = false; break;
            default: break;
        }
    }
}

void task39() //  make first element the last, last element make the first
{
    int[] array39 = random_array(5, 0, 9);
    int[] arrayReverse39 = array_reverse(array39);
    print_array(array39);
    //print_array(arrayReverse39);
}

int[] random_array(int length, int min_lim, int max_lim)//create massive with random numbers
{    
    int [] massive = new int[length];
    for (int i = 0; i < length; i++)
    {
        massive[i] = new Random().Next(min_lim, max_lim);
    }
    return massive;
}

void print_array(int [] array)
{
    for(int i = 0; i < array.Length; i++){Console.Write(array[i] + "; ");}
    Console.WriteLine();
}

int[] array_reverse(int[] array) // make first element the last, last element make the first
{
    int[] arrayReverse = new int[array.Length];
    int temp;
    for(int i = 0; i < array.Length; i++){
        temp = array[i];
        array[i] = array[array.Length-1 - i];
        array[array.Length-1 - i] = temp;
    }
    return arrayReverse;
}