namespace ConsoleApp1;

public abstract class Kontener
{
    protected double masaMax;
    protected double wysokosc;
    protected double waga;
    protected double glebokosc;
    protected static int numer = 0;
    protected char rodzaj;
    protected double masa;
    protected string nazwa;
    protected int nr;
    

    public Kontener(double masaMax, double wysokosc, double wagaWlasna, double glebokosc,char rodzaj)
    {
        this.masaMax = masaMax;
        this.wysokosc = wysokosc;
        this.waga = wagaWlasna;
        this.glebokosc = glebokosc;
        this.rodzaj = rodzaj;
        numer = numer + 1;
        nr = numer;
        masa = 0;
        nazwa = "KON-" + this.rodzaj + "-" + numer;
    }

    public void Oproznij()
    {
        masa = 0;
        Console.WriteLine("Kontener opróżniony");
        Console.WriteLine();
    }

    public void Zaladuj(double ladunek)
    {
        masa += ladunek;
        try
        {

            if (masa > masaMax)
                throw new OverfilledException();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            masa = 0;
        }
        
        Console.WriteLine("Kontener załadowany");
        Console.WriteLine();
    }

    public void PrzedstawSie()
    {
        Console.WriteLine(nazwa);
        
    }

    public int getNumber()
    {
        return nr;
    }
    
}