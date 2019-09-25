using System;
using System.Collections;
using Cliente;

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Datos nuevoCliente = new Datos();
            ArrayList misClientes = new ArrayList();
            Random varAleatorio = new Random();

            string[] personaNombres =
            {
                "Maggie", "Tatiana", "Olivia",
                "Jorge", "Omar", "Karla", "Mitzy",
                "Vianey", "Alejandra", "Luis", "Edgar"
            };

            for(int i = 0; i < 3; i++)
            {
                
                int inNombres = varAleatorio.Next(personaNombres.Length);
                nuevoCliente.Nombre = personaNombres[inNombres];
                nuevoCliente.Edad = (byte)varAleatorio.Next(76);
                Console.WriteLine(" Nombre: {0} \n Edad: {1} ", nuevoCliente.Nombre, nuevoCliente.Edad);

                inNombres = varAleatorio.Next(2);
                if(inNombres == 1)
                {
                    nuevoCliente.Moroso = true;
                    Console.WriteLine(" Moroso: Si \n");
                }
                else
                {
                    nuevoCliente.Moroso = false;
                    Console.WriteLine(" Moroso: No \n");
                }
                misClientes.Add(nuevoCliente);
            }

            //Console.WriteLine("A quien deseas eliminar");
            //misClientes.Remove(Console.ReadLine());
            for (int a = 0; a < misClientes.Count; a++)
            {
                Datos verCliente = new Datos();

                verCliente = (Datos)misClientes[a];
                Console.WriteLine(" Nombre: {0} \n Edad: {1} ", verCliente.Nombre, verCliente.Edad);
                if (verCliente.Moroso)
                {
                    Console.WriteLine(" Moroso: Si \n");
                }
                else
                {
                    Console.WriteLine(" Moroso: No \n");
                }
            }

        }
    }
}
