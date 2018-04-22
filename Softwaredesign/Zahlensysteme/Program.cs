using System;

namespace Aufgabe_3
{
    class Program
    {
        static void Main(string[] args)
        {
           int inputNumber = int.Parse(args[0]);
           int inputToBase = int.Parse(args[1]);
           int inputFromBase = int.Parse(args[2]);

           if(inputNumber >= 0 && inputNumber <= 1023)
           {
               if(inputToBase >= 2 && inputToBase <= 10)
               {
                   if(inputFromBase >= 2 && inputFromBase <= 10)
                   {
                       Console.Write(ConvertNumberToBaseFromBase(inputNumber, inputToBase, inputFromBase));
                   }

                   else
                    {
                        Console.WriteLine("Der Wert der eingebenen Zahl muss zwischen 0 & 1023 liegen!");
                    } 
               }

                else
                {
                    Console.WriteLine("Der Wert in die umzurechnende Basis muss zwischen 2 & 10 liegen!");
                }

           }

            else
            {
                Console.WriteLine("Der Wert der eingebenen Zahl muss zwischen 0 & 1023 liegen!");
            } 
        } 

        static int ConvertDecimalToHexal(int dec)
        {   
            int toBase = 6;
            return ConvertToBaseFromDecimal(toBase, dec);
        }

          static int ConvertHexalToDecimal(int hexal)
        {
            int fromBase = 6;
            return ConvertToDecimalFromBase(fromBase, hexal);
        }

        static int ConvertToBaseFromDecimal(int toBase, int dec){
            int result;
            string saveNumber = "";

            for(int i = 0; ; i++)
            {
                result = dec % toBase;
                dec = dec / toBase;
                saveNumber = saveNumber.Insert(i, result.ToString());

                 if(dec == 0)
                 {
                        saveNumber = saveNumber.Reverse();
                        return int.Parse(saveNumber);
                }
            }
        }

        static int ConvertToDecimalFromBase(int fromBase, int number)
        {
           string saveNumber = number.ToString();
            saveNumber = saveNumber.Reverse();
            char[] splitString= saveNumber.ToCharArray();
            double[] numbers = new double[splitString.Length];
            double result;
            // Zahlen im Acii format beginnen erst ab 48
            int ascii = 48;

            for(int i = 0; i < splitString.Length; i++)
            {
                numbers[i] = (int) splitString[i] - ascii;
                numbers[i] = numbers[i] * (Math.Pow(fromBase, i));
            } 

            result = numbers[0];

            for(int j = 1; j < numbers.Length; j++)
            {
                result = result + numbers[j];  
            } 
            return (int) result;
        }

        static int ConvertNumberToBaseFromBase(int number, int toBase, int fromBase){
           return ConvertToBaseFromDecimal(toBase, ConvertToDecimalFromBase(fromBase, number));
        }
    }
}

    /* Extension zum String spiegeln von Günther Foidl*/
    /* https://dotnet-snippets.de/snippet/string-spiegeln/1017 */
	public static class StringExtension
	{
        	public static string Reverse(this string s)
		{
			char[] c = s.ToCharArray();
			Array.Reverse(c);
			return new string(c);
		}
	}
