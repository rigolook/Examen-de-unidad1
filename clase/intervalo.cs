using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.clase
{
    internal class intervalo
    {
        public int IntervaloDeDosNumeros(int numero1, int numero2)
        {
            if (numero1 < numero2 && numero1! > numero2)
            {

                for (int i = 0; numero1 < numero2; i++)
                {




                    Console.WriteLine("La secuencia de los numeros es " + numero1);

                    return IntervaloDeDosNumeros(numero1 + 1, numero2);
                }

            }
            else if (numero1 == numero2)
            {
                Console.WriteLine("Los numeros ingresados son iguales.");
            }
            else if (numero1 > numero2 && numero2! > numero1)
            {

                for (int i = 0; numero1 < numero2; i++)
                {

                    Console.WriteLine("La secuencia de los numeros es " + numero1);

                    return IntervaloDeDosNumeros(numero1 - 1, numero2);
                }
            }
            return numero1;
        }
    }
}
