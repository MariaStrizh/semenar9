/*Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

Console.WriteLine("Введите число M:");
int numberM=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N:");
int numberN=Convert.ToInt32(Console.ReadLine());

/*if (numberN>numberM)
{
    SummaDigits (numberM, numberN);
}
else
{
    Console.WriteLine("M должно быть меньше N");
}*/

int  SummaDigits (int m, int n)
{  
if (n < m) return 0;
return m + SummaDigits(m+1,n);
 }
Console.WriteLine(SummaDigits (numberM, numberN));