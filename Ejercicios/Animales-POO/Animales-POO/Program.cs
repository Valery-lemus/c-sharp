using System;

namespace animales
{
    class Program
    {
        static void Main(string[] args)
        {
            Perro p = new Perro();
            Console.WriteLine("Perro");
			Console.WriteLine("*****");
            p.Nombre = "Polar";
            p.Patas = 4;
            p.EsDomestico = true;
            p.Comer();
            p.Caminar();
            p.Ladrar();
            p.Tamano();

            Console.WriteLine(p.Nombre);
            Console.WriteLine(p.Patas);

            Console.WriteLine();

            Gato g = new Gato();
            Console.WriteLine("Gato");
			Console.WriteLine("****");
            g.Nombre = "Copito";
            g.Patas = 4;
            g.Pelaje = "Peludo";
            g.Raza = "Angora";
            g.Comer();
            g.Caminar();
            g.Maullar();
            g.EsDormilon = true;

            Console.WriteLine(g.Nombre);
            Console.WriteLine(g.Patas);
            Console.WriteLine(g.Pelaje);
            Console.WriteLine(g.Raza);         

            Console.WriteLine();

			Leon y = new Leon();
			Console.WriteLine("Leon");
			Console.WriteLine("****");
            y.Nombre = "Simba";
			y.Patas = 4;
            y.Comer();
            y.Caminar();
            y.Rugir();
            y.SonSalvajes = true;

			Console.WriteLine(y.Nombre);
            Console.WriteLine(y.Patas);        

            Console.WriteLine();

            Mono m = new Mono();
            Console.WriteLine("Mono");
			Console.WriteLine("****");
            m.Nombre = "Jorge";
            m.Patas = 4;
            m.Orden = "Primates";
            m.Reproduccion = "Viviparo";
            m.Comer();
            m.SonViolentos = true;
            m.Caminar();
            m.Aullar();

            Console.WriteLine(m.Nombre);
            Console.WriteLine(m.Patas);
            Console.WriteLine(m.Orden);
            Console.WriteLine(m.Reproduccion);

            Console.WriteLine();

            Aguila a = new Aguila();
            Console.WriteLine("Aguila");
			Console.WriteLine("******");
            a.Nombre = "Eagle";
            a.Patas = 2;
            a.PIncubacion = 20;
            a.ColorPlumaje = "marron";
            a.Volar();
            a.Comer();
            a.Carnivora();

            Console.WriteLine(a.Nombre);
            Console.WriteLine(a.PIncubacion);
            Console.WriteLine(a.Patas);
            Console.WriteLine(a.ColorPlumaje);

            Console.WriteLine();

			Cuervo c = new Cuervo();
            Console.WriteLine("Cuervo");
			Console.WriteLine("******");
            c.Nombre = "Raven";
            c.Patas = 2;
            c.PIncubacion = 20;
            c.ColorPlumaje = "Negro";
            c.Volar();
            c.Comer();
            c.Carnivora();

            Console.WriteLine(c.Nombre);
            Console.WriteLine(c.PIncubacion);
            Console.WriteLine(c.Patas);
            Console.WriteLine(c.ColorPlumaje);

            Console.WriteLine();

            Loro l = new Loro();
            Console.WriteLine("Loro");
			Console.WriteLine("****");
            l.Nombre = "rosita";
            l.Patas = 2;
            l.ColorPlumaje = "Verde";
            l.Comer();
            l.Volar();
            l.Hablan();
            l.Pico();

            Console.WriteLine(l.Nombre);
            Console.WriteLine(l.Patas);
            Console.WriteLine(l.ColorPlumaje);

            Console.WriteLine();

            PezGlobo x = new PezGlobo();
            Console.WriteLine("Pez Globo");
			Console.WriteLine("*********");
            x.Nombre = "Chester";
            x.Piel = "Aspera de punta";
            x.NumeroAletas = 2;
            x.Comer();
            x.Nadar();
            x.Color = "Amarillo Verdoso con Manchas negras";
            x.Venenosa();
            x.Inflarse();

            Console.WriteLine(x.Nombre);
            Console.WriteLine(x.NumeroAletas);
            Console.WriteLine(x.Piel);
            Console.WriteLine(x.Color);

			Console.WriteLine();

			AnguilaElectrica e = new AnguilaElectrica();
            Console.WriteLine("Anguila Electrica");
			Console.WriteLine("*****************");
            e.Nombre = "Eel";
            e.Piel = "Aspera de punta";
            e.NumeroAletas = 2;
            e.Comer();
            e.Nadar();
            e.Color = "Amarillo Verdoso con Manchas negras";
            e.Peligrosa();
            e.DescargaElectricas();

            Console.WriteLine(e.Nombre);
            Console.WriteLine(e.NumeroAletas);
            Console.WriteLine(e.Piel);
            Console.WriteLine(e.Color);
            }
        }
}