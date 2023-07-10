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

int[,] NewRandomArray2D(int rows, int colums) //fill 2d array
{
    int[,] array2d = new int[rows, colums];
    for(int i = 0; i < array2d.GetLength(0); i++){
        for(int j = 0; j < array2d.GetLength(1); j++){
            array2d[i,j] = new Random().Next(0, 11); // [0, 10)
        }
    }
    return array2d;
}