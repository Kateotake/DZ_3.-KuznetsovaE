﻿// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

 Console.Write ("введите целое число N ");
    int N = Convert.ToInt32(Console.ReadLine());
    int k = 0;
     while (k <= N)
    {  
         int res = k*k*k;
         Console.Write ($"{res}, ");
         k++;
    }     