/* Задача 62. Заполните спирально массив 4 на 4.
Например, на выходе получается вот такой массив:

1 2 3 4
12 13 14 5
11 16 15 6
10 9 8 7 */

Console.Clear();

int[,] matrixIncome = GetSpiralMatrix(4, 4);

Console.WriteLine("Спиральный массив: ");

PrintMatrix(matrixIncome);

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

//К сожалению, решение не универсальное. Вероятно, нужно либо вводить поправки при каждом повороте спирали и уменьшать на них длину четверти витка, 
//либо проверять следующий символ на 0 и при этом делать поворот, но не удалось реализовать, а подсматривать не интересно)


int[,] GetSpiralMatrix(int m, int n)
{

    int[,] matrix = new int[m, n];
    int count = 1;
    int i = 0;
    int j = 1;

    while (i < matrix.GetLength(0))
    {
        matrix[0, i] = count;
        count++;
        i++;
    }

    while (j < matrix.GetLength(1))
    {
        matrix[j, i - 1] = count;
        count++;
        j++;
    }

    i = matrix.GetLength(1)-1;

    while (i >= 1)
    {
        matrix[matrix.GetLength(0)-1, i-1] = count;
        count++;
        i--;
    }

    j = matrix.GetLength(0)-1;
    while (j > 1)
    {
        matrix[j-1, 0] = count;
        count++;
        j--;
    }

    i=1;
    while (i < matrix.GetLength(0)-1)
    {
        matrix[1, i] = count;
        count++;
        i++;
    }

    i=3;
    while (i > 1)
    {
        matrix[matrix.GetLength(0) - 2, i - 1] = count;
        count++;
        i--;
    }

    if (count >= matrix.GetLength(0)*matrix.GetLength(1)) return matrix;
    return matrix;
}


