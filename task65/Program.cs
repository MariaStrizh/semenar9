/*Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
Console.WriteLine("Введите число N:");
int number=Convert.ToInt32(Console.ReadLine());
 PrintNumberstoN (number);
void PrintNumberstoN (int n)
{
if (n < 1) return;
PrintNumberstoN (n-1); // чтобы выводилось в другом порядке надо поменять местами последние 2 строчки
Console.Write(n + " ");
}*/
/*Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 5, 6, 7, 8"*/
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
PrintNumberstoN (n-1,m); // чтобы выводилось в другом порядке надо поменять местами последние 2 строчки
Console.Write(n + " ");
}