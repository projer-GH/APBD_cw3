namespace ConsoleApp1;

public class KontenerChlodniczy: Kontener
{
    private Produkt produkt;
    private double temperatura;
    public KontenerChlodniczy(double masaMax, double wysokosc, double wagaWlasna, double glebokosc, Produkt produkt, double temperatura) 
        : base(masaMax, wysokosc, wagaWlasna, glebokosc, 'C')
    {
        this.produkt = produkt;
        this.temperatura = temperatura;
        if (this.temperatura < this.produkt.getTemp())
        {
            Console.WriteLine("Uwaga temperatura w kontenerze jest za niska dla produktu: "+this.produkt.getNazwa());
            Console.WriteLine();
        }
    }
}