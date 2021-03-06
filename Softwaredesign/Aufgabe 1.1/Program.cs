﻿using System;

namespace Aufgabe_1
{
    class Program
    {
        static double A;
        static double V;

        public static double getCubeSurface(double durchmesser)
        {
            return 6 * Math.Pow(durchmesser, 2);
        }

        public static double getCubeVolume(double durchmesser)
        {
            return Math.Pow(durchmesser, 3);
        }

        public static String getCubeInfo(double durchmesser)
        {
            A = getCubeSurface(durchmesser);
            V = getCubeVolume(durchmesser);
            A = Math.Round(A, 2);
            V = Math.Round(V, 2);
            return "Würfel: " + " A = " + A + " | " + " V = " + V;
        }
        public static double getBulletSurface(double durchmesser)
        {
            return Math.PI * Math.Pow(durchmesser, 2);
        }

        public static double getBulletVolume(double durchmesser)
        {
            return (Math.PI * Math.Pow(durchmesser, 3)) / 6;
        }

        public static String getBulletInfo(double durchmesser)
        {
            A = getBulletSurface(durchmesser);
            V = getBulletVolume(durchmesser);
            A = Math.Round(A, 2);
            V = Math.Round(V, 2);
            return "Kugel: " + " A = " + A + " | " + " V = " + V;
        }

        public static double getOctahedronSurface(double durchmesser)
        {
            return 2 * Math.Sqrt(3) * Math.Pow(durchmesser, 2);
        }

        public static double getOctahedronVolume(double durchmesser)
        {
            return (Math.Sqrt(2) * Math.Pow(durchmesser, 3)) / 3;
        }

        public static String getOctahedronInfo(double durchmesser)
        {
            A = getOctahedronSurface(durchmesser);
            V = getOctahedronVolume(durchmesser);

            A = Math.Round(A, 2);
            V = Math.Round(V, 2);
            return "Oktaeder: " + " A = " + A + " | " + " V = " + V;
        }
        static void Main(string[] args)
        {

            switch (char.Parse(args[0]))
            {
                case 'w':
                    Console.WriteLine(getCubeInfo(Double.Parse(args[1])));

                    break;
                case 'k':
                    Console.WriteLine(getBulletInfo(Double.Parse(args[1])));
                    break;
                case 'o':
                    Console.WriteLine(getOctahedronInfo(Double.Parse(args[1])));
                    break;

                default:
                    Console.WriteLine("Die Eingabe " + args[0] + " " + args[1] + "wurde nicht erkannt!");
                    break;
            }
        }
    }
}
