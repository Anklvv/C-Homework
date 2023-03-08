// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

int a, b;
int max = 0;
int min = 0;

Console.Write($"Введите первое число: ");
int.TryParse(Console.ReadLine(), out a);
Console.Write($"Введите второе число: ");
int.TryParse(Console.ReadLine(), out b);

if (a < b)

{
    max = b;
    min = a;
}

else
{
    max = b;
    min = a;
}
Console.Write($" max = " + max + " а " + " min = " + min);