using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        Hotel hotelCandelaria = new Hotel();
        hotelCandelaria.AgregarHabitacion(new Habitacion(01, 2, true));
        hotelCandelaria.AgregarHabitacion(new Habitacion(02, 2, true));
        hotelCandelaria.AgregarHabitacion(new Habitacion(03, 3, true));
        hotelCandelaria.AgregarHabitacion(new Habitacion(04, 3, true));
        hotelCandelaria.AgregarHabitacion(new Habitacion(05, 4, true));
        hotelCandelaria.AgregarHabitacion(new Habitacion(06, 2, false));
        hotelCandelaria.AgregarHabitacion(new Habitacion(07, 2, false));
        hotelCandelaria.AgregarHabitacion(new Habitacion(08, 3, false));
        hotelCandelaria.AgregarHabitacion(new Habitacion(09, 3, false));
        hotelCandelaria.AgregarHabitacion(new Habitacion(10, 4, false));

        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("-----------------------------------------------------------------------------");
        Console.WriteLine("**********************BIENVENIDO AL HOTEL LA CANDELARIA**********************");
        Console.WriteLine("-----------------------------------------------------------------------------");
        while (true)
        {
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("\n1. Ver habitaciones disponibles");
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("2. Realizar reserva");
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("3. Salir");
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.Write("Seleccione una opción: ");
            int opcion = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-----------------------------------------------------------------------------");


            switch (opcion)
            {
                case 1:
                    hotelCandelaria.MostrarHabitacionesDisponibles();
                    break;
                case 2:
                    
                    Console.Write("\nIngrese el número de habitación: ");
                    int numeroHabitacion = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("-----------------------------------------------------------------------------");
                    Console.Write("Ingrese la fecha de reserva (yyyy-MM-dd): ");
                    DateTime fechaReserva = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("-----------------------------------------------------------------------------");
                    Console.Write("Ingrese la cantidad de personas: ");
                    int cantidadPersonas = Convert.ToInt32(Console.ReadLine());
                    hotelCandelaria.RealizarReserva(numeroHabitacion, fechaReserva, cantidadPersonas);
                    Console.WriteLine("-----------------------------------------------------------------------------");
                    break;
                case 3:
                    Console.WriteLine("¡Gracias por utilizar nuestro sistema de reservas!");
                    return;
                default:
                    Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.");
                    break;
            }
        }
    }
}