using System;

public class Hotel
{
    private List<Habitacion> habitaciones = new List<Habitacion>();
    private List<Reserva> reservas = new List<Reserva>();

    public void AgregarHabitacion(Habitacion habitacion)
    {
        habitaciones.Add(habitacion);
    }

    public void MostrarHabitacionesDisponibles()
    {
        Console.WriteLine("Habitaciones disponibles:");
        foreach (var habitacion in habitaciones)
        {
            if (habitacion.Disponible)
            {
                Console.WriteLine($"Habitación {habitacion.Numero} - Capacidad: {habitacion.Capacidad} - Aire Acondicionado: {(habitacion.AireAcondicionado ? "Sí" : "No")}");
            }
        }
    }

    public bool RealizarReserva(int numeroHabitacion, DateTime fecha, int cantidadPersonas)
    {
        Habitacion habitacion = habitaciones.Find(h => h.Numero == numeroHabitacion && h.Disponible);
        if (habitacion != null)
        {
            // Verificar si la cantidad de personas excede la capacidad de la habitación
            if (cantidadPersonas > habitacion.Capacidad)
            {
                Console.WriteLine($"La habitacion reservada excede la cantidad de ({habitacion.Capacidad}) Personas.");
                return false;
            }

            habitacion.Disponible = false;
            Reserva reserva = new Reserva(habitacion, fecha, cantidadPersonas);
            reservas.Add(reserva);
            Console.WriteLine($"Reserva realizada correctamente para la habitación {numeroHabitacion}. Monto a pagar: {reserva.Monto}.");
            return true;
        }
        else
        {
            Console.WriteLine($"La habitación {numeroHabitacion} no está disponible para la fecha seleccionada.");
            return false;
        }
    }
}
