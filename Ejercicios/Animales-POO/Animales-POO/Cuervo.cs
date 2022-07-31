using System;

public class Cuervo: Aves
{
    public string Comportamiento { get; set; }
    public int PIncubacion { get; set; }

    public void Carnivora()
    {
        Console.WriteLine("Son Carnivoras");
    }
}