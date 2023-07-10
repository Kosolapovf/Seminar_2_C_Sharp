/*
Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет
*/


Console.Clear();
Console.Write("Введите число ");
int FirstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число ");
int SecondNumber = Convert.ToInt32(Console.ReadLine());
if (FirstNumber * FirstNumber == SecondNumber || SecondNumber * SecondNumber == FirstNumber)
    Console.WriteLine("Yes");
else
    Console.WriteLine("No");