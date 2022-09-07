/* Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

Console.WriteLine("Введите число M:");
int numberM=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N:");
int numberN=Convert.ToInt32(Console.ReadLine());

if (numberN>numberM)
{
    PrintNumberstoN (numberN, numberM);
}
else
{
    Console.WriteLine("M должно быть меньше N");
}

void PrintNumberstoN (int n, int m)
{
if (n < m) return;
Console.Write(n + " ");
PrintNumberstoN (n-1,m); // чтобы выводилось в другом порядке надо поменять местами последние 2 строчки
}