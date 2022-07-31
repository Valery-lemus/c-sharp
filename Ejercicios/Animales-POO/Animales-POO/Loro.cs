using System;

public class Loro: Aves
{
    public string Orden { get; set; }
    public string Familia { get; set; }

    public void Hablan()
    {
        Console.WriteLine("Los Loros Hablan");
    }

    public void Pico()
    {
        DescribirPico();
    }

    private void DescribirPico()
    {
        Console.WriteLine("Son de Pico fuerte");
    }

}