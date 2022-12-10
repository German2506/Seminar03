//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
//A (0,0); B (1,1), -> ~1.4
//A (2,4); B (0,7) -> ~3.6

Console.WriteLine("Введите число xa");
int xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число ya");
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число xb");
int xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число yb");
int yb = Convert.ToInt32(Console.ReadLine());

int A = xb - xa;
int B = yb - ya;

double distance = Math.Sqrt(A * A + B * B);
Console.Write("Расстояние = ");
Console.WriteLine(Math.Round(distance,1));