/*Crea una estructura de datos para un cliente con estos campos:

Nombre completo

Teléfono

Dirección

Email

Si es nuevo cliente*/

using System;

struct Cliente
{
    public string NombreCompleto;
    public string Telefono;
    public string Direccion;
    public string Email;
    public bool EsNuevoCliente;
}

class Program
{
    static void Main()
    {
        Cliente cliente1;
        cliente1.NombreCompleto = "Juan Perez";
        cliente1.Telefono = "1234567890";
        cliente1.Direccion = "Calle Principal 123";
        cliente1.Email = "juan@example.com";
        cliente1.EsNuevoCliente = true;

        Console.WriteLine("Datos del cliente:");
        Console.WriteLine("Nombre completo: " + cliente1.NombreCompleto);
        Console.WriteLine("Teléfono: " + cliente1.Telefono);
        Console.WriteLine("Dirección: " + cliente1.Direccion);
        Console.WriteLine("Email: " + cliente1.Email);
        Console.WriteLine("¿Es nuevo cliente?: " + (cliente1.EsNuevoCliente ? "Sí" : "No"));

        // Puedes crear más instancias de la estructura Cliente y asignarles valores a sus campos
        // Para acceder a los campos de la estructura, se utiliza el operador '.' (punto)

        Console.ReadLine();
    }
}