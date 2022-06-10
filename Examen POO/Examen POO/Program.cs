using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Examen_POO
{
    class Program
    {
        class Inventario
        {
            //atributos 
            public string Nombre;
            public string Descripcion;
            public float Precio;
            public int Cantidad;

            public Inventario(string Nombre, string Descripcion, float Precio, int Cantidad)
            {
                this.Nombre = Nombre;
                this.Descripcion = Descripcion;
                this.Precio = Precio;
                this.Cantidad = Cantidad;

            }

            public void Desplguiegue ()
            {
                Console.WriteLine("Producto: " + Nombre);
                Console.WriteLine("Descripcion: " + Descripcion);
                Console.WriteLine("Precio: " + Precio);
                Console.WriteLine("Cantidad en Stock: " + Cantidad);
            }

        }
        static void Main(string[] args)
        {


            try
            {


                StreamWriter prod = new StreamWriter("Producto.txt", true);

                String str;

                Console.WriteLine("Ingresando al sistema AMAZON");


                Console.WriteLine("Escriba las líneas de texto para almacenar en el archivo.\n" + "Finalice cada línea pulsando la tecla<Entrar ");

                // Lee una línea de la entrada estándar
                str = Console.ReadLine();


                Console.Write("Ingrese el nombre del producto: ");
                string Nombre = Console.ReadLine();
                Console.Write("Ingrese la descripcion del producto:  ");
                string Descripcion = Console.ReadLine();
                Console.Write("Ingrese el precio del producto: ");
                float Precio = Single.Parse(Console.ReadLine());
                Console.Write("Ingrese la cantidad que esta en Stock: ");
                int Cantidad = int.Parse(Console.ReadLine());

                Inventario e1 = new Inventario(Nombre, Descripcion, Precio, Cantidad);

                prod.WriteLine(Nombre, Descripcion, Precio, Cantidad);
                Console.Clear();
                e1.Desplguiegue();

            }
            catch (IOException e)
            {
                Console.WriteLine("Error: " + e.Message);
                Console.WriteLine("Ruta: " + e.StackTrace);
            }
            Console.ReadKey();
            }
        }
    }
    

