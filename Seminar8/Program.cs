Main();
static void Main()
{
    int[,] array = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    // Вывод исходного массива
    Console.WriteLine("Исходный массив:");
    PrintArray(array);

    // Меняем местами первую и последнюю строки
    for (int i = 0; i < columns; i++)
    {
        int temp = array[0, i];
        array[0, i] = array[rows - 1, i];
        array[rows - 1, i] = temp;
    }

    // Вывод измененного массива
    Console.WriteLine("Измененный массив:");
    PrintArray(array);
}

static void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}