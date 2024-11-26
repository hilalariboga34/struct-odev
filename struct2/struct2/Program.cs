using System;

struct KarmaşıkSayı
{
    public double Gerçek { get; private set; }
    public double Sanal { get; private set; }

    public KarmaşıkSayı(double gerçek, double sanal)
    {
        Gerçek = gerçek;
        Sanal = sanal;
    }

    public KarmaşıkSayı Topla(KarmaşıkSayı diğer)
    {
        return new KarmaşıkSayı(Gerçek + diğer.Gerçek, Sanal + diğer.Sanal);
    }

    public KarmaşıkSayı Çıkar(KarmaşıkSayı diğer)
    {
        return new KarmaşıkSayı(Gerçek - diğer.Gerçek, Sanal - diğer.Sanal);
    }

    public override string ToString()
    {
        return $"{Gerçek} + {Sanal}i";
    }

    static void Main(string[] args)
    {
        KarmaşıkSayı sayi1 = new KarmaşıkSayı(3, 4);
        KarmaşıkSayı sayi2 = new KarmaşıkSayı(1, 2);

        KarmaşıkSayı toplam = sayi1.Topla(sayi2);
        KarmaşıkSayı fark = sayi1.Çıkar(sayi2);

        Console.WriteLine($"Karmaşık Sayı 1: {sayi1}");
        Console.WriteLine($"Karmaşık Sayı 2: {sayi2}");
        Console.WriteLine($"Toplam: {toplam}");
        Console.WriteLine($"Fark: {fark}");
    }
}
