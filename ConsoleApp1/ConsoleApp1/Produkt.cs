namespace ConsoleApp1;

public class Produkt
{
    private string nazwa;
    private double temperatura;

    public Produkt(string nazwa, double temperatura)
    {
        this.nazwa = nazwa;
        this.temperatura = temperatura;
    }

    public double getTemp()
    {
        return temperatura;
    }
    
    public string getNazwa()
    {
        return nazwa;
    }
}