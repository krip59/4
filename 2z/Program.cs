﻿Console.Clear();
Console.Write("Введите x1:");
Double x1 = Double.Parse(Console.ReadLine());
Console.Write("Введите y1:");
Double y1 = Double.Parse(Console.ReadLine());
Console.Write("Введите z1:");
Double z1 = Double.Parse(Console.ReadLine());
Console.Write("Введите x2:");
Double x2 = Double.Parse(Console.ReadLine());
Console.Write("Введите y2:");
Double y2 = Double.Parse(Console.ReadLine());
Console.Write("Введите z2:");
Double z2 = Double.Parse(Console.ReadLine());
Double d = Math.Sqrt(Math.Pow(x1-x2,2) + Math.Pow(y1-y2,2) + Math.Pow(z1-z2,2));
Console.WriteLine($"d={d:f2}");