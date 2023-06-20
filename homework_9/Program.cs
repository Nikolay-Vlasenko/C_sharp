// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите число N: ");

int N = Convert.ToInt32(Console.ReadLine());

string GetStringOfNumbers(int start, int end)
{
    if (start == end) return start.ToString();
    return start + ", " + GetStringOfNumbers(start - 1, end);
}
Console.WriteLine($" ''{GetStringOfNumbers(N, 1)}'' ");


// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int GetSumgOfNumbers(int M, int N)
{
    if (M == N) return N;
    else return GetSumgOfNumbers(M + 1, N) + M;
}
Console.WriteLine($" ''{GetSumgOfNumbers(M, N)}'' ");


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int GetСalculationFunctionsAckerman(int M, int N)
{
    if (M == 0) return N + 1;
    if (M > 0 && N == 0) return GetСalculationFunctionsAckerman(M - 1, 1);
    else return GetСalculationFunctionsAckerman(M - 1, GetСalculationFunctionsAckerman(M, N - 1));
}
Console.WriteLine($" ''{GetСalculationFunctionsAckerman(M, N)}'' ");