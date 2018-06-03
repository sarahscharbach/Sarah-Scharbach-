using System;

namespace Aufgabe_6_Singleton
{
  public class IDGenerator
    {
        private IDGenerator()
        {
            letzteID = 1;
        }

        private static IDGenerator _instance;

        public static IDGenerator Instance
        {
            get
            {
                if (_instance == null)
                _instance = new IDGenerator();
                return _instance;
            }
        }

       

        private int letzteID;
        public int GibMirNeId()
        {
            return letzteID++;
        }
    } 
}