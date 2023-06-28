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
            case "40": task40(); break;
            case "42": task42(); break;
            case "ex": IsWoring = false; break;
            default: break;
        }
    }
}

void task39() //  make first element the last, last element make the first
{
    int[] array39 = random_array(4, 0, 9);
    int[] arrayReverse39 = array_reverse(array39);
    print_array(array39);
    print_array(arrayReverse39);
}

void task40() // // check if traigle with  boards a, b, c exists
{
    int a = ReadNum("Input board a length");
    int b = ReadNum("Input board b length");
    int c = ReadNum("Input board c length");
    bool exist40 = exist_traingle(a, b, c);
    if(exist40 == true)
        Console.WriteLine("Triangle exist");
    else
        Console.WriteLine("Triangle dose not exist");
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
        arrayReverse[i] = array[array.Length-1 - i];
        arrayReverse[array.Length-1 - i] = temp;
    }
    return arrayReverse;
}

bool exist_traingle(int a, int b, int c) // check if traigle with  boards a, b, c exists
{
    bool exist = false;
    if(a < b + c && c < a + b && b < a + c){
        exist = true;
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