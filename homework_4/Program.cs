//Задача 25: Напишите цикл, 
//который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
Console.Write("Введите число A: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
int degree = 0;
for (int i = 1; i < secondNumber; i++)
{
degree = (int) Math.Pow(firstNumber,secondNumber);  //тут я подглядел про преобразование типов
}
Console.WriteLine($"Число {firstNumber} в степени числа {secondNumber} = {degree}");


//Задача 27: Напишите программу, 
//которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sumNumber = 0; // Изначально суммы нет
while (number > 0)
{
    sumNumber += number % 10;
    number /= 10;
}
Console.WriteLine($"Сумма чисел введёного числа = {sumNumber}");



//Задача 29: Напишите программу, 
//которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]
int size = 8;
double[] array = new double[size];
Random rand = new Random();
for (int i = 0; i < size; i++)
{
    array[i] = rand.NextDouble() * 100;
}
Console.WriteLine($"Массив: [ {String.Join("; ",array)} ]");