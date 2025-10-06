Console.WriteLine("x ededini daxil edin: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("y ededini daxil edin: ");
int y = int.Parse(Console.ReadLine());
int s = 0;
for (int i = 0; i < x; i++)
{
    if (i % y == 0)
    {
        s = i;
    }
}
if (s == 0)
{
    Console.WriteLine("-1");
}
else
{
    Console.WriteLine(s);
}