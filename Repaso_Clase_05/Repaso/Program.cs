using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    public class TestEstante
    {
        static void Main(string[] args)
        {
            Console.Title = "Repaso";

            /* Producto productoNro1 = new Producto("Adidas", "asd123", 2500);
             Producto productoNro2 = new Producto("Adidas", "asd123", 2500);
             Producto productoNro3 = new Producto("Nike", "qwe456", 2800);
             Producto productoNro4 = new Producto("Puma", "zxc789", 3000);

             if(productoNro1 == productoNro2)
             {
                 Console.ForegroundColor = ConsoleColor.Red;
                 Console.WriteLine("Los productos son los mismos");
                 Console.ReadKey();
             }
             else
             {
                 Console.ForegroundColor = ConsoleColor.Green;
                 Console.WriteLine("Los productos son diferentes");
                 Console.ReadKey();
             }

             if(productoNro3 == "Nike")
             {
                 Console.ForegroundColor = ConsoleColor.Green;
                 Console.WriteLine("La marca del proucto es la introducida");
                 Console.ReadKey();
             }
             else
             {
                 Console.ForegroundColor = ConsoleColor.Red;
                 Console.WriteLine("La marca del producto NO es la introducida");
                 Console.ReadKey();
             }

             Console.ForegroundColor = ConsoleColor.Yellow;
             Console.WriteLine("\nProducto Nro 4: \n\n{0}",Producto.MostrarProducto(productoNro4));
             Console.ReadKey();
             */
            // Creo un estante
            Estante estante = new Estante(3, 1);
            // Creo 4 productos
            Producto p1 = new Producto("Pepsi", "PESDS97413", (float)18.5);
            Producto p2 = new Producto("Coca-Cola", "COSDS55752", (float)11.5);
            Producto p3 = new Producto("Manaos", "MASDS51292", (float)20.5);
            Producto p4 = new Producto("Crush", "CRSDS54861", (float)10.75);
            // Agrego los productos al estante
            if (estante + p1)
            {
                Console.WriteLine("Agregó {0} {1} {2}", p1.GetMarca(), (string)p1, p1.GetPrecio());
            }
            else
            {
                Console.WriteLine("¡NO agregó {0} {1} {2}!", p1.GetMarca(), (string)p1, p1.GetPrecio());
            }
            if (estante + p1)
            {
                Console.WriteLine("Agregó {0} {1} {2}", p1.GetMarca(), (string)p1, p1.GetPrecio());
            }
            else
            {
                Console.WriteLine("¡NO agregó {0} {1} {2}!", p1.GetMarca(), (string)p1, p1.GetPrecio());
            }
            if (estante + p2)
            {
                Console.WriteLine("Agregó {0} {1} {2}", p2.GetMarca(), (string)p2, p2.GetPrecio());
            }
            else
            {
                Console.WriteLine("¡NO agregó {0} {1} {2}!", p2.GetMarca(), (string)p2, p2.GetPrecio());
            }
            if (estante + p3)
            {
                Console.WriteLine("Agregó {0} {1} {2}", p3.GetMarca(), (string)p3, p3.GetPrecio());
            }
            else
            {
                Console.WriteLine("¡NO agregó {0} {1} {2}!", p3.GetMarca(), (string)p3, p3.GetPrecio());
            }
            if (estante + p4)
            {
                Console.WriteLine("Agregó {0} {1} {2}", p4.GetMarca(), (string)p4, p4.GetPrecio());
            }
            else
            {
                Console.WriteLine("¡NO agregó {0} {1} {2}!", p4.GetMarca(), (string)p4, p4.GetPrecio());
            }
            // Muestro todo el estante
            Console.WriteLine();
            Console.WriteLine("<------------------------------------------------->");
            Console.WriteLine(Estante.MostrarEstantes(estante));
            Console.ReadKey();

        }
    }
}
