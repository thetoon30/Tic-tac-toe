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

        readonly string[] _winningXPatterns = new[]
                                                 {
                                                     "XXX......",
                                                     "...XXX...",
                                                     "......XXX",
                                                     "X..X..X..",
                                                     ".X..X..X.",
                                                     "..X..X..X",
                                                     "X...X...X",
                                                     "..X.X.X..",
                                                 };

        readonly string[] _winningOPatterns = new[]
                                                  {
                                                      "OOO......",
                                                      "...OOO...",
                                                      "......OOO",
                                                      "O..O..O..",
                                                      ".O..O..O.",
                                                      "..O..O..O",
                                                      "O...O...O",
                                                      "..O.O.O..",
                                                  };

        public string ChoosePosition(int position)
        {
            _layout[position - 1] = 'X';
            int firstUnoccupied = Enumerable.Range(0, _layout.Length)
                                            .First(p => _layout[p].Equals('\0'));
            _layout[firstUnoccupied] = 'O';

            var layoutAsString = new string(_layout);

            foreach (string pattern in _winningXPatterns)
            {
                if (Regex.IsMatch(layoutAsString, pattern))
                {
                    return "Player wins!";
                }   
            }

            foreach (string pattern in _winningOPatterns)
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
