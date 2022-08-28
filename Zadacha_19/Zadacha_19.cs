// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

 Console.Write ("введите пятизначное число N: ");
    string N = Console.ReadLine();
    int dlina = N.Length;
    int K = Convert.ToInt32 (N);
    int n1 = K/10000;
    int n2 = (K/1000) % 10;
    int n4 = (K/10) % 10;
    int n5 = K % 10;

if (dlina == 5)
{
    if ((n1 == n5) && (n2 == n4)) Console.WriteLine("Да");
    else Console.WriteLine ("Нет");
}
else Console.WriteLine ("Нужно пятизначное число");