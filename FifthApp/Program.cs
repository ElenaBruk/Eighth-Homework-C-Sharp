// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

void PrintSpiralArray(int[,] arr)
{
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write("{0, 5}", arr[i, j]);
            }
            Console.WriteLine();
        }
    }
}

void FillSpiralArray()
{
    Console.WriteLine("Введите размерность массива: ");
    int arraySize = Convert.ToInt32(Console.ReadLine());
    int[,] spiralArray = new int[arraySize, arraySize];
    int start = 1;
    int i = 0;
    int j = 0;
    while (start <= spiralArray.GetLength(0) * spiralArray.GetLength(1))
    {
        spiralArray[i, j] = start;
        start++;
        if (i <= j + 1 && i + j < spiralArray.GetLength(1) - 1)
        {
            j++;
        }
        else if (i < j && i + j >= spiralArray.GetLength(0) - 1)
        {
            i++;
        }
        else if (i >= j && i + j > spiralArray.GetLength(1) - 1)
        {
            j--;
        }
        else
        {
            i--;
        }
    }
    PrintSpiralArray(spiralArray);
}

FillSpiralArray();
