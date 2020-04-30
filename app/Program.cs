using System;
using System.Linq;
using System.Runtime.Serialization;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            var newBoard = new Board();
            var stringBoard = StringFormatter.ConvertObjectListToString(newBoard.GameBoard);
            
            Console.WriteLine(StringFormatter.formatGameBoard(stringBoard));
            
            
        }
    }
}