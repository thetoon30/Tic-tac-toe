using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Game
    {
        char _layout;

        public void ChoosePosition(int position)
        {
            _layout = 'X';
        }

        public char GetPosition(int position)
        {
            return _layout;
        }
    }
}
