//1 - Ingresar un número y mostrar la suma de los números que lo anteceden.

using System;

namespace ExamenCSharp
{
    public class Ejercicio1
    {
        public static void SumaNumerosAnteriores()
        {
            int number = 0, addition = 0;
            bool isNumber = false;
            while(!isNumber)
            {
                Console.Write("Número: ");
                isNumber = Int32.TryParse(Console.ReadLine(),out number);
                if(!isNumber)
                {
                    Console.WriteLine("El dato ingresado no es un número, vuelva a intentar.");
                }else if(number < 0)
                {
                    Console.WriteLine("Solo acepto números positivos, ingrese otro número.");
                    isNumber = false;
                }
            }

            for(int i=0; i<number; i++)
            {
                addition += i;
            }
            Console.WriteLine($"La suma de todos los números anteriores a {number}\n da como resultado {addition}.");
        }
    }
}