//2 - Se ingresa por teclado la temperatura máxima, en grados, día a día durante una semana.
//Se pide determinar el día de mayor temperatura, el de menor y el promedio.

using System;

namespace ExamenCSharp
{
    public class Ejercicio2
    {
        public static void Temperaturas()
        {
            float[] temperature = new float[7];
            float lowestT = 1000f, highestT = -1000f, midT = 0;
            int i = 0, lowestDay = 0, highestDay = 0;
            while(i < 7)
            {
                Console.Write($"Temperatura del día {i+1}: ");
                if(!float.TryParse(Console.ReadLine(),out temperature[i]))
                {
                    Console.WriteLine("El dato ingresado no es un número, vuelva a intentar.");
                }else
                {
                    i++;
                }
            }
            for( i=0; i<7; i++)
            {
                if(temperature[i] > highestT)
                {
                    highestT = temperature[i];
                    highestDay = i+1;
                }
                if(temperature[i] < lowestT)
                {
                    lowestT = temperature[i];
                    lowestDay = i+1;
                }
                midT += temperature[i];
            }

            Console.WriteLine($"El día {highestDay} fue el que tuvo la mayor temperatura con {highestT}°C.");
            Console.WriteLine($"El día {lowestDay} fue el que tuvo la menor temperatura con {lowestT}°C.");
            Console.WriteLine($"En promedio hubo {midT/7}°C esta semana.");
        }
    }
}