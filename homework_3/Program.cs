//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= N; i++)
{
Console.Write(Math.Pow(i, 3) + "\t");
}

//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Write("Введите координату х1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату у1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату х2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату у2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());
double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)+ Math.Pow(z2 - z1, 2));
Console.WriteLine($"Расстояние между точками А:({x1},{y1}) и В:({x2},{y2}) и Z:({z2},{z1})  равно: {Math.Round(d,2)}");

//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
Console.Write("Введите число: ");
var number = Convert.ToString(Console.ReadLine());
    if (number!.Length == 5){
        if (number[0]==number[4] || number[1]==number[3]){
        Console.WriteLine($"Ваше число: {number} - палиндром.");
         }
        else Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
    }
    else Console.WriteLine("Введите пятизначное число");
