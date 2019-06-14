using System;

namespace ExamenCSharp
{
    public class Zombie : Personaje
    {
        public override bool EstaVivo()
        {
            return false;
        }

        public override bool ComeCerebros()
        {
            return true;
        }

        public override string Caminar()
        {
            return "Camino como zombie";
        }

        public override string Hablar()
        {
            return "Aggggggh!!!";
        }
    }
}