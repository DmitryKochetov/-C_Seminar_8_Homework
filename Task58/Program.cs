/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, заданы 2 массива:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
и
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7

Их произведение будет равно следующему массиву:
1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49 */


Console.Clear();

int[,] matrix1 = GetMatrix(4, 4);

Console.WriteLine("Первый массив: ");

PrintMatrix(matrix1);

int[,] matrix2 = GetMatrix(4, 4);

Console.WriteLine("Второй массив: ");

PrintMatrix(matrix2);

int[,] array = GiveMeMultipleMatrix(matrix1, matrix2);

//строго это не произведение матриц. Это только произведение элементов одной матрицы на такие же элементы другой матрицы,
// но так показано в примере

Console.WriteLine("Произведение матриц: ");

PrintMatrix(array);

int[,] GetMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
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

int[,] GiveMeMultipleMatrix(int[,] mat1, int[,] mat2)
{
    int[,] matrix = new int[mat1.GetLength(0), mat1.GetLength(1)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = mat1[i, j] * mat2[i, j];
        }
    }
    return matrix;
}