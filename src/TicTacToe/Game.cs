using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Game
    {
        char[] _layout = new char[9];

        readonly string[] _winningPatterns = new[]
                                                 {
                                                     "[XO][XO][XO]......",
                                                     "...[XO][XO][XO]...",
                                                     "......[XO][XO][XO]",
                                                     "[XO]..[XO]..[XO]..",
                                                     ".[XO]..[XO]..[XO].",
                                                     "..[XO]..[XO]..[XO]",
                                                     "[XO]...[XO]...[XO]",
                                                     "..[XO].[XO].[XO]..",
                                                 };

        public string ChoosePosition(int position)
        {
            _layout[position - 1] = 'X';
            int firstUnoccupied = Enumerable.Range(0, _layout.Length)
                                            .First(p => _layout[p].Equals('\0'));
            _layout[firstUnoccupied] = 'O';

            if (WinningPlayerIs('X'))
            {
                return "Player wins!";
            }
                
            if (WinningPlayerIs('O'))
            {
                return "Game wins.";
            }

            return string.Empty;
        }

        private bool WinningPlayerIs(char player)
        {
            var layout = new string(_layout);

            if (player == 'X')
            {
                layout = layout.Replace('O', '\0');
            } 
            else
            {
                layout = layout.Replace('X', '\0');
            }

            foreach (string pattern in _winningPatterns)
            {
                if (Regex.IsMatch(layout, pattern))
                    return true;
            }

            return false;
        }

        public char GetPosition(int position)
        {
            return _layout[position - 1];
        }
    }
}
