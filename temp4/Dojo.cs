using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace temp4
{
    public class Dojo
    {
        private string[] _initialBoard;

        public Dojo(string[] initialBoard)
        {
            _initialBoard = initialBoard;
        }

        public string[] Fill(int x, int y, char fillCharacter)
        {
            var returned = new string[_initialBoard.Length];

            for (var i=0;i< _initialBoard.Length;i++)
            {
                returned[i] = _initialBoard[i].Replace(Convert.ToChar(" "), fillCharacter);
            }

            return returned;
        }
    }
}
