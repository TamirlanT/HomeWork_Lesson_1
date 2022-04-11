// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётныечисла от 1 до N. 
int n, i;
string n = Console.ReadLine();

i = 1;
while (i <= n)
{
    if (i % 2 ==0)
        Console.WriteLine($"{i},");
    else
        i++;
i++;
}
Console.WriteLine($"{i}.");