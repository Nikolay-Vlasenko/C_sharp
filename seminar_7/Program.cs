// int length = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[length]; // length = 5, 5 нулей
// for (int i = 0; i < numbers.Length; i++)
// {
//     Console.WriteLine($"Введите {i + 1} элемент: "); // i = 0
//     numbers[i] = Convert.ToInt32(Console.ReadLine());
// }
// int count = 0;
// for (int i = 0; i < numbers.Length; i++)
// {
//     if (numbers[i] > 0)
//     {
//         count++;
//     }
// }

// Console.WriteLine($"Количество положительных элементов: {count}");

// int length = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[length]; // length = 5, 5 нулей
// int count = 0;
// for (int i = 0; i < numbers.Length; i++)
// {
//     numbers[i] = Convert.ToInt32(Console.ReadLine());
//     if (numbers[i] > 0)
//     {
//         count++;
//     }
// }

// Console.WriteLine($"Массив: [ {string.Join(";", numbers)} ]");
// Console.WriteLine($"Количество положительных элементов: {count}");  

// // Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// // m = 3, n = 4.
// // 1 4 8 19
// // 5 -2 33 -2
// // 77 3 8 1

// // Двумерный массив

// // метод для создания массива 
// // Двумерный массив = matrix
// // m - кол-во строчек, n - столбцов

// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество cтолбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] resMatrix = GetMatrix(rows, columns);
// // rows=3, columns=4 => таблица из 3 строк и 4 столбцов, элемент: число от 0 до 10 включительно
// PrintMatrix(resMatrix); // PrintMatrix(матрица)

// // int[,] GetMatrix(int m, int n, int min, int max)
// // {
// //     int[,] matrix = new int[m, n]; // Таблица из m строк и n столбцов 
// //     for (int i = 0; i < matrix.GetLength(0); i++) // Цикл по строчкам , i < m
// //     {
// //         // i,j,m,k 
// //         for (int j = 0; j < matrix.GetLength(1); j++)// Цикл по стобцам , j < n
// //         {
// //             matrix[i, j] = new Random().Next(min, max + 1);
// //         }
// //     }
// //     return matrix;
// // }

// int[,] GetMatrix(int m, int n)
// {
//     int[,] matrix = new int[m, n]; // Таблица из m строк и n столбцов 
//     for (int i = 0; i < matrix.GetLength(0); i++) // Цикл по строчкам , i < m
//     {
//         // i,j,m,k 
//         for (int j = 0; j < matrix.GetLength(1); j++)// Цикл по стобцам , j < n
//         {
//             matrix[i, j] = i + j;
//         }
//     }
//     return matrix;
// }

// // Метод, который печатает массив 
// void PrintMatrix(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++) // строчки
//     {
//         for (int j = 0; j < array.GetLength(1); j++) // столбцы
//         {
//             Console.Write(array[i,j] + "\t"); // "\t" = Tab = 4 пробела между элементами
//         }
//         Console.WriteLine();
//     }
// }

// // Задача 48/
// // Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
// // и замените эти элементы на их квадраты.


// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество cтолбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] resMatrix = GetMatrix(rows, columns, 0, 10);
// // rows=3, columns=4 => таблица из 3 строк и 4 столбцов, элемент: число от 0 до 10 включительно
// PrintMatrix(resMatrix); // PrintMatrix(матрица)
// ReplaceByEvenIndex(resMatrix); 
// Console.WriteLine();
// PrintMatrix(resMatrix); 


// int[,] GetMatrix(int m, int n, int min, int max)
// {
//     int[,] matrix = new int[m, n]; // Таблица из m строк и n столбцов 
//     for (int i = 0; i < matrix.GetLength(0); i++) // Цикл по строчкам , i < m
//     {
//         // i,j,m,k 
//         for (int j = 0; j < matrix.GetLength(1); j++)// Цикл по стобцам , j < n
//         {
//             matrix[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++) // строчки
//     {
//         for (int j = 0; j < array.GetLength(1); j++) // столбцы
//         {
//             Console.Write(array[i,j] + "\t"); // "\t" = Tab = 4 пробела между элементами
//         }
//         Console.WriteLine();
//     }
// }


// void ReplaceByEvenIndex(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++) // строчки
//     {
//         for (int j = 0; j < array.GetLength(1); j++) // столбцы
//         {
//             if (i % 2 == 0 && i > 0 && j % 2 == 0 && j > 0 ) 
//             {
//              array[i, j] = (int)Math.Pow(array[i, j], 2);   
//             }
//         }
        
//     }
// }