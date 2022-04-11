// Напишите программу, которая принимает навход три числа и выдаёт максимальное из этих чисел.
int a = 44;
int b = 5;
int c = 78;
int i = 0;
if (a > b)
    i = a;
if (b > a)
    i = b;
if (c > a)
    i = c;
if (c > b)
    i = c;
Console.WriteLine($"{i}");
