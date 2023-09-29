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
            case "53": Console.WriteLine(); task53(); break;
            case "55": Console.WriteLine(); task55(); break;
            // case "48": Console.WriteLine(); task48(); break;
            // case "49": Console.WriteLine(); task49(); break;
            // case "50": Console.WriteLine(); task50(); break;
            // case "51": Console.WriteLine(); task51(); break;
            // case "52": Console.WriteLine(); task52(); break;
            case "ex": IsWoring = false; break;
            default: break;
        }
    }
}

void task53()
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

void task55()
{
    // Запросить у пользователя количество строк и столбцов
    Console.Write("Введите количество строк: ");
    int rows = int.Parse(Console.ReadLine());

    Console.Write("Введите количество столбцов: ");
    int columns = int.Parse(Console.ReadLine());

    // Создать двумерный массив
    int[,] array = new int[rows, columns];
    
    // Заполнить массив данными, введенными пользователем
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"Введите значение для элемента [{i},{j}]: ");
            array[i, j] = int.Parse(Console.ReadLine());
        }
    }

    // Проверить, можно ли заменить строки на столбцы
    bool canTranspose = (rows == columns);

    if (canTranspose)
    {
        // Создать новый двумерный массив для хранения транспонированной матрицы
        int[,] transposedArray = new int[columns, rows];

        // Заменить строки на столбцы
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                transposedArray[j, i] = array[i, j];
            }
        }
        Console.WriteLine("Исходный массив");
        PrintArray(array);
        Console.WriteLine("Транспонированный массив");
        PrintArray(transposedArray);
    }
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