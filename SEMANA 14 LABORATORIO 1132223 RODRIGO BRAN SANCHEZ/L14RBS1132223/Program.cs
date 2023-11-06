using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L14RBS1132223
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int numero, mayor = int.MinValue, menor = int.MaxValue, contadorPositivos = 0, contadorNegativos = 0;
            bool SEGUIR = true;

           
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Ingrese el número {0}: ", i + 1);
                numero = int.Parse(Console.ReadLine());

                
                if (numero > mayor)
                {
                    mayor = numero;
                }
                else if (numero < menor)
                {
                    menor = numero;
                }

              
                if (numero >= 0)
                {
                    contadorPositivos++;
                }
                else
                {
                    contadorNegativos++;
                }
            

          
            Console.WriteLine("El número mayor es {X}.", mayor);
            Console.WriteLine("El número menor es {X}.", menor);
            Console.WriteLine("La cantidad de números positivos es {X}.", contadorPositivos);
            Console.WriteLine("La cantidad de números negativos es {X}.", contadorNegativos);

       
            Console.WriteLine("¿Desea ingresar otra secuencia de números? (SI O NO): ");
            string respuesta = Console.ReadLine();

            if (respuesta.ToLower() == "n")
            {
                // Imprimimos los números ingresados
                Console.WriteLine("Los números ingresados son:");
                for (int J = 0; J < 7; J++)
                {
                    Console.WriteLine("{X}", numero);
                }
            }

            }
        }
    }
}




