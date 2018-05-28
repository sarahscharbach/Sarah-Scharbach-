using System;
using System.Collections.Generic;

namespace Aufgabe_5
{
    class Kurs
    {
        public string titel;
        public string vorlesungssaal;
        public string wochentag;
        public string uhrzeit;

        public Dozent dozent;
        public List<Teilnehmer> teilnehmer;

        public void InfoText(){
            Console.WriteLine("Titel der Veranstaltung: " + titel);
            Console.WriteLine("Vorlesungssaal: " + vorlesungssaal);
            Console.WriteLine("Kurs Beginn: " + wochentag + ", " + uhrzeit + " Uhr");
        }
    }
}