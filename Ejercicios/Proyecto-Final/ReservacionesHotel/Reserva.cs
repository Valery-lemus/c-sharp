using System;
using System.Collections.Generic;


    public class Reservar
{
    public List<Habitaciones> ListadeHabitaciones { get; set; }
    public List<Restaurante> MenuedeRestaurante { get; set; }
    public List<Clientela> ListadeClientes { get; set; }
    public List<CrearReserva> ListadeReservas { get; set; }
    

 
 public Reservar()
 {
     ListadeHabitaciones = new List<Habitaciones>();
     cargarHabitaciones();
     MenuedeRestaurante = new List<Restaurante>();
     cargarMenu();
     ListadeClientes = new List<Clientela>();
     cargarClientes();
     ListadeReservas = new List<CrearReserva>();
 }

 public void cargarHabitaciones(){
     Habitaciones r1 = new Habitaciones(1, 5, "Sencilla", 980, "1");
     ListadeHabitaciones.Add(r1);

     Habitaciones r2 = new Habitaciones(2, 5, "Doble", 1200, "2");
     ListadeHabitaciones.Add(r2);

     Habitaciones r3 = new Habitaciones(3, 5, "Triple", 1600, "3");
     ListadeHabitaciones.Add(r3);

     Habitaciones r4 = new Habitaciones(4, 5, "Cuadruple", 2300, "4");
     ListadeHabitaciones.Add(r4);

     Habitaciones r5 = new Habitaciones(5, 5, "Suite", 5000, "5");
     ListadeHabitaciones.Add(r5);

     Habitaciones r6 = new Habitaciones(6, 4, "Sencilla", 980, "6");
     ListadeHabitaciones.Add(r6);

     Habitaciones r7 = new Habitaciones(7, 4, "Presidencial", 10000, "7");
     ListadeHabitaciones.Add(r7);

     Habitaciones r8 = new Habitaciones(8, 4, "Doble", 1200, "8");
     ListadeHabitaciones.Add(r8);

     Habitaciones r9 = new Habitaciones(9, 4, "Triple", 1600, "9");
     ListadeHabitaciones.Add(r9);

     Habitaciones r10 = new Habitaciones(10, 4, "Cuadruple", 2300, "10");
     ListadeHabitaciones.Add(r10);

     Habitaciones r11 = new Habitaciones(11, 3, "Triple", 1600, "11");
     ListadeHabitaciones.Add(r11);

     Habitaciones r12 = new Habitaciones(12, 3, "Doble", 1200, "12");
     ListadeHabitaciones.Add(r12);

     Habitaciones r13 = new Habitaciones(13, 3, "Suite", 5000, "13");
     ListadeHabitaciones.Add(r13);

     Habitaciones r14 = new Habitaciones(14, 3, "Sencilla", 980, "14");
     ListadeHabitaciones.Add(r14);

     Habitaciones r15 = new Habitaciones(15, 3, "Cinco Estrellas", 8000, "15");
     ListadeHabitaciones.Add(r15);
 
 }

 public void listarHabitaciones(){
     Console.Clear();
     Console.WriteLine("Habitaciones Disponibles");
     Console.WriteLine("************************");
     Console.WriteLine("Habitacion | Piso | Tipo | Precio");
     Console.WriteLine("");

     foreach (var habitacion in ListadeHabitaciones)
        {
            Console.WriteLine(habitacion.Numero + " | " + habitacion.Piso + " | " + habitacion.Tipo + " | " + habitacion.Precio);
        }  
        Console.ReadLine();
     }

  public void cargarMenu(){
      Restaurante menu1 = new Restaurante("Jugo de Naranja", 30, "Almuerzo Completo", 70,  "Boneles", 50);
      MenuedeRestaurante.Add(menu1);
      Restaurante menu2 = new Restaurante("Baliada Sencilla", 10, "Hamburguesa Sencilla", 65,  "Parrillada 2 personas", 300);
      MenuedeRestaurante.Add(menu2);
      Restaurante menu3 = new Restaurante("Baleada con Pollo", 15, "Ensalada de Frutas", 50,  "Cena de Lujo", 2000);
      MenuedeRestaurante.Add(menu3);
      Restaurante menu4 = new Restaurante("Cafe", 10, "Pizza", 100,  "Cena Sencilla", 70);
      MenuedeRestaurante.Add(menu4);
  }

  public void menuRestaurante(){
     Console.Clear();
     Console.WriteLine("Menu Restaurante Lunamar");
     Console.WriteLine("************************");
     Console.WriteLine("Desayuno | Precio | Almuerzo | Precio | Cena | Precio");
     Console.WriteLine("");

     foreach (var servicio in MenuedeRestaurante)
        {
            Console.WriteLine( servicio.Desayuno + " | " + servicio.Saldo1 + " | " + servicio.Almuerzo + " | " + servicio.Saldo2 + " | " + servicio.Cena + " | " + servicio.Saldo3);
        }  
        Console.ReadLine();
     }
   
    public void cargarClientes(){
        Clientela c1 = new Clientela(001, 110, "Maricela", "Sanchez", 99881522, "1");
        ListadeClientes.Add(c1);
        Clientela c2 = new Clientela(002, 111, "Antonia", "Munguia", 98788855, "2");
        ListadeClientes.Add(c2);
        Clientela c3 = new Clientela(003, 112, "Yahir", "Colindres", 97781214, "3");
        ListadeClientes.Add(c3);
        Clientela c4 = new Clientela(004, 113, "Mayerling", "Mejia", 33532334, "4");
        ListadeClientes.Add(c4);
        Clientela c5 = new Clientela(005, 114, "Eugenia", "Lopez", 32910034, "5");
        ListadeClientes.Add(c5);
    }

    public void listarClientes(){
     Console.Clear();
     Console.WriteLine("   Lista de Clientes  ");
     Console.WriteLine("************************");
     Console.WriteLine(" Codigo | Identidad | Nombre | Apellido | Telefono ");
     Console.WriteLine("");
     
     foreach (var cliente in ListadeClientes)
     {
         Console.WriteLine(cliente.Codigo + " | " + cliente.ID + " | " + cliente.Nombre + " | " + cliente.Apellido + " | " + cliente.Telefono);
     }
     
     
     Console.ReadLine();

    }

    public void asignarReserva(){
        Console.WriteLine("Creando Reserva");
        Console.WriteLine("****************");
        Console.WriteLine("");

        
        Console.WriteLine("Ingrese el codigo del cliente: ");
        string codigocliente = Console.ReadLine();

        Clientes clientess = ListadeClientes.Find(c => c.Codigo.ToString() == codigocliente);        
        if (clientess == null)
        {
            Console.WriteLine("Cliente no encontrado");
            Console.ReadLine();
            return;
        } else {
            Console.WriteLine("Cliente: " + clientess.Nombre + " | " + clientess.Apellido);
            Console.WriteLine("");
        }

         Console.WriteLine("Ingrese el numero de habitacion: ");
        string codigoHabitacion = Console.ReadLine();

        Habitaciones habitacion = ListadeHabitaciones.Find(v => v.Numero.ToString() == codigoHabitacion);
        if (habitacion == null) 
        {
            Console.WriteLine("Habitacion no encontrada");
            Console.ReadLine();
            return;
        } else {
            Console.WriteLine("Habitacion: " + " Numero: "  + habitacion.Numero + " | " + "Piso: " + habitacion.Piso + " | " + "Tipo: " + habitacion.Tipo + " | " + "Saldo: " + habitacion.Precio);
            Console.WriteLine("");
            Console.ReadLine();
        }     
    }


}