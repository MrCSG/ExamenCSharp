using System;

namespace ExamenCSharp
{
    public class Humano : Personaje
    {
        public override bool EstaVivo()
        {
            return true;
        }

        public override bool ComeCerebros()
        {
            return false;
        }

        public override string Caminar()
        {
            return "Camino normal.";
        }

        public override string Hablar()
        {
            return "Mgghh... No soy zombie, solo soy gruñón.";
        }
    }
}