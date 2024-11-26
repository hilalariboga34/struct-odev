using System;

struct Zaman
{
    public int Saat { get; private set; }
    public int Dakika { get; private set; }

    public Zaman(int saat, int dakika)
    {
        Saat = (saat >= 0 && saat < 24) ? saat : 0;
        Dakika = (dakika >= 0 && dakika < 60) ? dakika : 0;
    }

    public int ToplamDakika()
    {
        return (Saat * 60) + Dakika;
    }

    public static int ZamanFarki(Zaman z1, Zaman z2)
    {
        return Math.Abs(z1.ToplamDakika() - z2.ToplamDakika());
    }

    public override string ToString()
    {
        return $"{Saat:D2}:{Dakika:D2}";
    }

    static void Main(string[] args)
    {
        Zaman zaman1 = new Zaman(10, 30);
        Zaman zaman2 = new Zaman(12, 15);

        Console.WriteLine($"Zaman 1: {zaman1}");
        Console.WriteLine($"Zaman 2: {zaman2}");
        Console.WriteLine($"Toplam dakika (Zaman 1): {zaman1.ToplamDakika()}");
        Console.WriteLine($"İki zaman arasındaki fark: {Zaman.ZamanFarki(zaman1, zaman2)} dakika");
    }
}
