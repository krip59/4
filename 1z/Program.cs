//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.Clear();
Console.WriteLine("Введите пятизначное число");
int b = int.Parse(Console.ReadLine());
int a = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());
int f = int.Parse(Console.ReadLine());
c=b/10000;
a=b%10000;
f=b/1000-b/1000%10;
m=(b-b%10000)/10%100;
if (b<9999 && b>100000){Console.WriteLine("Вы ввели не пятизначное число");
return; }
if ((a = c) && (m = f))
{Console.WriteLine("Число является палидромом");}
else {Console.WriteLine("Число является не палидромом");} 