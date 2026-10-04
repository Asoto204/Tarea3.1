
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- CASO 2: PRECIO DE UNA COMPRA ---");

            Console.Write("Ingrese el precio unitario del producto (₡): ");
            string entradaPrecio = Console.ReadLine();

            Console.Write("Ingrese la cantidad comprada: ");
            string entradaCantidad = Console.ReadLine();

            // Validar que ambos valores sean numéricos
            if (double.TryParse(entradaPrecio, out double precio) && int.TryParse(entradaCantidad, out int cantidad))
            {
                // Validar valores mayores a cero
                if (precio <= 0 || cantidad <= 0)
                {
                    Console.WriteLine("Error: El precio y la cantidad deben ser mayores a cero.");
                }
                else
                {
                    double subtotal = precio * cantidad;

                    // Aplicar descuento del 10% si supera los ₡25,000
                    if (subtotal > 25000)
                    {
                        double descuento = subtotal * 0.10;
                        double totalFinal = subtotal - descuento;

                        Console.WriteLine($"\nSubtotal: ₡{subtotal:N2}");
                        Console.WriteLine($"Descuento (10%): ₡{descuento:N2}");
                        Console.WriteLine($"Total a pagar: ₡{totalFinal:N2}");
                    }
                    else
                    {
                        Console.WriteLine($"\nSubtotal: ₡{subtotal:N2}");
                        Console.WriteLine("Descuento: No aplica");
                        Console.WriteLine($"Total a pagar: ₡{subtotal:N2}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Error: Ingrese datos numéricos válidos.");
            }



        }
    }
}
