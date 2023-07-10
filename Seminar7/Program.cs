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
            case "46": Console.WriteLine(); task46(); break;
            case "47": Console.WriteLine(); task47(); break;
            case "48": Console.WriteLine(); task48(); break;
            case "49": Console.WriteLine(); task49(); break;
            case "50": Console.WriteLine(); task50(); break;
            case "51": Console.WriteLine(); task51(); break;
            case "52": Console.WriteLine(); task52(); break;
            case "ex": IsWoring = false; break;
            default: break;
        }
    }
}
void task46() // create and print 2d array
{
    int[,] task46Array2D = NewRandomArray2D(3,4);
    Console.WriteLine("Random array here!");
    PrintArray2D(task46Array2D);
}

void task48() //create and print m*n  array. Each element = m+n 
{
    int[,] task48Array2D = NewSumArray2D(3,4);
    Console.WriteLine("Array! Each element = m+n");
    PrintArray2D(task48Array2D);
}

void task49() // create array, square elements which have even m and n index, prin array
{
    int[,] task49Array2D = NewRandomArray2D(6,4);
    Console.WriteLine("Origin array here!");
    PrintArray2D(task49Array2D);
    task49Array2D = ReturnSquareEvenIndexArray2D (task49Array2D);
    Console.WriteLine("After square even m & n even elements");
    PrintArray2D(task49Array2D);
}

void task51() //create 2d array, find diagonal elements sum and print it
{
    int[,] task51Array2D = NewRandomArray2D(4,4);
    Console.WriteLine("Origin array");
    PrintArray2D(task51Array2D);
    int sumTask51Array2D = DiagonalSum(task51Array2D);
    Console.WriteLine($"Diagonal sum: {sumTask51Array2D}");
}

void task47() //Create and print double array
{
    double[,] task47DoubleArray2D = NewRandomDoubleArray2D(4,4);
    PrintDoubleArray2D(task47DoubleArray2D);
}

void task50() // input index of element and print the element
{
    int[,] task50Array2D = NewRandomArray2D(5,5);
    Console.WriteLine("MxN array is here!");
    PrintArray2D(task50Array2D);
    int MIndex = ReadNum("Input M-index:");
    int NIndex = ReadNum("Input N-index:");
    Console.WriteLine($"Array element is: {task50Array2D[MIndex,NIndex]}");
}

void task52() // find semiarifmetical in each colum
{
    double[,] task52Array2D = NewRandomDoubleArray2D(4,4);
    PrintDoubleArray2D(task52Array2D);
    PrintDoubleArray(SemiarifmeticalInColum(task52Array2D));    
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

void PrintArray2D(int[,] array2d) // print 2d array
{
    for(int i = 0; i < array2d.GetLength(0); i++){
        for(int j = 0; j < array2d.GetLength(1); j++){
            Console.Write($"{array2d[i,j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void PrintDoubleArray2D(double[,] array2d) // print 2d array
{
    for(int i = 0; i < array2d.GetLength(0); i++){
        for(int j = 0; j < array2d.GetLength(1); j++){
            Console.Write($"{array2d[i,j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void PrintDoubleArray(double [] array)
{
    for(int i = 0; i < array.Length; i++){Console.Write(array[i] + "; ");}
    Console.WriteLine();
}

int[,] NewRandomArray2D(int rows, int colums) //fill 2d array
{
    int[,] array2d = new int[rows, colums];
    for(int i = 0; i < array2d.GetLength(0); i++){
        for(int j = 0; j < array2d.GetLength(1); j++){
            array2d[i,j] = new Random().Next(0, 10); // [0, 10)
        }
    }
    return array2d;
}

double[,] NewRandomDoubleArray2D(int rows, int colums) //fill 2d double array
{
    double[,] array2d = new double[rows, colums];
    for(int i = 0; i < array2d.GetLength(0); i++){
        for(int j = 0; j < array2d.GetLength(1); j++){
            array2d[i,j] = Math.Round(new Random().NextDouble(), 2); // [0, 10)
        }
    }
    return array2d;
}

int[,] NewSumArray2D(int rows, int colums) // create m*n  array. Each element = m+n 
{
    int[,] arraySum2D = new int[rows, colums];
    for(int i = 0; i < arraySum2D.GetLength(0); i++){
        for(int j = 0; j < arraySum2D.GetLength(1); j++){
            arraySum2D[i,j] = i + j;
        }
    }
    return arraySum2D;
}

int[,] ReturnSquareEvenIndexArray2D(int[,] array2d) // Square elements which have even m and n index
{
    for(int i = 1; i < array2d.GetLength(0); i +=2){
        for (int j = 1; j < array2d.GetLength(1); j +=2){
            array2d[i,j] = array2d[i,j] * array2d[i,j];
        } 
    }
    return array2d;
}

int DiagonalSum(int[,] array2D) // find sum of diagonal array elements
{
    int diagSum = 0;
    for(int i = 0; i < array2D.GetLength(0); i++){
        for(int j = i; j == i; j++){
            diagSum = diagSum + array2D[i,j];
        }
    }
    return diagSum;
}

double[] SemiarifmeticalInColum(double[,] array2D) // find semiarifmetical in each colum
{
    double[] resultArray = new double [array2D.GetLength(1)];
    for(int colum = 0; colum < array2D.GetLength(1); colum++){
        double sumInColum = 0;
        for(int row = 0; row < array2D.GetLength(0); row++){
            sumInColum = Math.Round(sumInColum + array2D[row, colum],2);
            //Console.WriteLine(sumInColum);
        }
        resultArray[colum] = sumInColum / Convert.ToDouble(array2D.GetLength(1));
        //Console.WriteLine(resultArray);
    }
    return resultArray;
}
