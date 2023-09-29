using static ConsoleApp1.clase.ejercicios;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OTRO EJERCICIO

            //INTERVALO inter = new INTERVALO();
            //Console.WriteLine("Escribe el primer numero:");
            //int numero1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Escribe el segundo numero:");
            //int numero2 = int.Parse(Console.ReadLine());
            //inter.IntervaloDeDosNumeros(numero1, numero2);

            //RECURSIVO
            TablaMultiplicar tabla = new TablaMultiplicar();
            Console.WriteLine("Escribe el numero de la tabla del 1 al 10");
            int numero = int.Parse(Console.ReadLine());
            int num2 = 1;
            tabla.MultiplicarNumeroDiez(numero, num2);
        }
    }
}