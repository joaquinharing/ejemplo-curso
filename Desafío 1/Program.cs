using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Desafío_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear la clase Telefono(recordemos que una clase va en un archivo nuevo; click derecho en el proyecto, agregar, class).
            Telefono t1 = new Telefono("A33", "Samsung");
            //Crear algunos objetos en el main de Program y probar escribirle datos y mostrar en pantalla el estado del Telefono.
            t1.NumeroTelefonico = "222 444 5555";
            t1.CodigoOperador = 2;
            string modelo = t1.Modelo;
            string marca = t1.Marca;

            Console.WriteLine("mi número es " + t1.NumeroTelefonico);
            //Probar métodos en el main mostrando en pantalla el comportamiento de los objetos.

            Console.WriteLine(t1.llamar("maxiprograma"));
            Console.WriteLine("mi teléfono es el modelo " + modelo + " de la marca " + marca);
        }
    }
}
