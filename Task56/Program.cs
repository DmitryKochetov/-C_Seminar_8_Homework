/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

Console.Clear();

int[,] matrixResult = GetMatrix(4, 4);

Console.WriteLine("Задан массив: ");

PrintMatrix(matrixResult);

int row = GiveMeMinRowSum(matrixResult);

Console.Write($"Строка с наименьшей суммой элементов: {row + 1}");


int[,] GetMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 100);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");
            if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j],3},");
            else Console.Write($"{array[i, j],3}]");
        }
        Console.WriteLine();
    }
}

int GiveMeMinRowSum(int[,] mat)
{
    int minSum = 0;
    int tempSum = 0;
    row = 0;
    for (int p = 0; p < mat.GetLength(1); p++)
    {
        minSum = minSum + mat[0, p];
    }
    
    for (int i = 1; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            tempSum = tempSum + mat[i, j];
        }
        if (tempSum < minSum)
        {
            minSum = tempSum;
            row = i;
        }
        tempSum = 0;
    }

    return row;
}