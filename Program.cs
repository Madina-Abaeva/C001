﻿// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помошью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int numsum(int a,int b)
{
if (a<=b) return a + numsum(a+1,b);
return 0;
}
Console.WriteLine(numsum(1,15));