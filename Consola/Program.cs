using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Title = "Parcial 2";
            Console.WriteLine("Se va a generar los amigos con los siguientes números");            
            Procesador.Proceso();
            Console.ReadLine();
        }
    }
}
