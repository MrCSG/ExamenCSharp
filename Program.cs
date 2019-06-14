using System;

namespace ExamenCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool close = false;
            string option;
            
            while(!close)
            {
                Console.WriteLine("Ingrese el número del ejercicio que desea ver (1,2 o 3):");
                option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                    {
                        Console.Clear();
                        Console.WriteLine("Ingrese un número para averiguar la suma de todos los números que lo anteceden.\n(Solo positivos sin coma)");
                        Ejercicio1.SumaNumerosAnteriores();
                        break;
                    }
                    case "2":
                    {
                        Console.Clear();
                        Console.WriteLine("Ingrese la temperatura(°C) de una semana para conocer su mayor, menor y temperatura promedio.");
                        Ejercicio2.Temperaturas();
                        break;
                    }
                    case "3":
                    {
                        Console.Clear();
                        Console.WriteLine("Se necesitan 2 zombies y 1 humano para esta pelicula, veamos si el casting estuvo bien:");
                        Ejercicio3.HumanosVZombies();
                        break;
                    }
                    default:
                    {
                        Console.Clear();
                        Console.WriteLine("Esa no es una opción, intentelo de nuevo.");
                        break;
                    }
                }
                Console.Clear();
                Console.Write("Desea salir? (Y/N)");
                option = Console.ReadLine();
                if(option == "Y" || option == "y")
                {
                    close = true;
                }
            }
        }
    }
}
