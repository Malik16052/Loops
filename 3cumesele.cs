
Console.WriteLine("n ededini daxil edin: ");
int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    if (n % i == 0)
    {
        int bolen = i;
        Console.WriteLine(i);
    }
}
