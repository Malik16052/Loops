Console.WriteLine("n ededini daxil edin: ");
int ay = int.Parse(Console.ReadLine());
if (ay > 12)
{
    Console.WriteLine("Bele bir ay movcud deyil");
}
switch (ay)
{
    case 1:
        Console.WriteLine("Yanvar");
        break;
    case 2:
        Console.WriteLine("Fevral");
        break;
    case 3:
        Console.WriteLine("Mart");
        break;
    case 4:
        Console.WriteLine("Aprel");
        break;
    case 5:
        Console.WriteLine("May");
        break;
    case 6:
        Console.WriteLine("Iyun");
        break;
    case 7:
        Console.WriteLine("Iyul");
        break;
    case 8:
        Console.WriteLine("Avqust");
        break;
    case 9:
        Console.WriteLine("Sentyabr");
        break;
    case 10:
        Console.WriteLine("Oktyabr");
        break;
    case 11:
        Console.WriteLine("Noyabr");
        break;
    case 12:
        Console.WriteLine("Dekabr");
        break;
}
if (ay < 6 && ay > 2)
{
    Console.WriteLine("Yaz Feslidir");
}

else if (ay < 9 && ay > 5)
{
    Console.WriteLine("Yay Feslidir");
}

else if (ay < 12 && ay > 8)
{
    Console.WriteLine("Payiz Feslidir");
}

else if (ay == 12 || ay == 1 || ay == 2)
{
    Console.WriteLine("Qis Feslidir");
}


