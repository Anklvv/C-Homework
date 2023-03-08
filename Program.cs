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


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int a;
int b;
int c;
int max = 0;

Console.Write($"Введите первое число: ");
int.TryParse(Console.ReadLine(), out a);
Console.Write($"Введите второе число: ");
int.TryParse(Console.ReadLine(), out b);
Console.Write($"Введите третье число: ");
int.TryParse(Console.ReadLine(), out c);

if (a > max)
{
    max = a;
}

if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}
Console.Write(" max = " + max );