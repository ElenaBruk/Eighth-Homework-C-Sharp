// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.

int[,,] Get3DArray()
{
    Console.Write("Введите количество строк в массиве: ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов в массиве: ");
    int column = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите глубину массива: ");
    int depth = Convert.ToInt32(Console.ReadLine());
    int[,,] arr3D = new int[row, column, depth];
    return arr3D;
}

void Print3DArray(int[,,] arr3D)
{
    for (int k = 0; k < arr3D.GetLength(2); k++)
    {
        for (int i = 0; i < arr3D.GetLength(0); i++)
        {
            for (int j = 0; j < arr3D.GetLength(1); j++)
            {
                Console.Write($"{arr3D[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

void Fill3DArray(int[,,] arr3D)
{
    string[] string3DArray = new string[arr3D.GetLength(0) * arr3D.GetLength(1) * arr3D.GetLength(2)];
    int count = 0;
    for (int i = 0; i < arr3D.GetLength(0); i++)
    {
        for (int j = 0; j < arr3D.GetLength(1); j++)
        {
            for (int k = 0; k < arr3D.GetLength(2); k++)
            {
                arr3D[i, j, k] = new Random().Next(10, 100);
                while (string3DArray.Contains(Convert.ToString(arr3D[i, j, k])))
                    arr3D[i, j, k] = new Random().Next(10, 100);
                string3DArray[count] = Convert.ToString(arr3D[i, j, k]);
                count++;
            }
        }
    }
}

int[,,] array3D = Get3DArray();
Fill3DArray(array3D);
Print3DArray(array3D);