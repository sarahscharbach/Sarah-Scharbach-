using System;

namespace Aufgabe_6_Decorator
{
    abstract class Spielfigur
    {
        public abstract void Drohe();
    }

     class Monster : Spielfigur
    {
        public override void Drohe()
        {
            Console.Write(" Grrrrr! ");
        }
    }

    class Held : Spielfigur
   {
       public override void Drohe()
       {
           Console.Write(" Weiche zurück! ");
       }
   }
}