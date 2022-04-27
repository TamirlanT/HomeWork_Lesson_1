// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Возьмем число 5 и выведем таблицу кубов от 1 до 5");
int N = 5;
int i = 1;
int sqr;
while (i<=N)
{
    sqr = i*i*i;
    Console.WriteLine($"{sqr}",sqr);
    i++;
}

// число 3
double n = 3;
double index = 1;
double Sqr;
while (index <= n)
{
    Sqr = Math.Pow(index, 3);
    Console.WriteLine($"{Sqr}", Sqr);
    index++;
}
