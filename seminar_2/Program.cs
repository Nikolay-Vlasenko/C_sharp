﻿void GenNumbers(int[] arr)
        {
            Random rnd = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(10, 100);
            }
        }


        int[] arr = new int[10];

        GenNumbers(arr);

            for (int i = 0; i<arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

int[] arr1 = new int[10]; // { 0,0,0,0,0,0....}

            GenNumbers(arr); // { 15,15,64,16,83....}

            for (int i = 0; i < arr1.Length; i++) // 0 = 15
            {
                int left = arr1[i] / 10; // 15 / 10 = 1
                int right = arr1[i] % 10; // 15 % 10 = 5
                if (left > right)
                {
                    Console.WriteLine($"Наибольшая цифра числа {arr1[i]} = " + left);
                }
                else
                {
                    Console.WriteLine($"Наибольшая цифра числа {arr1[i]} = " + right);
                }
            }


Random rnd = new Random();
            int rndNum = rnd.Next(10, 100); // 10 - 99
            // 5 6
            int a = rndNum % 10; // 4
            int b = rndNum / 10;
            if (a > b)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(b);
            }



            int a1 = int.Parse(Console.ReadLine()); // Convet.ToInt32() = int.Parse()
            int b1 = int.Parse(Console.ReadLine()); // Convet.ToInt32() = int.Parse()
            if (b1 % a1 == 0)
            {
                Console.WriteLine("Кратное");
            }
            else
            {
                Console.WriteLine(b1 % a1);
            }

            int rndNum1 = rnd.Next(100, 1000); // array 100-999
Console.WriteLine(rndNum1);

int a2 = rndNum / 100; // 
int c = rndNum % 10; //
int res = 10 * a2 + c;
Console.Write(res);