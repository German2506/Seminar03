//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
Console.WriteLine("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
int a = x/10000;
int b = x%10;
int c = (x/1000)%10;
int d = (x%100)/10;
if (a==b & c==d)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}