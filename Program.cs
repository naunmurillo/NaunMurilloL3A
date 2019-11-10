using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gasolinera2.Clases;
namespace Gasolinera2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();

            Console.WriteLine("Los apellidos del cliente es: ");
            cliente.Apellidos = Console.ReadLine();
            Console.WriteLine("Los nombres del cliente es: ");
            cliente.Nombres = Console.ReadLine();
            Console.WriteLine("La cédula del cliente es: ");
            cliente.Cedula = int.Parse(Console.ReadLine());
            Console.WriteLine("La dirección del cliente es: ");
            cliente.Apellidos = Console.ReadLine();


            Gasolina gasolina = new Gasolina();
            Console.WriteLine(" Ingrese el tipo de gasolina que desea: ");
            gasolina.Tipo = Console.ReadLine();
            Console.WriteLine("Ingrese la canntidad de galones que desea:");
            gasolina.Cantidad = double.Parse(Console.ReadLine());
            Console.WriteLine("El precio por galón es:" + gasolina.Precio);
          
            Console.WriteLine("El subtotal es: "+ gasolina.Subtotal);
            
            Console.WriteLine("El IVA es: "+ gasolina.Iva);
            
            Console.WriteLine("El total es: "+ gasolina.Total);

            Console.ReadKey();
        }
    }
}
