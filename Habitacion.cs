using System;
using System.Security.Cryptography.X509Certificates;

public class Habitacion
{
    public int Numero { get; set; }
    public int Capacidad { get; set; }
    public bool AireAcondicionado { get; set; }
    public bool Disponible { get; set; }

    public Habitacion(int numero, int capacidad, bool aireAcondicionado)
    {
        
        Numero = numero;
        Capacidad = capacidad;
        AireAcondicionado = aireAcondicionado;
        Disponible = true;
    }
}
