using System;

public class Leon: Mamifero
{
    public string Orden { get; set; }
    public string Reproduccion { get; set; }
    public bool SonSalvajes { get; set; }

   public Leon()
   {
      SonSalvajes = true;
   }

   public Leon(bool sonSalvajes)
   {
     SonSalvajes = sonSalvajes;   
   }
   public void Rugir()
   {
       Console.WriteLine("Roar,Roar");
   }
}