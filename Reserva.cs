using System;

public class Reserva

{
    public Habitacion Habitacion { get; set; }
    public DateTime Fecha { get; set; }
    public int CantidadPersonas { get; set; }
    public double Monto { get; set; }

    public Reserva(Habitacion habitacion, DateTime fecha, int cantidadPersonas)
    {
        Habitacion = habitacion;
        Fecha = fecha;
        CantidadPersonas = cantidadPersonas;
        Monto = CalcularMonto();
    }

    private double CalcularMonto()
    {

        double montoBase = 50000; 
        if (Habitacion.AireAcondicionado)
        {
            montoBase = 70000; 
        }
        return montoBase;
    }
}
