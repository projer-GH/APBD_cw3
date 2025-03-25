namespace ConsoleApp1;

public class KontenerL:Kontener, IHazardNotifier
{
    private bool czyBezpieczny;
    public KontenerL(double masaMax, double wysokosc, double wagaWlasna, double glebokosc,bool czyBezpieczny)
        : base(masaMax, wysokosc, wagaWlasna, glebokosc, 'L')
    {
        this.czyBezpieczny = czyBezpieczny;
        if(czyBezpieczny == false)
            notify();
        
    }

    public void Zaladuj(double ladunek)
    {
        if (czyBezpieczny == true)
        {
            masaMax = masaMax * 0.9;
        }
        else
        {
            masaMax = masaMax * 0.5;
            
        }
        
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

    public void notify()
    {
        Console.WriteLine("Uwaga, ładunek niebezpieczny w kontenerze "+nazwa+", maksymalna masa załadunku została zredukowana o połowe");
        Console.WriteLine();
    }
}