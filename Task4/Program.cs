// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int x = 0;

while (x <= num)
{
if (x % 2 == 0) 
Console.WriteLine($"{x}");
x = x + 2;
}
//