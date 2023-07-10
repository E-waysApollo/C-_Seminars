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
            case "44": task44(); break;
            case "45": task45(); break;
            case "h1": taskh1(); break;
            case "h2": taskh2(); break;
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

void task42() // revert 10digit number to 2 digit number
{
   Console.WriteLine("Result:" + revert_10_to_n(ReadNum("Input the number for revert"), ReadNum("Input the number system")));   
}

void task44() //Fibonachi
{
    print_array(fibonachi(ReadNum("Input array size")));
}

void task45() // copy array
{
    int[] array45 = random_array(5, 0, 9);
    print_array(array45);
    print_array(copy_array(array45));
}

void taskh1()// count how many numbers bigger then 0
{
    int positiveNumbers = 0;
    Console.WriteLine("Input array numbers");
    int inputNumber;
    while(int.TryParse(Console.ReadLine(), out inputNumber)){
        if(inputNumber > 0)
            positiveNumbers ++;
    }
    Console.WriteLine($"positive numbers: {positiveNumbers}");
}

void taskh2() // find dot of crossing
{
    double k1 = ReadNum("Input k1 of y = k1*x+b1");
    double b1 = ReadNum("Input b1 of y = k1*x+b1");
    double k2 = ReadNum("Input k2 of y = k2*x+b2");
    double b2 = ReadNum("Input b2 of y = k2*x+b2");
    double x = (b1-b2)/(k2-k1);
    double y = (b2*k1 - b1*k2)/(k1-k2);
    Console.WriteLine($"Dot of crossing is ({x}; {y})");
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

int ReadNum(string text = " ")
{
    int num;
    Console.WriteLine(text);
    while(!int.TryParse(Console.ReadLine(), out num))
    {
        Console.WriteLine("It is not a number");
    }
    return num;
}

string revert_10_to_n(int number, int NumberSystem)// revert 10digit number to 3 digit number
{
    string revert = "";
    int reminder;
    string digit = "";
    while(number > 0){
        reminder = number % NumberSystem;
        switch (reminder){
            case 10: digit = "A"; break;
            case 11: digit = "B"; break;
            case 12: digit = "C"; break;
            case 13: digit = "D"; break;
            case 14: digit = "E"; break;
            case 15: digit = "F"; break;
            default:  digit = reminder.ToString(); break;
        }
        revert += digit;
        number = number / NumberSystem;
    }
    string result = "";
    for(int i = revert.Length-1; i >= 0; i--){
        result = result + revert[i];
    }
    return result;
}    

int[] fibonachi(int number)// Fibonachi
{
    int[] fibonachiArray = new int[number];
    fibonachiArray[0] = 0;
    fibonachiArray[1] = 1;
    for(int i = 2; i < number; i++){
        fibonachiArray[i] = fibonachiArray[i-1] + fibonachiArray[i-2];
    }
    return fibonachiArray;
}

int[] copy_array(int[] array) // copy array
{
    int[] copyArray = new int[array.Length];
    for(int i = 0; i < array.Length; i++){
        copyArray[i] = array[i];
    } 
    return copyArray;
}