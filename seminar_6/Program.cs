int[] GenerateArray(int size)
{
    int[] resultArray = new int[size];
    Random rand = new Random();

    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = rand.Next(99, 999);
    }
    return resultArray;
}
int[] array = GenerateArray(5);
Console.WriteLine($"Массив: [ {String.Join("; ", array)} ]");
int SearchEven(int[] arr)
{
    int count = 0;
    for (int i = 0; i < array.Length; i += 2)
    {
        count++;
    }
    return count;
}
Console.WriteLine($"Количество четных чисел: {SearchEven(array)}");


// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
int size = 8;
double[] array = new double[size]; // Массив вещ. чисел  на 8 элементов

for (int i = 0; i < array.Length; i++)
{
    array[i] = Math.Round((new Random().NextDouble() * new Random().Next(10, 101)),2); // От 0 до 1
} // Next(10, 101) => от 10 до 100 включительно
// Умножаю 0,2627279501433908 на рандомное число от 10 до 100 вкл-то, далее - округляю до 2 знаков
// после запятой

Console.WriteLine($"Массив вещественных чисел: [ {String.Join("; ", array)} ]");

// тип_объекта имя = значение;
// int[] array = new int[размерчик]; // 8 нулей
// Способ №1. Через резервный массив 
int[] CopyReverseArray(int[] arr)
{
    int[] reverseArr = new int[arr.Length]; // размер копии = размер ориг. массива
    for (int left = 0, right = arr.Length - 1; left < reverseArr.Length; left++, right--)
    {
        reverseArr[left] = arr[right]; // reverseArr[0] = arr[1], reverseArr[1] = arr[0]
    }
    return reverseArr;
}

int[] reverse = CopyReverseArray(resultArray);

Console.WriteLine($"Перевернутый массив: [{String.Join("; ", reverse)}]");

// Способ №2. Через вспом. переменную 
void ReverseArray(int[] arr)
{
    for (int i = 0, j = arr.Length - 1; i < arr.Length / 2; i++, j--)
    {
        int temp = arr[i]; // Для массива arr[10,20,30]; temp = arr[0] => temp = 10
        arr[i] = arr[j]; // arr[0] = arr[2]: [arr[2],20,arr[2]] => [30,20,30];
        arr[j] = temp; // [30,20,temp] => temp = 10 => [30,20,10]
    }
}
ReverseArray(resultArray);
Console.WriteLine($"Перевернутый массив: [{String.Join("; ", resultArray)}]");

// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет,
//  может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
int a = 3;
int b = 400;
int c = 5;

bool IsTriangle(int a, int b, int c)
{
    return (((a + b) > c) && ((b + c) > a) && ((a + c) > b));
}
if (IsTriangle(a, b, c)) //IsTriangle(a, b, c) == True
{
    Console.WriteLine("Треугольник существует");
}
else
{
    Console.WriteLine("Треугольник НЕ существует");
}

// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int[] GetFibonacciNumbers(int index)
{
    int[] numbers = new int[index + 1];

    for (int i = 0; i < numbers.Length; i++)
    {
        if (i == 0 || i == 1)
        {
            numbers[i] = i;
        }
        else
        {
            numbers[i] = numbers[i - 1] + numbers[i - 2];
        }
    }

    return numbers;
}

void WriteNumbers(int[] numbers)
{
    Console.WriteLine($"[{string.Join(", ", numbers)}]");
}

var numbers = GetFibonacciNumbers(0);
WriteNumbers(numbers);