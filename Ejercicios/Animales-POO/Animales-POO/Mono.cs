using System;

public class Mono: Mamifero
{
    public string Orden { get; set; }
    public string Reproduccion { get; set; }
    public bool SonViolentos { get; set; }

   public Mono()
   {
      SonViolentos = true;
   }

   public void Aullar()
   {
       Console.WriteLine("Uuaa uuaa uuaa");
   }
}