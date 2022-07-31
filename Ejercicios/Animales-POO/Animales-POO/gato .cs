using System;
public class Gato: Mamifero
{
    public string Pelaje { get; set; }
    public string Raza { get; set; }
    public bool EsDormilon { get; set; }

    public Gato() // Polimorfismo
    {
        EsDormilon = true;
    }

    
    public void Maullar()
    {
        Console.WriteLine("Miau miau miau");

    }

}