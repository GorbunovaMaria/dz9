﻿/*Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1*/
/*
void ShowNumber (int n)
{
    if (n<=0)
    {
    Console.Write("не натуральное число");
    }
    else
    Console.Write (n + " ");
    if (n>1) ShowNumber (n-1);
}
ShowNumber(-3);*/

/*Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/
/*
int ShowSum(int m, int n)
{
    if(n > m)
    return n + ShowSum(m, n - 1);
    else return n;
}
Console.WriteLine(ShowSum(1,15));*/


/*Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/
/*
int Akkerman(int m, int n)
{
    if(m == 0) return n + 1;
    if(n == 0) return Akkerman(m - 1, 1);
    else return Akkerman(m - 1, Akkerman(m, n - 1));
}   
Console.WriteLine(Akkerman(2,3));*/
