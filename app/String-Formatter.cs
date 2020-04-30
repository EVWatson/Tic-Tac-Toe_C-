using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace app
{
    public class StringFormatter
    {
        public static string ConvertObjectListToString(List<Square> gameBoard)
        {
            var stringBoard = "";

            for (var i = 0; i < gameBoard.Count(); i++)
            {
                stringBoard += gameBoard[i].Symbol;
            }

            return stringBoard;
        }

        public static string formatGameBoard(string gameBoard)
        {
            var stringBuilder = new StringBuilder(gameBoard);

            for (var i = 0; i < gameBoard.Length; i++)
            {
                stringBuilder.Insert(i," ");

                if (gameBoard[i] %3 == 0)
                {
                    stringBuilder.Insert(i, "\n");
                }
            }

            return gameBoard.Trim();
        }

    }
    
    
}