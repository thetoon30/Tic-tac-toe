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
            if (IsOutOfRange(position))
            {
                return "That spot is invalid!";
            }

            if (_layout[position - 1] != '\0')
            {
                return "That spot is taken!";
            }

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
            var layout = GetLayoutFor(player);
            return _winningPatterns.Any(pattern => Regex.IsMatch(layout, pattern));
        }

        private string GetLayoutFor(char player)
        {
            return new string(_layout.ToList()
                                  .Select(c => (c.Equals(player)) ? player : '\0')
                                  .ToArray());
        }

        private bool IsOutOfRange(int position)
        {
            return position  > _layout.Count();
        }

        public char GetPosition(int position)
        {
            return _layout[position - 1];
        }
    }
}
