//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
int[] GenerateArrayNumber(int size, int minValue, int maxValue)
{
    int[] resultArrayNumber = new int[size];
    Random rand = new Random();

    for (int i = 0; i < resultArrayNumber.Length; i++)
    {
        resultArrayNumber[i] = rand.Next(minValue, maxValue + 1);
    }
    return resultArrayNumber;
}
int[] arrayNumber = GenerateArrayNumber(10, -9, 9);
Console.WriteLine($"Массив: [ {String.Join("; ", arrayNumber)} ]");
int SearchPositiveNumber(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arrayNumber.Length; i++)
        if (arrayNumber[i] > 0)
        {
            count++;
        }
    return count;
}
Console.WriteLine($"Количкство чисел больше 0 = {SearchPositiveNumber(arrayNumber)}");


//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.WriteLine("введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k2");
double k2 = Convert.ToInt32(Console.ReadLine());

double axisX = (b2 - b1) / (k1 - k2);
double axisY = k1 * axisX + b1;

Console.WriteLine($"Точка пересечения двух прямых = X: {Math.Ceiling(axisX)}, Y: {Math.Ceiling(axisY)}");