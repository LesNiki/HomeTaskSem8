// // Задача 54: Задайте двумерный массив. Напишите программу, 
// //которая упорядочит по убыванию элементы каждой строки двумерного массива.

// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] GetArray()
// {
//     int[,] matrix = new int[rows, columns];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(10);
//         }
//     }
//     return matrix;
// }

// int[,] SortedRows(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrix.GetLength(1) - 1; k++)
//             {
//                 if (matrix[i, k] < matrix[i, k + 1])
//                 {
//                     int change = matrix[i, k + 1];
//                     matrix[i, k + 1] = matrix[i, k];
//                     matrix[i, k] = change;
//                 }
//             }
//         }
//     }
//     return matrix;
// }

// void PrintArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }
// int[,] matrix = GetArray();
// PrintArray(matrix);
// Console.WriteLine();
// Console.WriteLine("Матрица с отсортированными строками:");
// PrintArray(SortedRows(matrix));


// //Задача 56: Задайте прямоугольный двумерный массив.
// //Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = new int[rows, columns];
// int currentMinRow = Int32.MaxValue;
// int currentIndexMinRow = -1;

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     int sum=0;
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i, j] = new Random().Next(10);
//         Console.Write(matrix[i, j] + "  ");
//         sum += matrix[i, j];
//     }

//     if (sum < currentMinRow)
//     {
//         currentMinRow = sum;
//         currentIndexMinRow = i;
//     }
//     Console.WriteLine(" sum=" + sum);
// }
// Console.WriteLine();
// Console.WriteLine("Строка с наименьшей суммой элементов: " +(currentIndexMinRow + 1));

// //Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Матрица 1: ");
// int[,] matrix = new int[rows, columns];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i, j] = new Random().Next(10);
//         Console.Write(matrix[i, j] + "  ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine();

// Console.WriteLine("Матрица 2: ");
// int[,] matrix2 = new int[matrix.GetLength(0), matrix.GetLength(1)]; //создали новый массив такого же размера
// for (int k = 0; k < matrix.GetLength(0); k++)
// {
//     for (int m = 0; m < matrix.GetLength(1); m++)
//     {
//         matrix2[k, m] = new Random().Next(10);
//         Console.Write(matrix2[k, m] + "  ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine();

// Console.WriteLine("Результат произведения матриц: ");
// int[,] result = new int[matrix.GetLength(0), matrix.GetLength(1)];
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         int sum = 0;
//         for (int k = 0; k < matrix.GetLength(1); k++)
//         {
//             sum += matrix[i, k] * matrix2[k, j];
//         }
//         Console.Write((result[i, j] = sum) + "   ");
//     }
//     Console.WriteLine();
// }


// // Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// //Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// //Массив размером 2 x 2 x 2
// //66(0,0,0) 25(0,1,0)
// //34(1,0,0) 41(1,1,0)
// //27(0,0,1) 90(0,1,1)
// //26(1,0,1) 55(1,1,1)

// Console.WriteLine("Введите количество элементов по x");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество элементов по y");
// int y = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество элементов по z");
// int z = Convert.ToInt32(Console.ReadLine());

// int[,,] GetArray()
// {
//     int[,,] matrix = new int[x,y,z];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrix.GetLength(2); k++)
//             {
//                 matrix[i, j, k] = new Random().Next(10, 100);
//             }
//         }
//     }
//     return matrix;
// }

// void PrintArray(int[,,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.WriteLine();
//             for (int k = 0; k < matrix.GetLength(2); k++)
//             {
//             Console.Write($"{matrix[i, j, k]} ({i},{j},{k}) ");
//             }
//         }
//         Console.WriteLine();
//     }
// }
// PrintArray(GetArray());


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] matrix = new int[4, 4];
int count = 0; //конкретный элемент массива
int i = 0;
int j = 0;

for (j = 0; j < matrix.GetLength(1); j++) //заполняем 0 строку
{
    matrix[i, j] = 1 + count;
    count++;
}

j = 3; //последний 3 столбец
for (i = 1; i < matrix.GetLength(0); i++)
{
    matrix[i, j] = 1 + count;
    count++;
}

i = 3; //последняя 3 строка
for (j = 2; j >= 0; j--)
{
    matrix[i, j] = 1 + count;
    count++;
}

j = 0;
for (i = 2; i >= 1; i--)
{
    matrix[i, j] = 1 + count;
    count++;
}

i = 1;
for (j = 1; j <= 2; j++)
{
    matrix[i, j] = 1 + count;
    count++;
}

i = 2;
for (j = 2; j >= 1; j--)
{
    matrix[i, j] = 1 + count;
    count++;
}

for (i = 0; i < matrix.GetLength(0); i++) //выводим массив
{
    for (j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}