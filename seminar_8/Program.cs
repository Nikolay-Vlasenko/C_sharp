// void MeanArithColumn(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(1); i++) // Цикл по стобцам 
//     {
//         double sum = 0; // Среднее арифм.
//         for (int j = 0; j < matr.GetLength(0); j++)// Цикл по стобцам , j < n
//         {
            
//             sum = sum + matr[j, i]; // Нашел сумму по строчке
//         }
//         Console.WriteLine($"Среднее арифм. {i + 1} столбца = {sum / matr.GetLength(0)}");
//     }
// }
// Console.WriteLine();
// MeanArithColumn(resMatrix);

// // Задача 53: Задайте двумерный массив. 
// // Напишите программу, которая поменяет местами первую и последнюю строку массива.

// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество cтолбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] resMatrix = GetMatrix(rows, columns, 0, 10);
// // rows=3, columns=4 => таблица из 3 строк и 4 столбцов, элемент: число от 0 до 10 включительно
// PrintMatrix(resMatrix); // PrintMatrix(матрица)

// ChangeRows(resMatrix); // Внутри resMatrix происходит замена 1 и последней строчки 

// Console.WriteLine("Матрица результат: ");

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

// // Метод, который печатает массив 
// void PrintMatrix(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++) // строчки
//     {
//         for (int j = 0; j < array.GetLength(1); j++) // столбцы
//         {
//             Console.Write(array[i, j] + "\t"); // "\t" = Tab = 4 пробела между элементами
//         }
//         Console.WriteLine();
//     }
// }

// void ChangeRows(int[,] matr)
// {
//     int lastRowIndex = matr.GetLength(0) - 1; // Индекс последней строчки
//     for (int i = 0; i < matr.GetLength(1); i++) 
//     {
//         int temp = matr[0, i];
//         matr[0, i] = matr[lastRowIndex, i];
//         matr[lastRowIndex, i] = temp;
//     }
// }


// //Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// //В случае, если это невозможно, программа должна вывести сообщение для пользователя.
// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество cтолбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// if (rows!= columns)
// {
//     Console.WriteLine("Error");
//     return;
// }

// int[,] resMatrix = GetMatrix(rows, columns, 0, 10);
// // rows=3, columns=4 => таблица из 3 строк и 4 столбцов, элемент: число от 0 до 10 включительно
// PrintMatrix(resMatrix); // PrintMatrix(матрица)

// // ChangeRows(resMatrix); // Внутри resMatrix происходит замена 1 и последней строчки 

// Console.WriteLine("Матрица результат: ");
// PrintMatrix(GetChangedArray(resMatrix));


// //PrintMatrix(resMatrix);

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

// // Метод, который печатает массив 
// void PrintMatrix(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++) // строчки
//     {
//         for (int j = 0; j < array.GetLength(1); j++) // столбцы
//         {
//             Console.Write(array[i, j] + "\t"); // "\t" = Tab = 4 пробела между элементами
//         }
//         Console.WriteLine();
//     }
// }

// // void ChangeRows(int[,] matr)
// // {
// //     int lastRowIndex = matr.GetLength(0) - 1; // Индекс последней строчки
// //     for (int i = 0; i < matr.GetLength(1); i++) 
// //     {
// //         int temp = matr[0, i];
// //         matr[0, i] = matr[lastRowIndex, i];
// //         matr[lastRowIndex, i] = temp;
// //     }
// // }

// int[,] GetChangedArray (int[,] matrix)
// {
//     int [,] resultMatrix = new int [matrix.GetLength(0), matrix.GetLength(1)];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             resultMatrix[i,j] = matrix[j,i];
//         }
//     }
//     return resultMatrix;
// }



// //Задача 59: Задайте двумерный массив из целых чисел. 
// //Напишите программу, которая удалит строку и столбец, 
// //на пересечении которых расположен наименьший элемент массива.

// int rowsCount = 3;
// int columnsCount = 3;

// int[,] matrix = new int[rowsCount, columnsCount];

// int min = int.MaxValue;
// int rowIndexOfMinValue = 0;
// int columnIndexOfMinValue = 0;

// for (int i = 0; i < rowsCount; i++)
// {
//     for (int j = 0; j < columnsCount; j++)
//     {
//         matrix[i, j] = new Random().Next(1, 11); // Числа от 1 вкл-то до 10 вкл-но
//         Console.Write(matrix[i, j] + "\t");
//         if (min > matrix[i, j])
//         {
//             min = matrix[i, j]; // 2147483647 > 10? min = 10
//             rowIndexOfMinValue = i;
//             columnIndexOfMinValue = j;
//         }
//     }
//     Console.WriteLine();
// }
// Console.WriteLine($"min: {min}, координаты: ( {rowIndexOfMinValue},{columnIndexOfMinValue} )");


// for (int i = 0; i < rowsCount; i++)
// {
//     if (rowIndexOfMinValue != i) // исключил строчку с мин. элементом
//     {
//         for (int j = 0; j < columnsCount; j++)
//         {
//             if (columnIndexOfMinValue != j) // исключил столбец с мин. элементом
//             {
//                 Console.Write(matrix[i, j] + "\t");
//             }
//         }
//         Console.WriteLine();
//     }
// }