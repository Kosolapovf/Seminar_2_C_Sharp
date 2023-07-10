/*
Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

34, 5 -> не кратно, остаток 4
16, 4 -> кратно
*/


Console.Clear();
/*
int n = new Random().Next(0, );
Console.WriteLine(n);
int n1 = n / 100;
int n3 = n % 10;
Console.WriteLine(n1*10 + n3);
*/
Console.Write("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число ");
int b = Convert.ToInt32(Console.ReadLine());
int n = a % b;
if (n == 0)
    Console.WriteLine($"{a}, {b} -> кратно");
else    
    Console.WriteLine($"{a}, {b} -> не кратно, остаток {n}");

