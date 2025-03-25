using ConsoleApp1;

public class Program
{
    public static void Main(string[] args)
    {

        Kontenerowiec kontenerowiec1 = new Kontenerowiec("Kontenerowiec 1",20, 10, 300);
        
        
        KontenerL k = new KontenerL(2.3, 12.2, 12.3, 11.2,true);
        k.PrzedstawSie();
        KontenerL k1 = new KontenerL(10, 12.2, 12.3, 11.2,false);
        k1.Zaladuj(5);
        k1.Oproznij();

        KontenerNaGaz g = new KontenerNaGaz(10, 22, 12, 12, 1212);

        Kontener[] kontenery = new Kontener[]{
            new KontenerChlodniczy(23,123,34,34,new Produkt("Banany",-5),-5),
            new KontenerL(2.3, 12.2, 12.3, 11.2,true),
            new KontenerL(2.3, 12.2, 12.3, 11.2,true),
            new KontenerL(2.3, 12.2, 12.3, 11.2,true),
            new KontenerL(2.3, 12.2, 12.3, 11.2,true),
            new KontenerL(2.3, 12.2, 12.3, 11.2,true),
            new KontenerL(2.3, 12.2, 12.3, 11.2,true),
            new KontenerL(2.3, 12.2, 12.3, 11.2,true)
            
        };
        
        kontenerowiec1.ZaladujNaStatek(k);
        kontenerowiec1.ZaladujNaStatek(k1);
        kontenerowiec1.WypiszInformacjeOLadunku();
        
        kontenerowiec1.ZastapKontener(g,2);
        
        kontenerowiec1.WypiszInformacjeOLadunku();
        
        
        kontenerowiec1.ZaladujNaStatek(kontenery);
        kontenerowiec1.WypiszInformacjeOLadunku();
        
        kontenerowiec1.usunKontenerZeStatku();
        
        kontenerowiec1.WypiszInformacjeOLadunku();
        
        kontenerowiec1.ZaladujNaStatek(new KontenerChlodniczy(2,2,12,32,new Produkt("Pomidory",-10),-11));
        kontenerowiec1.WypiszInformacjeOLadunku();

        Kontenerowiec kontenerowiec2 = new Kontenerowiec("ststek2", 20, 10, 500);
        kontenerowiec2.WypiszInformacjeOLadunku();
        
        PrzeniesKontenerMiedzyStstkami(kontenerowiec1,kontenerowiec2,8);
        
        kontenerowiec1.WypiszInformacjeOLadunku();
        kontenerowiec2.WypiszInformacjeOLadunku();
        
        kontenerowiec1.ZaladujNaStatek(k);
        kontenerowiec1.WypiszInformacjeOLadunku();





        static void PrzeniesKontenerMiedzyStstkami(Kontenerowiec statek1, Kontenerowiec statek2, int numerKontenera)
        {
            Kontener k = statek1.getKontener(numerKontenera);
            statek2.ZaladujNaStatek(k);
            Console.WriteLine("Kontener przeniesiony");
            Console.WriteLine();
        }
    }
}
