using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Game
    {
        char[] _layout = new char[9];

        public string ChoosePosition(int position)
        {
            _layout[position - 1] = 'X';
            int firstUnoccupied = Enumerable.Range(0, _layout.Length)
                                            .First(p => _layout[p].Equals('\0'));
            _layout[firstUnoccupied] = 'O';

            if (new string(_layout.ToArray()).StartsWith("XXX"))
                return "Player wins!";

            return string.Empty;
        }

        public char GetPosition(int position)
        {
            return _layout[position - 1];
        }
    }
}
