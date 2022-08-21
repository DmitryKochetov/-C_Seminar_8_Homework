/* Задача 60. Сформируйте трёхмерный массив из неповторяющихся 
двузначных чисел. Напишите программу, которая будет построчно 
выводить массив, добавляя индексы каждого элемента.

массив размером 2 x 2 x 2
12(0,0,0) 22(0,0,1)
45(1,0,0) 53(1,0,1) */

Console.Clear();

int[,,] matrixResult = Get3dMatrix(3, 3, 3);

Randomize3dMatrix(matrixResult);

Print3dMatrix(matrixResult);

//В данном случае использован метод, который случайным образом переставляет элементы массива
int[,,] Randomize3dMatrix(int[,,] array)
{
    Random rnd = new Random();
    int temp=0;
    int m = 0;
    int n = 0;
    int k = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int l = 0; l < array.GetLength(2); l++)
            {
                temp = array[i, j, l];
                m = rnd.Next(0, array.GetLength(0));
                n = rnd.Next(0, array.GetLength(1));
                k = rnd.Next(0, array.GetLength(2));
                array[i, j, l] = array[m, n, k];
                array[m, n, k] = temp;
            }
        }
    }

    return array;
}

int[,,] Get3dMatrix(int m, int n, int k)
{
    int[,,] matrix = new int[m, n, k];
    Random rnd = new Random();
    int f = 10;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int l = 0; l < matrix.GetLength(2); l++)
            {
                matrix[i, j, l] = f;
                f++; 
            }
        }
    }
    return matrix;
}

void Print3dMatrix(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int l = 0; l < array.GetLength(2); l++)
            {
                //if (j == 0) Console.Write("[");
                //if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j],3},");
                //else Console.Write($"{array[i, j],3}]");
                Console.Write($"{array[i, j, l]}({i} {j} {l}) ");
            }
            Console.WriteLine();
        
        }
        Console.WriteLine();
    }
}