using System.Diagnostics.SymbolStore;

namespace app
{
    public class Square
    {
        public Square(string symbol)
        {
            Symbol = symbol;
        }

        
        public string Symbol { get; }

        public override string ToString()
        {
            return Symbol;
        }
    }
}