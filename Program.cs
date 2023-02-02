// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


// Console.WriteLine("Введите количество строк");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество стоблцов");
// int n = Convert.ToInt32(Console.ReadLine());
// double[,] array = new double[m, n]; 
// FillArray(array);
// PrintArray(array);

// void FillArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = Convert.ToDouble(new Random().Next(-10, 11)); 
// }

// void PrintArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i, j],3}"); 
//         Console.WriteLine();
//     }
// }




// Задача 50. Напишите программу, которая на вход принимает значение элемента
// в двумерном массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.

int[,] array = new int[,]
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4},
};

Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
FindElement(array, N);
void FindElement(int[,] array, int N)
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            if (array[i, j] == N)
            {
                Console.WriteLine($"Позиция элемента в массиве: [{i},{j}]");
                count = count + 1;
            }
            else
            {
                
            }
    
    if (count == 0)
    {
        Console.WriteLine("Число в массиве отсутвует");
    }
    else
    {

    }
}




// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Console.WriteLine("Введите количество строк");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество стоблцов");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[m, n];

// Console.WriteLine(); 
// FillArray(array);
// PrintArray(array);
// Console.WriteLine();
// Console.WriteLine("Среднее арифметическое каждого столбца:");
// for (int j = 0; j < array.GetLength(1); j++)
// {
//     double avarage = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         avarage = (avarage + array[i, j]);
//     }
//     avarage = avarage / m;
//     Console.Write(avarage + "; ");
// }
// Console.WriteLine();

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = new Random().Next(0, 10);
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i, j]} \t");
//         Console.WriteLine();
//     }
// }














