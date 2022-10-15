// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

int[,] GetMatrixArray()
{
    Console.Write("Введите количество строк в массиве: ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов, неравное количеству строк, в массиве: ");
    int column = Convert.ToInt32(Console.ReadLine());
    int[,] arr = new int[row, column];
    if (row == column) GetMatrixArray();
    return arr;
}

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(-10, 10);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write("{0, 5}", arr[i, j]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FindRowSum(int[,] arr, int[,] rowSum)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum = sum + arr[i, j];
            if (j == arr.GetLength(1) - 1)
            {
                rowSum[i, 0] = sum;
            }
        }
    }
}

void GetRowWithMinSum(int[,] arr)
{
    int min = arr[0, 0];
    for (int i = 1; i < arr.GetLength(0); i++)
    {
        if (arr[i, 0] < min)
        {
            min = arr[i, 0];
        }
    }
    for (int j = 0; j < arr.GetLength(0); j++)
    {
        if (min == arr[j, 0])
        {
            Console.WriteLine($"Строка с наименьшей суммой элементов: {j + 1}");
        }
    }
}

int[,] array = GetMatrixArray();
FillArray(array);
PrintArray(array);
int[,] RowSumm = new int[array.GetLength(0), 1];
FindRowSum(array, RowSumm);
GetRowWithMinSum(RowSumm);