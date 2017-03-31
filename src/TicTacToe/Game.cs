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

            string layoutAsString = new string(_layout).Replace('O', '\0');

            foreach (string pattern in _winningPatterns)
            {
                if (Regex.IsMatch(layoutAsString, pattern))
                {
                    return "Player wins!";
                }   
            }

            layoutAsString = new string(_layout).Replace('X', '\0');

            foreach (string pattern in _winningPatterns)
            {
                if (Regex.IsMatch(layoutAsString, pattern))
                {
                    return "Game wins.";
                }   
            }


            return string.Empty;
        }

        public char GetPosition(int position)
        {
            return _layout[position - 1];
        }
    }
}
