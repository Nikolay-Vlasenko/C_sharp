//Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1
Random random = new Random();
int randomNum = random.Next(100, 1000);
Console.WriteLine(randomNum);
int a = randomNum % 100;
int result = a / 10;
Console.WriteLine(result);
        


//Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
void GenNumbers(int[] arr)
    {
        Random rnd = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next(100, 1000);
        }
    }
int[] arr = new int[10];
GenNumbers(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 99)
                {
                    int thirdNumber = (arr[i] % 10) / 1;
                    Console.WriteLine($"Третья цифра заданного числа {arr[i]} = " + thirdNumber);
                }
                else
                {
                    Console.WriteLine($"Вы ввели двухзначное число {arr[i]}");
                }
            }



//Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
Console.Write("Введите день недели: ");
int day = Convert.ToInt32(Console.ReadLine());
int day_off1 = 6;
int day_off2 = 7;
if (day == day_off1 || day == day_off2)
{
    Console.WriteLine(day + " день является выходным");
}
else
{
    Console.WriteLine(day + " день не является выходным");
}