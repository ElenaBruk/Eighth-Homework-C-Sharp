// Задача 58: Задайте две матрицы. Напишите программу, которая 
// будет находить произведение двух матриц.

void FillMatrixArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintMatrixArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("{0, 5}", matrix[i, j]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void MultiMatrixArray(int[,] matr1, int[,] matr2, int[,] resultMatr)
{
    for (int i = 0; i < matr2.GetLength(1); i++)
    {
        for (int j = 0; j < matr1.GetLength(0); j++)
        {
            for (int k = 0; k < matr1.GetLength(1); k++)
            {
                resultMatr[i, j] += matr1[i, k] * matr2[k, j];
            }
        }
    }
}

Console.Write("Введите количество строк первой матрицы: ");
int row1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов первой матрицы: ");
int column1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.Write("Введите количество строк второй матрицы: ");
int row2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов второй матрицы: ");
int column2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] matrix1 = new int[row1, column1];
int[,] matrix2 = new int[row2, column2];
int[,] multiMatr = new int[matrix2.GetLength(1), matrix1.GetLength(0)];

Console.WriteLine("Массив № 1: ");
FillMatrixArray(matrix1);
PrintMatrixArray(matrix1);
Console.WriteLine("Массив № 2: ");
FillMatrixArray(matrix2);
PrintMatrixArray(matrix2);

if (row1 != column2 || column1 != row2)
{
    Console.Write("Умножение полученных матриц невозможно.");
}
else
{
    Console.WriteLine("Произведение вышезаданных матриц: ");
    MultiMatrixArray(matrix1, matrix2, multiMatr);
    PrintMatrixArray(multiMatr);
}