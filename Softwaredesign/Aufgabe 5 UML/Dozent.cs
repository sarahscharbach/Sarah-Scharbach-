using System;
using System.Collections.Generic;

namespace Aufgabe_5
{
    class Dozent : Person
    {
     public string wochentag;
     public string uhrzeit;
     public string buero;

     public List<Kurs> kurse;

     public void gehalteneKurse()
        {
            foreach(Kurs k in kurse)
            {
                Console.WriteLine("Titel der Veranstaltung: " + k.titel);
                Console.WriteLine("Vorlesungssaal: " + k.vorlesungssaal);
                Console.WriteLine("Kurs Beginn: " + k.wochentag + ", " + k.uhrzeit + " Uhr");
            }
        }

    public List<Teilnehmer> eingeschriebeneTeilnehmer()
        {
            List<Teilnehmer> alleTeilnehmer = new List<Teilnehmer>();
            foreach(Kurs k in kurse)
            {
                foreach(Teilnehmer t in k.teilnehmer)
                {
                    if(!alleTeilnehmer.Contains(t));
                    alleTeilnehmer.Add(t);
                }
            }

            return alleTeilnehmer;
        }
    }
}