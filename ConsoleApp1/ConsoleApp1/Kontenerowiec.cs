namespace ConsoleApp1;

public class Kontenerowiec
{
    private Kontener[] kontenery;

    private string NazwaStatku;

    private double MaxPredkosc;
    private int MaxKontenerow;
    private double MaxWaga;
    private int at = 0;


    public Kontenerowiec(string nazwaStatku,double maxPredkosc, int maxKontenerow, double maxWaga)
    {
        NazwaStatku = nazwaStatku;
        MaxPredkosc = maxPredkosc;
        MaxKontenerow = maxKontenerow;
        MaxWaga = maxWaga;

        kontenery = new Kontener[maxKontenerow];
    }

    public void ZaladujNaStatek(Kontener kon)
    {
        if (MaxKontenerow <= at)
        {
            Console.WriteLine("Załadowano już maksymalną ilość kontenerów");
        }else{
            kontenery[at] = kon;
                      at++;
                      
        }
        
        
    }

    public void usunKontenerZeStatku()
    {
        if (at != 0)
        {
            at--;
            kontenery[at] = null;
        }
        else
        {
            Console.WriteLine("Na statku nie ma kontenerów");
        }
    }

    public void ZastapKontener(Kontener kontener,int numer)
    {
        for (int i = 0; i < kontenery.Length; i++)
        {
            if(kontenery[i]!=null)
            if (kontenery[i].getNumber() == numer)
            {
                kontenery[i] = kontener;
                Console.WriteLine("Zastąpiono kontenery");
                Console.WriteLine();
            }
        } 
    }

    public void WypiszInformacjeOLadunku()
    {
        Console.WriteLine(NazwaStatku+": ");

        if (at == 0)
        {
            Console.WriteLine("Kontenerowiec pusty");
        }
        else
        {

            for (int i = 0; i < kontenery.Length; i++)
            {
                if (kontenery[i] != null)
                    kontenery[i].PrzedstawSie();
            }
        }
        
        Console.WriteLine();
    }
    
    
    public void ZaladujNaStatek(Kontener[] tab)
    {
        if (MaxKontenerow < at+tab.Length)
        {
            Console.WriteLine("Załadowano już maksymalną ilość kontenerów");
        }

        for (int i = 0; i < tab.Length; i++)
        {
            kontenery[at] = tab[i];
            at++;
        }
    }


    public Kontener getKontener(int num)
    {
        Kontener k = null;

        for (int i = 0; i < kontenery.Length; i++)
        {
            if (kontenery[i].getNumber() == num)
            {
                k = kontenery[i];
                kontenery[i] = null;
            }
            
        }
        
        NaprawKolejnosc();

        return k;

    }


    public void NaprawKolejnosc()
    {
        Kontener[] tmp = new Kontener[kontenery.Length];
        int count = 0;
        for (int i = 0; i < kontenery.Length; i++)
        {
            if (kontenery[i] != null)
            {
                tmp[count] = kontenery[i];
                count++;
            }
            
        }

        at = count;

        kontenery = tmp;
    }
    
    
}