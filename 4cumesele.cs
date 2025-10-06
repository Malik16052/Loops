Console.WriteLine("n mertebeli ededi daxil edin: ");
int a = int.Parse(Console.ReadLine());
while (a >= 10)
{
    a = a / 10;
}

Console.WriteLine(a);
