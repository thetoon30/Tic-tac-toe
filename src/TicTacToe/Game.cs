using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Game
    {
        char[] _layout = new char[2];

        public void ChoosePosition(int position)
        {
            _layout[position - 1] = 'X';
            _layout[1] = 'O';
        }

        public char GetPosition(int position)
        {
            return _layout[position - 1];
        }
    }
}
