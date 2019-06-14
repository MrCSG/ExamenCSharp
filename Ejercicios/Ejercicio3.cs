/* 3 - En una película existen dos tipos de pjsList
Los Humanos no infectados y los infectados (o zombies).

Los No infectados están vivos, los zombies: No.
Ambos comen, pero los zombies comen cerebros humanos.
Ambos caminan; pero los zombies caminan como....zombies.
Ambos emiten sonidos con la boca. Los no infectados hablan, los zombies hacen “Aggggggh!!!”

Hacer un programa que:
Cree dos instancias de zombie y un no infectado.
Los agregue a un ArrayList.
Luego recorra el array y, por cada uno de ellos muestre por pantalla:

Si esta vivo o no
Como come
Como camina
Hacerlo decir algo. */

using System;
using System.Collections.Generic;

namespace ExamenCSharp
{
    public class Ejercicio3
    {
        public static void HumanosVZombies()
        {
            Zombie z1 = new Zombie();
            Zombie z2 = new Zombie();
            Humano h1 = new Humano();

            List<Personaje> pjsList = new List<Personaje>(3);
            pjsList.Add(z1);
            pjsList.Add(h1);
            pjsList.Add(z2);

            for(int i=0; i<3; i++)
            {
                Console.Write($"Personaje N°{i+1}: ");
                Console.WriteLine(pjsList[i].Hablar());
                Console.Write("Está vivo? ");
                Console.WriteLine(pjsList[i].EstaVivo());
                Console.Write("Come cerebros? ");
                Console.WriteLine(pjsList[i].ComeCerebros());
                Console.WriteLine(pjsList[i].Caminar());
                
            }
        }
    }
}