using System;

struct GPSKonum
{
    public double Enlem { get; private set; }
    public double Boylam { get; private set; }

    public GPSKonum(double enlem, double boylam)
    {
        Enlem = enlem;
        Boylam = boylam;
    }

    public double MesafeHesapla(GPSKonum diğer)
    {
        const double DünyaYarıçapı = 6371; // Kilometre

        double enlemRadyan1 = DereceyiRadyanaDönüştür(Enlem);
        double boylamRadyan1 = DereceyiRadyanaDönüştür(Boylam);
        double enlemRadyan2 = DereceyiRadyanaDönüştür(diğer.Enlem);
        double boylamRadyan2 = DereceyiRadyanaDönüştür(diğer.Boylam);

        double deltaEnlem = enlemRadyan2 - enlemRadyan1;
        double deltaBoylam = boylamRadyan2 - boylamRadyan1;

        double a = Math.Pow(Math.Sin(deltaEnlem / 2), 2) +
                   Math.Cos(enlemRadyan1) * Math.Cos(enlemRadyan2) *
                   Math.Pow(Math.Sin(deltaBoylam / 2), 2);

        double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
        return DünyaYarıçapı * c;
    }

    private static double DereceyiRadyanaDönüştür(double derece)
    {
        return derece * Math.PI / 180;
    }

    static void Main(string[] args)
    {
        GPSKonum konum1 = new GPSKonum(41.0082, 28.9784); // İstanbul
        GPSKonum konum2 = new GPSKonum(40.7128, -74.0060); // New York

        Console.WriteLine($"İstanbul ve New York arasındaki mesafe: {konum1.MesafeHesapla(konum2):F2} km");
    }
}
