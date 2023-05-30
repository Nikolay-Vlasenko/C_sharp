// Задача 24: Напишите программу, которая принимает 
// на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// A = 4: 1+2+3+4 = 3 + 3 + 4 = 6 + 4 = 10

//Console.Write("Введите число А: ");

//int limit = Convert.ToInt32(Console.ReadLine());

//int sum = 0; // Изначально суммы нет
// for (точка входа; условие цикла; увел.счетчика)
//for (int i = 1; i <= limit; i++)
//{
//    sum += i; // sum = sum + i
//}

//Console.WriteLine($"Сумма чисел от 1 до {limit} = {sum}");

//Задача 26: Напишите программу, 
//которая принимает на вход число и выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int imp = number;
//int count = 0;
//while (number > 0)
//{
//    number /= 10;
//    count ++;
//}
//Console.WriteLine($"Количество цифр в числе {imp}: {count}");
for (int count = 1; number > 0; count++)
{
   number /= 10; 
   Console.WriteLine($"Количество цифр в числе {imp}: {count}");
}

// Задача 30: Напишите программу, которая выводит массив из 8 элементов,
//  заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]
int size = 8;
int[] array = new int[size]; // Массив из 8 элементов: в массиве изначально 8 нулей
Random rand = new Random();
for (int i = 0; i < size; i++)
{
    // array[i] = new Random().Next(0, 2)
    array[i] = rand.Next(2);
    // Console.Write(array[i] + " ");
}

Console.WriteLine($"Массив: [ {String.Join("; ",array)} ]");