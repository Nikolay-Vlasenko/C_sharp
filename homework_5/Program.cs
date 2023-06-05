//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
int[] GenerateArray(int size)
{
    int[] resultArray = new int[size];
    Random rand = new Random();

    for (int i = 0; i < resultArray.Length; i++)    
    {
        resultArray[i] = rand.Next(99,999);
    }
    return resultArray;
}
int[] array = GenerateArray(5);
Console.WriteLine($"Массив: [ {String.Join("; ", array)} ]");
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
       count ++;           
    }
    
}
Console.Write("Количество чётных числе в массиве = " + count);  



//Задача 36: Задайте одномерный массив, 
//заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
int[] GenerateArray(int size)
{
    int[] resultArray = new int[size];
    Random rand = new Random();

    for (int i = 0; i < resultArray.Length; i++)    
    {
        resultArray[i] = rand.Next(1,10);
    }
    return resultArray;
}
int[] array = GenerateArray(10);
Console.WriteLine($"Массив: [ {String.Join("; ", array)} ]");

int sumPositiveNumber = 0;
for (int i = 0; i < array.Length; i++)
{
    if (i % 2== 1)
    {
        sumPositiveNumber += array[i];
    }
   
}
Console.WriteLine($"Сумма элементов находящихся на не чётных позициях = {sumPositiveNumber}");



//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
double [] GenerateArray(int size)
{
    double [] resultArray = new double[size];
    Random rand = new Random();

    for (int i = 0; i < resultArray.Length; i++)    
    {
        resultArray[i] = rand.NextDouble() * 100;
    }
    return resultArray;
}
double [] array = GenerateArray(3);
Console.WriteLine($"Массив: [ {String.Join("; ", array)} ]");

double minimalElement = array[0];
double maximalElement = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > maximalElement)
{
    
        maximalElement = array[i];
}       
    if (array[i] < minimalElement)
 {   
        minimalElement = array[i];
        
 }    
}
double difference = maximalElement - minimalElement;
Console.WriteLine("Разница между максимальным и минимальным элементов массива = " + difference);
Console.WriteLine();
