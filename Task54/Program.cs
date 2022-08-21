/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
1 2 4 7
2 3 5 9
2 4 4 8 */

Console.Clear();

int[,] matrixIncome = GetMatrix(3, 4);

Console.WriteLine("Задан массив: ");

PrintMatrix(matrixIncome);

int[,] matrixResult = GiveMeSortMatrix(matrixIncome);

Console.WriteLine("Отсортированный массив: ");

PrintMatrix(matrixResult);


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

int[,] GiveMeSortMatrix(int[,] mat)
{
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            for (int k = 0; k < mat.GetLength(1); k++)
            {
                //Сортируем пузырьком, но в условии написано по убыванию, а показано по возрастанию. В итоге сделано по убыванию, что не принципиально
                if (mat[i, j] <= mat[i, k]) continue;
                int t = mat[i, j];
                mat[i, j] = mat[i, k];
                mat[i, k] = t;
            }
        }
    }
    return mat;
}
