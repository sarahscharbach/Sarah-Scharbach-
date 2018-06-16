using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            GameLogic logic = new GameLogic();

            for (int i = 0; i < logic.gameData.Length; i++)
            {
                logic.gameData[i] = Convert.ToChar(i + 49);
            }

            for (; ; )
            {
                logic.PrintField();

                Console.WriteLine("Spieler " + logic.turn + " bitte Zug eingeben (1-9)");
                logic.canConvert = int.TryParse(Console.ReadLine(), out logic.input);

                logic.AddInput();

                if (logic.checkWin() == true)
                {
                    Console.WriteLine("Spieler " + logic.turn + " hat gewonnen :)");
                    logic.PrintField();
                    break;
                }

                if (logic.count == 9)
                {
                    Console.WriteLine("Unentschieden!");
                    logic.PrintField();
                    break;
                }

                logic.ChangePlayer();
            }
        }
    }
}
