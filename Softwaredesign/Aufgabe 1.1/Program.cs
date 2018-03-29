using System;

namespace Aufgabe_1
{
    class Program
    {
        static double A;
        static double V;

        public static double getCubeSurface(double d)
        {
            return 6 * Math.Pow(d, 2);
        }

        public static double getCubeVolume(double d)
        {
            return Math.Pow(d, 3);
        }

        public static String getCubeInfo(double d)
        {
            A = getCubeSurface(d);
            V = getCubeVolume(d);
            A = Math.Round(A, 2);
            V = Math.Round(V, 2);
            return "Würfel: " + " A = " + A + " | " + " V = " + V;
        }
        public static double getBulletSurface(double d)
        {
            return Math.PI * Math.Pow(d, 2);
        }

        public static double getBulletVolume(double d)
        {
            return (Math.PI * Math.Pow(d, 3)) / 6;
        }

        public static String getBulletInfo(double d)
        {
            A = getBulletSurface(d);
            V = getBulletVolume(d);
            A = Math.Round(A, 2);
            V = Math.Round(V, 2);
            return "Kugel: " + " A = " + A + " | " + " V = " + V;
        }

        public static double getOctahedronSurface(double d)
        {
            return 2 * Math.Sqrt(3) * Math.Pow(d, 2);
        }

        public static double getOctahedronVolume(double d)
        {
            return (Math.Sqrt(2) * Math.Pow(d, 3)) / 3;
        }

        public static String getOctahedronInfo(double d)
        {
            A = getOctahedronSurface(d);
            V = getOctahedronVolume(d);

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