// Найти расстояние между точками в 3д пространстве
Console.WriteLine("Рассчет расстояние между точками A(3,6,8) и B(2,1,-7) в 3д пространстве");

double xa = 3;
double ya = 6;
double za = 8;
double xb = 2;
double yb = 1;
double zb = -7;
double S =(xa - xb) * (xa - xb) + (ya - yb) * (ya - yb) + (za - zb) * (za -zb);
S = Math.Sqrt(S);
Console.WriteLine($" {S:f} ");

// Заданы точки С(7,-5,0) и D (1,-1,9)
Console.WriteLine("Рассчитываю расстояние между C и D");
Console.WriteLine("Смотри что получилось!");
double xc = 7;
double yc = -5;
double zc = 0;
double xd = 1;
double yd = -1;
double zd = 9;

double N =((xc - xd) * (xc - xd)) + ((yc - yd) * (yc - yd)) + ((zc - zd) * (zc - zd));
N = Math.Sqrt(N);
Console.WriteLine($"Расстояние между точками {N:f}");
