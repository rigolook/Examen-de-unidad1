using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.clase
{
//pequeño error por el apuro perdone
    internal class ejercicios
    {
        internal class TablaMultiplicar
        {
            public int MultiplicarNumeroDiez(int numero, int numeroMultiplicado)
            {

                while ((numero! > 0 && numero <= 10) && numeroMultiplicado <= 10)
                {

                    int multi;
                    multi = numero * numeroMultiplicado;

                    Console.WriteLine($"{numero}*{numeroMultiplicado}={multi}");

                    return MultiplicarNumeroDiez(numero, numeroMultiplicado + 1);
                }
                return numero;

            }

        }


    }
}
