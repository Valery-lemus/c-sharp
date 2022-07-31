using System;

public class PezGlobo: Peces
{
    public string Piel { get; set; }

    public void Inflarse()
    {
        Console.WriteLine("Se Inflan");
    }

    public void Venenosa()
    {
        SonVenenosa();
    }

    private void SonVenenosa()
    {
        Console.WriteLine("Son Venenosas");
    }
}