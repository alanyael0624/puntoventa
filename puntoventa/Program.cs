using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace puntoventa
{
    internal class Program
    {
        private static DateTimeOffset fecha;

        public static DateTimeOffset Fecha { get => fecha; set => fecha = value; }

        static void Main(string[] args)
        {

            int opcion = 0;
            do
            {
                Console.WriteLine("----MENU----");
                Console.WriteLine("\n " +
                    "\n 1. Venta nueva " +
                    "\n 2. Carrito " +
                    "\n 3. Cerrar \n");
                Console.WriteLine("Elige una opcion : ");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        int close = 0;

                        do
                        {


                            string nombrep;
                            int cantidadp = 0;
                            double costef = 0.0;
                            double tf1;

                            Console.WriteLine("-Ingrese el nombre del producto: ");
                            nombrep = Console.ReadLine();
                            Console.WriteLine("-Ingrese la cantidad de productos : " + nombrep);
                            cantidadp = int.Parse(Console.ReadLine());
                            Console.Write("-Ingrese el costo unitario del producto: " + nombrep + "\n$");
                            costef = double.Parse(Console.ReadLine());

                            tf1 = costef * cantidadp;
                            Console.WriteLine();


                            StreamWriter fichero;
                            string NombreFichero = "C:\\Users\\Alan\\Documents\\Venta\\DateTime.txt";
                            fichero = File.AppendText(NombreFichero);
                            fichero.WriteLine(cantidadp + " PRODUCTOS " + nombrep + " : $" + tf1);
                            fichero.Close();
                            Console.WriteLine("¿desea agregar otro producto?");
                            close = Convert.ToInt32(Console.ReadLine());
                        }
                        while (close != 0);


                        break;

                    case 2:

                        StreamReader Fichero;
                        string linea;

                        Fichero = File.OpenText("C:\\Users\\Alan\\Documents\\Venta\\DateTime.txt");
                        do
                        {
                            linea = Fichero.ReadLine();
                            Console.WriteLine(linea);
                        } while (linea != null);
                        Fichero.Close();
                        Console.ReadLine();
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("GRACIAS POR TU COMPRA");
                        break;
                }



            }
            while (opcion != 3);



        }
    }
}



