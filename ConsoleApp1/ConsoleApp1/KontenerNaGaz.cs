namespace ConsoleApp1;

public class KontenerNaGaz:Kontener, IHazardNotifier
{
    private double cisnienie;
    public KontenerNaGaz(double masaMax, double wysokosc, double wagaWlasna, double glebokosc, double cisnienie)
        : base(masaMax, wysokosc, wagaWlasna, glebokosc, 'G')
    {
        this.cisnienie = cisnienie;
        notify();
    }

    public void notify()
    {
        Console.WriteLine("Uwaga, ładunek niebezpieczny w kontenerze "+nazwa);
        Console.WriteLine();
    }
    
    public void Oproznij()
    {
        masa = masa*0.05;
        Console.WriteLine("Kontener opróżniony");
        Console.WriteLine();
    }
    
}