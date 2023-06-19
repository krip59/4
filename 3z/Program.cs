Console.Clear();
Console.Write ("Введите N:");
int N = int.Parse(Console.ReadLine());
int i = 1;
if (N<i)
{
Console.Write("Введено неверное значение");
return;
}

while (i<=N)
{
    Console.WriteLine($"{Math.Pow (i,3)}");
i++;
};
Console.WriteLine ("");