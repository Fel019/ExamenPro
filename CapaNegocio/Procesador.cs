using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Procesador
    {
        /// <summary>
        /// Metodo principal
        /// </summary>
        /// <param name="args"></param>
        public static void Proceso()
        {
            var amigos = AgregarAmigos();

            foreach (Amigos amigo in amigos)
            {
                if (SonAmigos(amigo.numero_uno, amigo.numero_dos)) // este es un if
                {
                    Console.WriteLine($"{amigo.numero_uno} y {amigo.numero_dos} son números amigos.");
                }
                else
                {
                    Console.WriteLine($"{amigo.numero_uno} y {amigo.numero_dos} no son números amigos.");
                }
            }

            
        }

        /// <summary>
        /// Esta fase se encarga de calcular los divisores de cada número.
        /// Y a medida que los encuentra los va almacenando en una variable tipo lista,
        /// Se organiza un mapeo de los posibles numero que el residuo sea igual a 0 y se aceptan en el lis tado
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        internal static List<int> ObtenerDivisores(int num)
        {
            List<int> divisores = new List<int>();
            for (int i = 1; i <= num / 2; i++) // este es un for
            {
                if (num % i == 0)
                {
                    divisores.Add(i);
                }
            }
            return divisores;
        }

        /// <summary>
        /// En esta fase captura los divisores de cada número en una lista y los va sumando, 
        /// como es una lista se debe recorrer cada posición usando un for, 
        /// en este caso usamos un foreach ya que es mas facil de manejar en C#
        /// </summary>
        /// <param name="divisores"></param>
        /// <returns></returns>
        internal static int SumarDivisores(List<int> divisores)
        {
            int suma = 0;
            foreach (int divisor in divisores) // este es un Foreach
            {
                suma += divisor;
            }
            return suma;
        }

        /// <summary>
        /// En esta fase, su funcion es recolectar ambos numeros y calcular que sean amigos
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        internal static bool SonAmigos(int num1, int num2)
        {
            int sumaDivisoresNum1 = SumarDivisores(ObtenerDivisores(num1));
            int sumaDivisoresNum2 = SumarDivisores(ObtenerDivisores(num2));

            return sumaDivisoresNum1 == num2 && sumaDivisoresNum2 == num1;// Este es un if lamda
        }        

        /// <summary>
        /// Agregamos los números solicitados por el docente.
        /// </summary>
        /// <returns></returns>
        private static List<Amigos> AgregarAmigos()
        {
            List<Amigos> amigos = new List<Amigos>();
            amigos.Add(new Amigos { numero_dos =  1184, numero_uno = 121 });
            amigos.Add(new Amigos{ numero_dos = 1354, numero_uno = 1368 });
            amigos.Add(new Amigos{ numero_dos = 5020, numero_uno = 5564 });
            amigos.Add(new Amigos{ numero_dos = 325, numero_uno = 250 });
            amigos.Add(new Amigos{ numero_dos = 55, numero_uno = 33 });
            return amigos;
        }
    }
}