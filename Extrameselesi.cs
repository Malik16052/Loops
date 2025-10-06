Console.WriteLine("n mertebeli ededi daxil edin: ");
int a = int.Parse(Console.ReadLine());
int s = 1;
while (a >= 10)
{
    s++;
    a = a / 10;
}

Console.WriteLine("verilmis eded " + s + " mertebelidir.");