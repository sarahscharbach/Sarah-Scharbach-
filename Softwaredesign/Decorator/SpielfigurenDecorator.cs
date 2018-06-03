using System;

namespace Aufgabe_6_Decorator
{

    abstract class Dekorierer : Spielfigur
    {
        private Spielfigur _meineFigur;

        public Dekorierer(Spielfigur meineFigur)
        {
            this._meineFigur = meineFigur;
        }

        public override void Drohe()
        {
            _meineFigur.Drohe();
        }
    }

    class ErkaelteteFigur : Dekorierer
    {
        public ErkaelteteFigur(Spielfigur meineFigur)
            : base(meineFigur)
        { }

        public override void Drohe()
        {
            Console.Write(" Hust! ");
            base.Drohe();
        }
    }

     class HeisereFigur :  Dekorierer
    {
        public HeisereFigur(Spielfigur meineFigur)
            : base(meineFigur)
        { }

        public override void Drohe()
        {
            Console.Write(" Räusper... ");
           base.Drohe();
        }
    }
}