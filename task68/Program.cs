/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
 Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9 */

Console.WriteLine("Введите число M:");
int numberM=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N:");
int numberN=Convert.ToInt32(Console.ReadLine());

int Akkerman (int m, int n)
{
    if (m<0 || n<0) return 0;
    if (m == 0) return n+1; 
    if (m>0 && n==0) return Akkerman(m-1,1);
    if (m>0 && n>0)  return Akkerman(m-1,Akkerman(m,n-1));
   return 0;
}
Console.WriteLine(Akkerman(numberM, numberN));