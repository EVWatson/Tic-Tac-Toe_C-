using System.Collections.Generic;
using System.Dynamic;

namespace app
{
    public class Board
    
    {
        public Board()
        {
            GameBoard = InitialiseBoard();
        }
        private List<Square> InitialiseBoard()
        {
            var gameBoard = new List<Square>();

            for (var i = 0; i < 9; i++)
            {
                gameBoard.Add(new Square("H"));
            }

            return gameBoard;
        }
        
        public List<Square> GameBoard { get; }
       
    }
    
    
}