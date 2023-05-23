//Задача N1
//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3
Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber > secondNumber)
{
    Console.WriteLine(firstNumber + " является максимальным");

}
else
{
    Console.WriteLine(secondNumber + " является максимальным");
}



//Задача №2
//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
Console.Write("Введите первое число: ");
int firstNumber1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNumber1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber > secondNumber)
    {   
        if (firstNumber1 > thirdNumber)
        {
            Console.WriteLine(firstNumber1 + " является максимальным");
        }
        else 
        {
            Console.WriteLine(thirdNumber + " является максимальным");
        }
    }
    else
    {
        if (secondNumber1 > thirdNumber)
        {
            Console.WriteLine(secondNumber1 + " является максимальным");
        }
        else 
        {
            Console.WriteLine(thirdNumber + " является максимальным");
        }
    }



//Задача  №3
//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет
Console.Write("Введите чётное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0 )
{
   Console.WriteLine(number + " число является чётным");
}
else
{
    Console.WriteLine("Вы ввели не чётное число");
}

//Задача №4
//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int negativeN = (N / N) + 1; 
while (negativeN <= N)
{
    Console.WriteLine(negativeN);
    negativeN = negativeN + 2;
}