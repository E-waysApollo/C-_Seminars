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
            case "34": task34(); break;
            case "35": task35(); break;
            case "36": task36(); break;
            case "37": task37(); break;
            case "38": task38(); break;
            case "int": taskint(); break;
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
    print_array(mas12);
    Console.WriteLine($"Positive sum is: {mas12_possum}");
    Console.WriteLine($"Negative sum is: {mas12_negsum}");
}

void task32()
{
    int[] or_mas = random_massive(4, -5, 5);
    int[] rev_mas = massive_reverse(or_mas);
    Console.WriteLine($"Origin massive is: ");
    print_array(or_mas);
    Console.WriteLine($"Reverse massive is:");
    print_array(rev_mas);
}

void task33()
{
    int[] massive33 = random_massive(5, 0, 5);
    bool exist33 = exist_in_massive(ReadNum("Input the number"), massive33);

    Console.WriteLine("Massive is:");
    print_array(massive33);

    if(exist33 == true){Console.WriteLine("Yes");}
    else{Console.WriteLine("No");}
}

void task34() //random array with three digit numbers. Need to find quantity of even numbers
{
    int [] array34 = random_massive(5, 100, 999);
    int evenQuntity34 = even_quantity_array(array34);
    print_array(array34);
    Console.WriteLine(evenQuntity34);
}

void task35() //create 123 random number array and find quantity array alements in range [10;99]
{
    int [] array35 = random_massive(123, 0, 100);
    int quantity35 = quantity_of_elements_in_array_range(array35, 10, 99);
    Console.WriteLine("Array is:");
    print_array(array35);
    Console.WriteLine($"Quantity array elements in range [10; 99] is: {quantity35}");
}

void task36() // find sum of even array elements
{
    int [] array36 = random_massive(4, 0, 10);
    int evenSum36 = even_sum_array(array36);
    print_array(array36);
    Console.WriteLine(evenSum36);
}

void task37()// multiply pairs of array elements, firs and last, second and prelast, etc
{
    int [] array37 = random_massive(4, 0, 10);
    int [] array37_multiply = multiply_array_elements(array37);
    
    Console.WriteLine("Origin array is:");
    print_array(array37);
    Console.WriteLine("Multiply array is:");
    print_array (array37_multiply);
}

void task38() // find diference between max and min double array element
{
    double[] array38 = random_double_array(5, 10);
    double diference38 = find_max_array(array38) - find_min_array(array38);
    print_double_array(array38);
    Console.WriteLine($"Diference between max and min array elements is: {diference38}");
}

void taskint()
{
    double intagral = resolve_inegral(5, 4, 3, 10);
    Console.WriteLine(intagral);
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

double [] random_double_array(int length, int max) // create double array
{
    double[] array = new double[length];
    for(int i = 0; i < array.Length; i++)
        array[i] = Math.Round(new Random().NextDouble() * max, 2);//(min, max);
    return array;
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

double resolve_inegral(int a, int b, int x1, int x2)// resolve ingegral y=a*x+b, from [x1; x2]
{
    double sum = 0;
    for(double x = x1; x <= x2; x = x + 0.1)
    {
        sum = sum + (a*x+b);
    }
    return sum;
}

int quantity_of_elements_in_array_range (int [] array, int min, int max)//find quantity array alements in range
{
    int quantity = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] >= min && array[i] <= max){quantity++;}
    }
    return quantity;
}

void print_array(int [] array)
{
    for(int i = 0; i < array.Length; i++){Console.Write(array[i] + "; ");}
    Console.WriteLine();
}

void print_double_array(double [] array)
{
    for(int i = 0; i < array.Length; i++){Console.Write(array[i] + "; ");}
    Console.WriteLine();
}

int [] multiply_array_elements(int [] array)
{
    int [] multiply_array = new int[Convert.ToInt32(Math.Ceiling(Convert.ToDouble(array.Length)/2))];
    for(int i = 0; i < multiply_array.Length; i++){
        if(i == array.Length -1 - i){
            multiply_array[i] = array[i];
        }
        else{
            multiply_array[i] = array[i] * array[array.Length -1 - i];}
    }
    return multiply_array;
}

int even_quantity_array(int [] array) // count quantity of even numbers in array
{
    int evenQuntity = 0;
    for(int i = 0; i < array.Length; i++){
        if(array[i] % 2 == 0)
            evenQuntity++;
    }
    return evenQuntity;
}

int even_sum_array(int [] array) // count sum of even array elements
{
    int evenSum = 0;
    for(int i = 1; i < array.Length; i += 2)
        evenSum = evenSum + array[i];
    return evenSum;
}


double find_max_array(double[] array)
{
    double max = array[0];
    for(int i = 1; i < array.Length; i++){
        if(array[i] > max)
            max = Math.Round(array[i], 2);
    }
    return max;
}

double find_min_array(double[] array)
{
    double min = array[0];
    for(int i = 0; i < array.Length; i++){
        if(array[i] < min)
            min = Math.Round(array[i], 2);
    }
    return min;
}