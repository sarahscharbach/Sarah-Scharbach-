using System;

namespace TicTacToe
{

    class GameLogic
    {
        public char[] gameData = new char[9];
        public int count = 0;
        public char turn = 'x';
        public bool win = false;
        public bool canConvert;
        public int input;
        public void PrintField()
        {
            Console.WriteLine("- - -");
            Console.WriteLine(gameData[0] + " " + gameData[1] + " " + gameData[2]);
            Console.WriteLine(gameData[3] + " " + gameData[4] + " " + gameData[5]);
            Console.WriteLine(gameData[6] + " " + gameData[7] + " " + gameData[8]);
            Console.WriteLine("- - -");
        }
        public bool checkWin()
        {
            int[,] cases = new int[,] { { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 }, { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 }, { 0, 4, 8 }, { 2, 4, 6 } };

            for (int i = 0; i < gameData.Length - 1; i++)
            {
                if (gameData[cases[i, 0]] == turn && gameData[cases[i, 1]] == turn && gameData[cases[i, 2]] == turn)
                {
                    return true;
                }
            }
            return false;
        }

        public char ChangePlayer()
        {
            if (count % 2 == 0)
            {
                return turn = 'x';
            }
            else
            {
                return turn = 'o';
            }
        }

        public void AddInput()
        {
            if (canConvert == true)
            {
                if (gameData[input - 1] == 'x' || gameData[input - 1] == 'o')
                {
                    Console.WriteLine("Feld besetzt!" + "\n" + "Versuche bitte ein anderes Feld!");
                }
                else
                {
                    gameData[input - 1] = turn;
                    count++;
                }
            }
            else
            {
                Console.WriteLine("Falsche Eingabe!" + "\n" + "Bitte eine Zahl zwischen 1 & 9 eingeben!");
            }
        }
    }
}