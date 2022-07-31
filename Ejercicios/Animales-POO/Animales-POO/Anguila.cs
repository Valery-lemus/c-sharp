using System;

public class AnguilaElectrica: Peces
{
    public string Piel { get; set; }

    public void DescargaElectricas()
    {
        Console.WriteLine("Emplean descargar Electricas para cazar presas");
    }

    public void Peligrosa()
    {
        SonPeligrosa();
    }

    private void SonPeligrosa()
    {
        Console.WriteLine("Son Peligrosas");
    }
}