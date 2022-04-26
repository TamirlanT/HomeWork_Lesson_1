// Задача 3: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645
int [] array = {6, 4, 5};
Console.WriteLine($"{array[2]}");


// 78
int [] array1 = {7, 8};
Console.WriteLine("3-го числа нет");


// 32769
int [] array2 = {3, 2, 7, 6, 9};
int n = array2.Length;
if (n>2) Console.WriteLine($"{array2[2]}");
else Console.WriteLine("3-го числа нет");