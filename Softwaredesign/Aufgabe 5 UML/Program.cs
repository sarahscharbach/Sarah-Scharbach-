using System;

namespace Aufgabe_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Teilnehmer teilnehmer_01 = new Teilnehmer();
            teilnehmer_01.vorname = "Franz";
            teilnehmer_01.nachname = "Schulz";
            teilnehmer_01.matrikelnummer = 12345;
            teilnehmer_01.alter = 22;

            Kurs kurs_01 = new Kurs();
            kurs_01.titel = "Programmieren";
            kurs_01.vorlesungssaal = "C 1.10";
            kurs_01.wochentag = "Donnerstag";
            kurs_01.uhrzeit = "11.15";
            kurs_01.InfoText();
        }
    }
}