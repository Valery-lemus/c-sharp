using System;

public class Aguila: Aves
{
    public string Comportamiento { get; set; }
    public int PIncubacion { get; set; }

    public void Carnivora()
    {
        Console.WriteLine("Son Carnivoras");
    }
}